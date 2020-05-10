using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace GW_INSTEK_PSW_Series_Programmable_DC_Power_Supply
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private bool PowerONF = false;//power ON/OFF flag
        private double OVP_voltage;//CV
        private double VoltageOut;
        private double OCP_current;
        private double CurrentOut; //CC
        private double PowerON_delay;
        private double PowerOFF_delay;

        private bool txtinfoBoxF;//for txtinfo box show/hide
      
        #region serial port
        SerialPort mySerialPort = new SerialPort();

        private int SerialPortSelectIndex;//for retrieve saved port
        private bool portOpened;
        private bool _continue_reader, _continue_writer;
        private List<string> COMmsgToWrite = new List<string>();
        private byte[] COMmsgByteToWrite;

        private object COMmsgToWriteLocked = new object();
        private object MsghandleLocked = new object();
       // private byte[] sBuffer = new byte[1026];//for serial port recevier, 513x2 from to MCU, 0x55, 0xAA plus 512 bytes ADC dATA
        private bool sDataReady;
        private bool sDataUsed;
        private Object mLock = new Object();
        private List<byte[]> DataFromRead = new List<byte[]>();
        public List<string> datacaptured = new List<string>();

        public delegate void SetTextCallback(string text);
        public void SetText(string text)
        {
            //this.txtinfo.AppendText(text);
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            try
            {
                if (this.txtinfo.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText);
                  
                    this.BeginInvoke(d, new object[] { text });         //BeginInvoke REPLACED Invoke to fixed freeze when close the port

                }
                else
                {
                    if (txtinfo.Lines.Count() > 5000)
                    {
                        txtinfo.Clear();
                    }
                    this.txtinfo.AppendText(text);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("SetText" + ex.Message);
            }

        }
        private void openport()
        {
            // tmrPinStatus.Start();
            try
            {
                if (cbCOM.SelectedItem == null)
                {
                    MessageBox.Show("Please select a COM Port");
                    return;
                }
                else
                {
                    mySerialPort.PortName = cbCOM.SelectedItem.ToString();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            mySerialPort.BaudRate =  115200;

            mySerialPort.DataBits = 8;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.Handshake = Handshake.None;

            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            try
            {
                mySerialPort.Open();
                _continue_reader = true;
                _continue_writer = true;
                portOpened = true;
                //get port info 

                //sPortBufferSize = mySerialPort.ReadBufferSize;
                //sBuffer = new byte[sPortBufferSize];
                //sPortBufferIndex = 0;

                //writer threader
                Thread tWriter = new Thread(COMmsgWriteThread);
                tWriter.Name = @"Write COM Port Threader!";
                try
                {
                    tWriter.Start();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            

                tsbtnOpenPort.Image = Properties.Resources.connected_48;
                lblPort.Text = "Port: " + mySerialPort.PortName + " Opened!";
                lblPort.Text = "Ports: " + mySerialPort.PortName + ": " + mySerialPort.BaudRate.ToString() + "-" + mySerialPort.DataBits.ToString()
                              + "-" + mySerialPort.Parity.ToString() + "-" + mySerialPort.StopBits.ToString() + "-" + mySerialPort.Handshake.ToString()
                              + " Opened";
            }
            catch (Exception ex1)
            {
              //  txtUart_info.AppendText(ex1.Message + "\r\n");
                Console.WriteLine(ex1.Message);
            }

            Console.WriteLine("COM port opened");
        }
        private void closeport()
        {
            //  tmrPinStatus.Stop();

            try
            {
                if (mySerialPort.IsOpen)
                {
                    mySerialPort.Close();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("mySerialPort.Close()" + ex.Message);
            }


            _continue_reader = false;
            _continue_writer = false;
            portOpened = false;

            tsbtnOpenPort.Image = Properties.Resources.disconnected_48;


            lblPort.Text = "Port Closed";
        }

        //public void COMmsgWriteThread()
        //{
        //    while (_continue_writer)
        //    {
        //        try
        //        {
        //            lock (COMmsgToWriteLocked)
        //            {
        //                if (COMmsgByteToWrite != null)
        //                {

        //                    mySerialPort.Write(COMmsgByteToWrite, 0, COMmsgByteToWrite.Count());
        //                    COMmsgByteToWrite = null;
        //                    COMmsgToWrite.RemoveAt(0);
        //                }
        //            }
        //            Thread.Sleep(5);//reduce CPU resource usage
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }
        //    }



        //}
        public void COMmsgWriteThread()
        {
            while (_continue_writer)
            {
                try
                {
                    lock (COMmsgToWriteLocked)
                    {
                        if (COMmsgToWrite.Count() > 0)
                        {
                          
                            mySerialPort.Write(COMmsgToWrite[0]);
                            COMmsgToWrite.RemoveAt(0);
                        }
                    }               
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Thread.Sleep(5);//reduce CPU usage
            }
        
        }
        int bytesCount = 0;
        private StringBuilder myStringbuilder = new StringBuilder();
        private StringBuilder mCaptureSB = new StringBuilder();
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {

                myStringbuilder.Append(mySerialPort.ReadExisting());
                // buffer += mySerialPort.ReadExisting();

                mCaptureSB.Append(myStringbuilder.ToString()+"|");//copy to another stingbuilder for show PSU status

                myStringbuilder = myStringbuilder.Replace("\r", "\r\n");
                //if (captureF)
                //{
                //    mCaptureSB.Append(myStringbuilder.ToString());//copy to another stingbuilder for saving to  txt file
                //}
              

                if(txtinfoBoxF)
                {
                    SetText(myStringbuilder.ToString());
                }
              
                myStringbuilder.Length = 0;
                myStringbuilder.Capacity = 0;         
            }
            catch (Exception ex)
            {
                Console.WriteLine("DataReceivedHandler error: " + ex.Message);
            }
      
        }
        #endregion

        private void tsbtnOpenPort_Click(object sender, EventArgs e)
        {
            if (!portOpened)
            {
                //update selected serial port index
                Properties.Settings.Default.SerialPort_Sel_Idx = cbCOM.SelectedIndex;
                Properties.Settings.Default.Save();
                openport();
            }
            else//open opened then close port
            {
                closeport();
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";

            try 
            {
                if (lst2rdStr.Items.Count > 0)
                {
                    msg = lst1stStr.SelectedItem.ToString() + lst2rdStr.SelectedItem.ToString() + "\r\n";
                }
                else if (txtMsg.Text != "")
                {
                    msg = lst1stStr.SelectedItem.ToString() + txtMsg.Text + "\r\n";
                }
                else//only lst1stStr box
                {
                    msg = lst1stStr.SelectedItem.ToString() + "\r\n";
                }

                txtinfo.AppendText("\r\nSending: " + msg);
                if (portOpened)
                {
                    COMmsgToWrite.Add(msg);
                }
                else
                {
                    MessageBox.Show("Port not opened!");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Select a item from 2nd list box!\r\n"+ex.Message);
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string msg =txtCmd.Text + "\r\n";
            txtinfo.AppendText("Sending: " + msg);
            if (portOpened)
            {
                COMmsgToWrite.Add(msg);
            }
            else
            {
                MessageBox.Show("Port not opened!");
            }
          
        }

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            closeport();         
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeport();
            Application.Exit();
        }

        private void rdOUTPut_CheckedChanged(object sender, EventArgs e)
        {
            lst1stStr.Items.Clear();
            if (rdOUTPut.Checked)
            {
                lst1stStr.Items.Add("OUTPut:STATe:IMMediate");
                lst1stStr.Items.Add("OUTPut:DELay:ON");
                lst1stStr.Items.Add("OUTPut:DELay:OFF");
                lst1stStr.Items.Add("OUTPut:MODE");
                lst1stStr.Items.Add("OUTPut:STATe:TRIGgered");
                lst1stStr.Items.Add("OUTPut:PROTection:CLEar");
                lst1stStr.Items.Add("OUTPut:PROTection:TRIPped");
                

            }
        }

        private void lst1stStr_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst2rdStr.Items.Clear();
            txtMsg.Text = "";
            lblinfo.Text = "info";
            int caseSW = lst1stStr.SelectedIndex;
            if(rdOUTPut.Checked)
            {
                //int caseSW = lst1stStr.SelectedIndex;
                switch (caseSW)
                {
                    case 0://OUTPut:STATe:IMMediate
                        lst2rdStr.Items.Add(" 1");//ON
                        lst2rdStr.Items.Add(" 0");//OFF
                        lst2rdStr.Items.Add("?");//Query
                        break;
                    case 1://OUTPut:DELay:ON
                        txtMsg.Text = " 2";
                        lblinfo.Text = "Enter Space + 0~ 99.99" +"\r\n" 
                                        + " or ? wo space";
                        break;
                    case 2://OUTPut:DELay:OFF
                        txtMsg.Text = " 2";
                        lblinfo.Text = "Enter Space + 0~ 99.99" + "\r\n" 
                                        + " or ? wo space";
                        break;
                    case 3://OUTPut:MODE
                        lst2rdStr.Items.Add(" CVHS");//0,constance voltage HighSpeed
                        lst2rdStr.Items.Add(" CCHS");//1,
                        lst2rdStr.Items.Add(" CVLS");//2,3
                        lst2rdStr.Items.Add(" CCLS");//

                        lst2rdStr.Items.Add("?");//Query
                        break;
                    case 4://OUTPut:STATe:TRIGgered
                        lst2rdStr.Items.Add(" OFF");//0,
                        lst2rdStr.Items.Add(" ON");//1,
                        lst2rdStr.Items.Add("?");//Query
                        break;
                    case 5://OUTPut:PROTection:CLEar
                       //don't need this
                        break;
                    case 6://OUTPut:PROTection:TRIPped
                        lst2rdStr.Items.Add("?");//Query only
                        break;
                    default:
                        //
                        break;
                }


            }
            if(rdAbort.Checked)
            {
                //nothing to add
            }
            if(rdAPPLy.Checked)
            {
                txtinfo.AppendText("You can enter ? in the 3rd textbox for querying Voltage and Current.\r\n");
                txtinfo.AppendText("Or set output Voltage and Current. example: APPLy 24.0, 2\r\n");
                txtinfo.AppendText("Don't forget add a space before the digis\r\n");
                txtMsg.Text = "?";
                lblinfo.Text = "Query or Set:";
            }
            if(rdDISPlay.Checked)
            {
                switch (caseSW)
                {
                    case 0://DISP:MENU:NAME 0 (0,1,2,3,4)
                        lst2rdStr.Items.Add(" 0");// V/A
                        lst2rdStr.Items.Add(" 1");// V/W
                        lst2rdStr.Items.Add(" 2");// W/A
                        lst2rdStr.Items.Add(" 3");// Set Menu
                        lst2rdStr.Items.Add(" 4");// OVP/PCP Menu
                        lst2rdStr.Items.Add("?");//Query
                        break;
                    case 1://DISPlay[:WINDow]:TEXT[:DATA]
                        lblinfo.Text = "Enter string in the txtbox\r\n or ? for Querying.";
                        txtMsg.Text = " \"12345678\"";
                        // on the MFG datasheet says this will display ascii 0x20~0x7E
                        //but somehow this is not true some ascii will not dispaly correctly, why???
                        break;
                    case 2://Clear Text  
                        //nothing needed here
                        break;
                    case 3:// Blink
                        lst2rdStr.Items.Add(" ON");// 
                        lst2rdStr.Items.Add(" OFF");// 
                        lst2rdStr.Items.Add("?");// 
                        break;
                
                    default:
                        //
                        break;
                }
            }
            if(rdSENSe.Checked)
            {
                txtinfo.AppendText("0 is Low Level of smoothing\r\n");
                txtinfo.AppendText("1 is Middle Level of smoothing\r\n");
                txtinfo.AppendText("0 is High Level of smoothing\r\n");
                lst2rdStr.Items.Add(" 0");// Low level of smoothing
                lst2rdStr.Items.Add(" 1");// Mid level of smoothing
                lst2rdStr.Items.Add(" 2");// Hi level of smoothing
                lst2rdStr.Items.Add("?");//for querying
            }
            if(rdSTATus.Checked)
            {
                switch (caseSW)
                {
                    case 0://STATus:OPERation:EVENt?                 
                        lst2rdStr.Items.Add("?");//
                        break;
                    case 1://STATus:OPERation:CONDition?
                        lst2rdStr.Items.Add("?");//
                        break;
                    case 2://STATus:OPERation:ENABle //set and query
                        lblinfo.Text = "Enter Space + 0~ 32767" + "\r\n"
                                      + " or ? wo space";
                        break;
                    case 3://STATus:OPERation:PTRansition//set and query
                        lblinfo.Text = "Enter Space + 0~ 32767" + "\r\n"
                                     + " or ? wo space";
                        break;
                    case 4://STATus:OPERation:NTRansition//set and query
                        lblinfo.Text = "Enter Space + 0~ 32767" + "\r\n"
                                   + " or ? wo space";
                        break;
                    case 5://STATus:QUEStionable:EVENt? //query and also clear the register
                        lst2rdStr.Items.Add("?");//
                        break;
                    case 6://STATus:QUEStionable:CONDition?// Query and not clear
                        lst2rdStr.Items.Add("?");//
                        break;
                    case 7://STATus:QUEStionable:ENABle //set and query
                        lblinfo.Text = "Enter Space + 0~ 32767" + "\r\n"
                                 + " or ? wo space";
                        break; 
                    case 8://STATus: QUEStionable: PTRansition//set and query
                        lblinfo.Text = "Enter Space + 0~ 32767" + "\r\n"
                                 + " or ? wo space";
                        break;
                    case 9://STATus:QUEStionable:NTRansition
                        lblinfo.Text = "Enter Space + 0~ 32767" + "\r\n"
                               + " or ? wo space";
                        break;
                    case 10://STATus:PRESet //set only
                        //need nothing here
                        break;
                    default:
                        //
                        break;
                }
            }
            if(rdSOURce.Checked)
            {
                switch(caseSW)
                {
                    case 1://SOUR:CURR:LEV:IMM:AMPL //113.4 is max,  
                        lblinfo.Text = "Enter Space + 0~ 113.4";
                        break;
                    case 3://SOUR:CURR:LEV:TRIG:AMPL
                        lblinfo.Text = "Enter Space + 0~ 113.4";
                        break;
                    case 5://SOUR:CURR:PROT:LEV
                        lblinfo.Text = "Enter Space + 21~118";
                        break;
                    case 7://SOUR:CURR:SLEW:RIS
                        lblinfo.Text = "Enter Space + 0.01~216.0";
                        break;
                    case 9://SOUR:CURR:SLEW:FALL
                        lblinfo.Text = "Enter Space + 0.01~216.0";
                        break;
                    case 11://SOUR:RES:LEV:IMM:AMPL
                        lblinfo.Text = "Enter Space +0.000~0.278";
                        break;
                    case 13://SOUR:VOLT:LEV:IMM:AMPL
                        lblinfo.Text = "Enter Space + 0~31.5";
                        break;
                    case 15://SOUR:VOLT:LEV:TRIG:AMPL
                        lblinfo.Text = "Enter Space + 0~31.5";
                        break;
                    case 17://SOUR:VOLT:PROT:LEV, OVP
                        lblinfo.Text = "Enter Space + 3~33";
                        break;
                    case 19://SOUR:VOLT:SLEW:RIS
                        lblinfo.Text = "Enter Space + 0.01~60.00";
                        break;
                    case 21://SOUR:VOLT:SLEW:FALL
                        lblinfo.Text = "Enter Space +  0.01~60.00";
                        break;
                  
                    default:
                        break;
                }
              
            }
            if(rdTRIGger.Checked)
            {
                switch(caseSW)
                {
                    case 0:
                        //do nothing
                        break;
                    case 1://TRIGger:TRANsient:SOURce {BUS | IMMediate}
                        lst2rdStr.Items.Add(" BUS");//
                        lst2rdStr.Items.Add(" IMM");//
                        lst2rdStr.Items.Add("?");//
                        lst2rdStr.SelectedIndex = 2;
                        break;
                    case 2:
                        //do nothing
                        break;
                    case 3://TRIGger:OUTPut:SOURce [BUS | IMMediate]
                        lst2rdStr.Items.Add(" BUS");//
                        lst2rdStr.Items.Add(" IMM");//
                        lst2rdStr.Items.Add("?");//
                        lst2rdStr.SelectedIndex = 2;
                        break;
                    default:

                        break;
                }
                
            }
            if(rdSystemFunctionCmd.Checked)
            { 
                switch(caseSW)
                {
                    case 0://"SYST:BEEP
                        lblinfo.Text = "Enter Space + 1 ~ 3600" + "\r\n"
                                      + " or ? wo space";
                        txtinfo.AppendText("Make beeping sound");
                        break;
                    case 1://SYSTem:CONFigure:BEEPer:STATe
                        lst2rdStr.Items.Add(" ON");//
                        lst2rdStr.Items.Add(" OFF");//
                        lst2rdStr.Items.Add("?");//
                        break;
                    case 2:
                        txtinfo.AppendText("Trips the power switch trip (circuit breaker) " +
                            "to turn the unit off(shut down the power)." + "\r\n");
                        break;
                    case 3://SYSTem:CONFigure:BTRip:PROTection {OFF|ON|0|1}, not working???(you need recycle the power)
                        lst2rdStr.Items.Add(" ON");//
                        lst2rdStr.Items.Add(" OFF");//
                        lst2rdStr.Items.Add("?");//
                        txtinfo.AppendText("Enables/Disables the power switch trip (circuit beaker) when the OVP or OCP protection settings are tripped.This setting only applies after power has been reset."+"\r\n");
                       break;
                    case 4://SYSTem:CONFigure:BLEeder[:STATe] {OFF|ON|0|1}, default is ON
                        lst2rdStr.Items.Add(" ON");//
                        lst2rdStr.Items.Add(" OFF");//
                        lst2rdStr.Items.Add("?");//
                        txtinfo.AppendText("Sets or queries the status of the bleeder resistor."+"\r\n");
                        break;
                    case 5://SYSTem:CONFigure:CURRent:CONTrol { 0 | 1 | 2 | 3 },
                        lst2rdStr.Items.Add(" *0");//
                        lst2rdStr.Items.Add(" *1");//
                        lst2rdStr.Items.Add(" *2");//
                        lst2rdStr.Items.Add(" *3");//
                        lst2rdStr.Items.Add("?");//
                        txtinfo.AppendText("Sets or queries the CC control mode (local control (panel), external voltage control, external resistance control). This setting is applied only after the unit is reset." + "\r\n");
                        txtinfo.AppendText("Be careful these setting, you may need reset to MFG default with F-88 function.\r\n");
                        txtinfo.AppendText("Manually enter for this command.\r\n");
                        break;
                    case 6://SYSTem:CONFigure:VOLTage:CONTrol
                        lst2rdStr.Items.Add(" *0");//
                        lst2rdStr.Items.Add(" *1");//
                        lst2rdStr.Items.Add(" *2");//
                        lst2rdStr.Items.Add(" *3");//
                        lst2rdStr.Items.Add("?");//
                        txtinfo.AppendText("Sets or queries the CV control mode (local control,external voltage control, external resistance control). This setting is applied only after the unit is reset" + "\r\n");
                        txtinfo.AppendText("Be careful these setting, you may need reset to MFG default with F-88 function.\r\n");
                        txtinfo.AppendText("Manually enter for this command.\r\n");
                        break;
                    case 7:
                        txtinfo.AppendText("Manually enter for this command.\r\n");                   
                        break;
                    case 8://SYSTem:CONFigure:OUTPut:EXTernal
                        txtinfo.AppendText("Manually enter for this command.\r\n");                
                    
                        break;
                    case 9://SYSTem:COMMunicate:ENABle
                        lst2rdStr.Items.Add(" USB");//
                        lst2rdStr.Items.Add(" GPIB");//
                        lst2rdStr.Items.Add(" LAN");//
                        lst2rdStr.Items.Add(" SOCKets");//
                        lst2rdStr.Items.Add(" WEB");//
                        lst2rdStr.SelectedIndex = 0;

                        txtinfo.AppendText("Enables/Disables LAN, GPIB or USB remote interfaces as well as remote services(Sockets, WebServer)" + "\r\n");
                        txtinfo.AppendText("Manually enter for this command.\r\n");
                        break;
                    case 10://SYST:COMM:GPIB:SELF:ADDRess?
                        txtinfo.AppendText("Sets or queries the GPIB address. This setting is applied only after the unit is reset." + "\r\n");
                        txtinfo.AppendText("Manually enter for this command.\r\n");
                        break;
                    case 11://SYSTem:COMMunicate:LAN:IPADdress
                        txtinfo.AppendText("Sets or queries LAN IP address. This setting is applied only after the unit is reset" + "\r\n");
                        txtinfo.AppendText("Manually enter for this command.\r\n");
                        break;
                    case 12://SYSTem:COMMunicate:LAN:GATEway
                        txtinfo.AppendText("Sets or queries the Gateway address. This setting is applied only after the unit is reset." + "\r\n");
                        txtinfo.AppendText("Manually enter for this command.\r\n");
                        break;
                    case 13://SYSTem:COMMunicate:LAN:SMASk
                        txtinfo.AppendText("Sets or queries the LAN subnet mask. This setting is applied only after the unit is reset." + "\r\n");
                        txtinfo.AppendText("Manually enter for this command.\r\n");
                        break;
                    case 14://SYSTem:COMMunicate:LAN:MAC
                        txtinfo.AppendText("Returns the unit MAC address as a string. The MAC address cannot be changed." + "\r\n");

                        txtinfo.AppendText("Manually enter for this command.\r\n");
                        break;
                    case 15://SYSTem:COMMunicate:LAN:DHCP
                        txtinfo.AppendText("Turns DHCP on/off. Queries the DHCP status.This setting is applied only after the unit is reset." + "\r\n");

                        txtinfo.AppendText("Manually enter for this command.\r\n");
                        break;
                    case 16://SYSTem:COMMunicate:LAN:DNS
                        txtinfo.AppendText("Sets or queries the DNS address. This setting is applied only after the unit is reset." + "\r\n");
                        txtinfo.AppendText("Manually enter for this command.\r\n");
                        break;
                    case 17://SYSTem:COMMunicate:LAN:HOSTname
                        txtinfo.AppendText("Queries the host name." + "\r\n");
                        //txtinfo.AppendText("Manually enter for this command.\r\n");
                        break;
                    case 18://SYSTem:COMMunicate:LAN:WEB:PACTive
                        txtinfo.AppendText("Sets or queries whether the web password is on or off.This setting is applied only after the unit is reset." + "\r\n");
                        txtinfo.AppendText("Manually enter for this command.\r\n");
                        break;
                    case 19://SYSTem:COMMunicate:LAN:WEB:PASSword?
                        txtinfo.AppendText("Sets or queries the web password. This setting is applied only after the unit is reset." + "\r\n");

                        txtinfo.AppendText("Manually enter for this command.\r\n");
                        break;
                    case 20://SYSTem:COMMunicate:USB:FRONt:STATe
                        txtinfo.AppendText("Queries the front panel USB-A port state." + "\r\n");
                        //txtinfo.AppendText("Manually enter for this command.\r\n");
                        break;
                    case 21://SYSTem:COMMunicate:USB:REAR:STATe
                        txtinfo.AppendText("Queries the rear panel USB-B port state." + "\r\n");
                        //txtinfo.AppendText("Manually enter for this command.\r\n");
                        break;
                    case 22://SYSTem:COMMunicate:USB:REAR:MODE {0|1|2|3}
                        txtinfo.AppendText("Sets or queries the rear panel USB-B port mode." +
                            "This command is the equivalent to the F - 22 configuration setting." + "\r\n");                                               
                            //0 Disable
                            //1 GPIB - USB adapte
                            //2 Auto detect speed
                            //3 Full speed only
                        txtinfo.AppendText("Manually enter for this command.\r\n");
                        break;
                    case 23://SYSTem:ERRor
                        txtinfo.AppendText("Queries the error queue. The last error message is returned." +
                            "A maximum of 32 errors are stored in the error queue." + "\r\n");

                        break;
                    case 24://SYSTem:KEYLock:MODE
                        txtinfo.AppendText("Sets or queries the key lock mode. " +
                            "This setting is the equivalent of the F - 19 function setting." + "\r\n");

                        txtinfo.AppendText("Manually enter for this command.\r\n");
                        break;
                    case 25://SYSTem:KLOCk
                        txtinfo.AppendText("Enables or disables the front panel key lock." + "\r\n");
                        txtinfo.AppendText("Manually enter for this command.\r\n");
                        break;
                    case 26://SYSTem:INFormation
                        txtinfo.AppendText("Queries the system information. Returns the " + 
                                        "machine version, build date, keyboard CPLD version and analog CPLD version." + "\r\n");

                       // txtinfo.AppendText("Manually enter for this command.\r\n");
                        break;
                    case 27://SYSTem:PRESet
                        txtinfo.AppendText("Resets all the settings to the factory default " +
                            "settings.See page 114 for details." + "\r\n");

                        //  txtinfo.AppendText("Manually enter for this command.\r\n");
                        break;
                    case 28://SYSTem:VERSion
                        txtinfo.AppendText("Returns the version of the SCPI specifications that the unit complies with." + "\r\n");

                        // txtinfo.AppendText("Manually enter for this command.\r\n");
                        break;
                    case 29://SYSTem:CONFigure:OUTPut:PON[:STATe]? should put this next to the SYSTem:CONFigure:OUTPut:EXTernal
                        txtinfo.AppendText("Sets the unit to turn the output ON/OFF at powerup. " +
                            "This setting is only applied after the unit has been reset." + "\r\n");

                        txtinfo.AppendText("Manually enter for this command.\r\n");
                        break;
                  
                    default:
                        break;
                }
            }
            if(rdIEEEcommonCmd.Checked)
            {
                switch(caseSW)
                {
                    case 1://*ESE";//set 0~255/query , switch 1
                        lblinfo.Text = "Enter Space + 0~255";
                        break;                
                    case 7://"*SRE");//set 0~255/query, switch 7
                        lblinfo.Text = "Enter Space + 0~255";
                        break;
                    default:
                        break;
                }
            }
        }

        private void lst1stStr_Click(object sender, EventArgs e)
        {
            //lst2rdStr.Items.Clear();

            //if (rdOUTPut.Checked)
            //{
            //    int caseSW = lst2rdStr.SelectedIndex;
            //    switch (caseSW)
            //    {
            //        case 0://OUTPut:STATe:IMMediate
            //            lst2rdStr.Items.Add(" 1");//ON
            //            lst2rdStr.Items.Add(" 0");//OFF
            //            lst2rdStr.Items.Add("?");//Query
            //            break;
            //        case 1://OUTPut:DELay:ON

            //            break;
            //        case 2://OUTPut:DELay:OFF

            //            break;
            //        case 3://OUTPut:MODE

            //            break;
            //        case 4://OUTPut:STATe:TRIGgered

            //            break;
            //        case 5://OUTPut:PROTection:CLEar

            //            break;
            //        case 6://OUTPut:PROTection:TRIPped

            //            break;
            //        default:
            //            //
            //            break;
            //    }


            //}
        }

        private void tsBtnClearTxt_Click(object sender, EventArgs e)
        {
            txtinfo.Clear();
        }

        private void rdAbort_CheckedChanged(object sender, EventArgs e)
        {
            lst1stStr.Items.Clear();
            if (rdAbort.Checked)
            {
                lst1stStr.Items.Add("ABORt");
               

            }
        }

        private void rdAPPLy_CheckedChanged(object sender, EventArgs e)
        {
            lst1stStr.Items.Clear();
            if (rdAPPLy.Checked)
            {
                lst1stStr.Items.Add("APPLy");
            }
        }

        private void rdDISPlay_CheckedChanged(object sender, EventArgs e)
        {
            lst1stStr.Items.Clear();
            if (rdDISPlay.Checked)
            {
                lst1stStr.Items.Add("DISP:MENU:NAME");
                lst1stStr.Items.Add("DISPlay:WINDow:TEXT:DATA");
                lst1stStr.Items.Add("DISPlay:WINDow:TEXT:CLEar");
                lst1stStr.Items.Add("DISPlay:BLINk");
            }
        }

        private void rdMEASure_CheckedChanged(object sender, EventArgs e)
        {
            lst1stStr.Items.Clear();
            if (rdMEASure.Checked)
            {
                lst1stStr.Items.Add("MEASure:SCALar:CURRent:DC?");
                lst1stStr.Items.Add("MEASure:SCALar:VOLTage:DC?");
                lst1stStr.Items.Add("MEASure:SCALar:POWer:DC?");
               
            }
        }

        private void rdSENSe_CheckedChanged(object sender, EventArgs e)
        {
            lst1stStr.Items.Clear();
            if (rdSENSe.Checked)
            {
                lst1stStr.Items.Add("SENSe:AVERage:COUNt");
               // lst1stStr.Items.Add("SENSe:AVERage:COUNt?");
               
            }
        }

        private void rdSTATus_CheckedChanged(object sender, EventArgs e)
        {
            lst1stStr.Items.Clear();
            if (rdSTATus.Checked)
            {
                lst1stStr.Items.Add("STATus:OPERation:EVENt");
                lst1stStr.Items.Add("STATus:OPERation:CONDition");
                lst1stStr.Items.Add("STATus:OPERation:ENABle");
                lst1stStr.Items.Add("STATus:OPERation:PTRansition");
                lst1stStr.Items.Add("STATus:OPERation:NTRansition");
                lst1stStr.Items.Add("STATus:QUEStionable:EVENt");
                lst1stStr.Items.Add("STATus:QUEStionable:CONDition");
                lst1stStr.Items.Add("STATus:QUEStionable:ENABle");
                lst1stStr.Items.Add("STATus:QUEStionable:ENABle");
                lst1stStr.Items.Add("STATus:QUEStionable:NTRansition");
                lst1stStr.Items.Add("STATus:PRESet");
            }
        }

        private void rdSOURce_CheckedChanged(object sender, EventArgs e)
        {
            lst1stStr.Items.Clear();
            if (rdSOURce.Checked)
            {
                lst1stStr.Items.Add("SOUR:CURR:LEV:IMM:AMPL?");
                lst1stStr.Items.Add("SOUR:CURR:LEV:IMM:AMPL");

                lst1stStr.Items.Add("SOUR:CURR:LEV:TRIG:AMPL?");
                lst1stStr.Items.Add("SOUR:CURR:LEV:TRIG:AMPL");

                lst1stStr.Items.Add("SOUR:CURR:PROT:LEV?");
                lst1stStr.Items.Add("SOUR:CURR:PROT:LEV");

                lst1stStr.Items.Add("SOUR:CURR:SLEW:RIS?");
                lst1stStr.Items.Add("SOUR:CURR:SLEW:RIS");

                lst1stStr.Items.Add("SOUR:CURR:SLEW:FALL?");
                lst1stStr.Items.Add("SOUR:CURR:SLEW:FALL");

                lst1stStr.Items.Add("SOUR:RES:LEV:IMM:AMPL?");
                lst1stStr.Items.Add("SOUR:RES:LEV:IMM:AMPL");

                lst1stStr.Items.Add("SOUR:VOLT:LEV:IMM:AMPL?");
                lst1stStr.Items.Add("SOUR:VOLT:LEV:IMM:AMPL");

                lst1stStr.Items.Add("SOUR:VOLT:LEV:TRIG:AMPL?");
                lst1stStr.Items.Add("SOUR:VOLT:LEV:TRIG:AMPL");

                lst1stStr.Items.Add("SOUR:VOLT:PROT:LEV?");//OVP
                lst1stStr.Items.Add("SOUR:VOLT:PROT:LEV");

                lst1stStr.Items.Add("SOUR:VOLT:SLEW:RIS?");
                lst1stStr.Items.Add("SOUR:VOLT:SLEW:RIS");

                lst1stStr.Items.Add("SOUR:VOLT:SLEW:FALL?");
                lst1stStr.Items.Add("SOUR:VOLT:SLEW:FALL");
            }
        }

        private void rdTRIGger_CheckedChanged(object sender, EventArgs e)
        {
            lst1stStr.Items.Clear();
            if (rdTRIGger.Checked)
            {
                lst1stStr.Items.Add("TRIGger:TRANsient:IMMediate");//set only
                lst1stStr.Items.Add("TRIGger:TRANsient:SOURce");//set and query
                lst1stStr.Items.Add("TRIGger:OUTPut:IMMediate");//set only
                lst1stStr.Items.Add("TRIGger:OUTPut:SOURce");//set and query
           
              
            }
        }

        private void rdINITiate_CheckedChanged(object sender, EventArgs e)
        {
            lst1stStr.Items.Clear();
            if (rdINITiate.Checked)
            {
                lst1stStr.Items.Add("INITiate:NAME TRANient");//set only , Starts the TRANSient trigger, works with 
                                                              //software trigger group
                lst1stStr.Items.Add("INITiate:NAME OUTPut");
            }
        }

        private void rdIEEEcommonCmd_CheckedChanged(object sender, EventArgs e)
        {
            lst1stStr.Items.Clear();
            if (rdIEEEcommonCmd.Checked)
            {
                lst1stStr.Items.Add("*CLS");//set
                lst1stStr.Items.Add("*ESE");//set 0~255/query , switch 1
                lst1stStr.Items.Add("*ESR?");//query
                lst1stStr.Items.Add("*IDN?");//query
                lst1stStr.Items.Add("*OPC");//set/query ,
                lst1stStr.Items.Add("*OPC?");
                lst1stStr.Items.Add("*RST");//set all to default
                lst1stStr.Items.Add("*SRE");//set 0~255/query, switch 7
                lst1stStr.Items.Add("*SRE?");
                lst1stStr.Items.Add("*STB?");//query
                lst1stStr.Items.Add("*TRG");//set
                lst1stStr.Items.Add("*TST?");//query
                lst1stStr.Items.Add("*WAI");//set


            }
        }

        private void rdSystemFunctionCmd_CheckedChanged(object sender, EventArgs e)
        {
            lst1stStr.Items.Clear();
            if (rdSystemFunctionCmd.Checked)
            {
                lst1stStr.Items.Add("SYST:BEEP");//SYSTem:BEEPer[:IMMediate]
                lst1stStr.Items.Add("SYSTem:CONFigure:BEEPer:STATe");//SYSTem:CONFigure:BEEPer[:STATe] {OFF|ON|0|1}
                lst1stStr.Items.Add("SYSTem:CONFigure:BTRip:IMMediate");//SYSTem:CONFigure:BTRip[:IMMediate] sw2
                lst1stStr.Items.Add("SYSTem:CONFigure:BTRip:PROTection");//SYSTem:CONFigure:BTRip:PROTection {OFF|ON|0|1} sw3
                lst1stStr.Items.Add("SYSTem:CONFigure:BLEeder:STATe");//SYSTem:CONFigure:BLEeder[:STATe] {OFF|ON|0|1} sw4
                lst1stStr.Items.Add("SYSTem:CONFigure:CURRent:CONTrol");//SYSTem:CONFigure:CURRent:CONTrol  { 0 | 1 | 2 | 3 } sw5
                lst1stStr.Items.Add("SYSTem:CONFigure:VOLTage:CONTrol");//SYSTem:CONFigure:VOLTage:CONTrol { 0 | 1 | 2 | 3 } sw6
                lst1stStr.Items.Add("SYST:CONF:MSLave?");//SYSTem:CONFigure:MSLave { 0 | 1 | 2 | 3 | 4 } sw7
                lst1stStr.Items.Add("SYST:CONF:OUTPut:EXTernal?");//SYSTem:CONFigure:OUTPut:EXTernal sw8
                lst1stStr.Items.Add("SYST:COMM:ENABle?");//SYSTem:COMMunicate:ENABle <mode>,<interface> sw9
                lst1stStr.Items.Add("SYST:COMM:GPIB:SELF:ADDR?");//SYSTem:COMMunicate:GPIB[:SELF]:ADDRess sw10
                lst1stStr.Items.Add("SYST:COMM:LAN:IPADdress?");//SYSTem:COMMunicate:LAN:IPADdress sw11
                lst1stStr.Items.Add("SYST:COMM:LAN:GATEway?");//SYSTem:COMMunicate:LAN:GATEway sw12
                lst1stStr.Items.Add("SYST:COMM:LAN:SMASk?");//SYSTem:COMMunicate:LAN:SMASk sw13
                lst1stStr.Items.Add("SYST:COMM:LAN:MAC?");//SYSTem:COMMunicate:LAN:MAC sw14
                lst1stStr.Items.Add("SYST:COMM:LAN:DHCP?");//SYSTem:COMMunicate:LAN:DHCP {OFF | ON | 0 | 1} sw15
                lst1stStr.Items.Add("SYST:COMM:LAN:DNS?");//SYSTem:COMMunicate:LAN:DNS sw16
                lst1stStr.Items.Add("SYST:COMM:LAN:HOST?");//SYST:COMM:LAN:HOST sw17
                lst1stStr.Items.Add("SYST:COMM:LAN:WEB:PACTive?");//SYSTem:COMMunicate:LAN:WEB:PACTive sw18
                lst1stStr.Items.Add("SYST:COMM:LAN:WEB:PASSword?");//SYSTem:COMMunicate:LAN:WEB:PASSword sw19
                lst1stStr.Items.Add("SYST:COMM:USB:FRONt:STATe?");//SYSTem:COMMunicate:USB:FRONt:STATe sw20
                lst1stStr.Items.Add("SYST:COMM:USB:REAR:STATe?");//Queries the rear panel USB-B port state. sw21
                lst1stStr.Items.Add("SYST:COMM:USB:REAR:MODE?");//SYSTem:COMMunicate:USB:REAR:MODE? sw22
                lst1stStr.Items.Add("SYSTem:ERRor?");//SYSTem:ERRor sw23
                lst1stStr.Items.Add("SYSTem:KEYLock:MODE?");//SYSTem:KEYLock:MODE sw24
                lst1stStr.Items.Add("SYSTem:KLOCk?");//SYSTem:KLOCk { OFF | ON | 0 | 1} sw25
                lst1stStr.Items.Add("SYSTem:INFormation?");//SYSTem:INFormation sw26
                lst1stStr.Items.Add("SYSTem:PRESet");//SYSTem:PRESet sw27
                lst1stStr.Items.Add("SYSTem:VERSion?");//SYSTem:VERSion
                lst1stStr.Items.Add("SYSTem:CONFigure:OUTPut:PON:STATe?");//SYSTem:CONFigure:OUTPut:PON[:STATe] sw28 miss before
            }
        }

        private void lst1stStr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                string s = lst1stStr.SelectedItem.ToString();
                Clipboard.SetData(DataFormats.StringFormat, s);
            }
        }

        private void btnPowerOut_Click(object sender, EventArgs e)
        {
           
            if (!portOpened)
            {
                MessageBox.Show("Port not opened!");
                return;
            }
           
            OVP_voltage = Convert.ToDouble(txtOVP.Text);
            VoltageOut = Convert.ToDouble(txtVoltageLevel.Text);
            OCP_current = Convert.ToDouble(txtOCP.Text);
            CurrentOut = Convert.ToDouble(txtCurrentLevel.Text);
            PowerON_delay = Convert.ToDouble(txtPowerON_Delay.Text);
            PowerOFF_delay = Convert.ToDouble(txtPowerOFF_Delay.Text);

            txtinfo.AppendText("OVP: " + OVP_voltage.ToString() +
                ", VoltageOut: " + VoltageOut.ToString() + ", OCP_current: " + OCP_current.ToString()
                + ", CurrentOut: " + CurrentOut.ToString() + ", PowerON Delay: " + PowerON_delay.ToString()
                + ", PowerOFF delay: " + PowerOFF_delay.ToString() + "\r\n");

            if (PowerONF)
            {
                //turn off
                //set power off delay
                COMmsgToWrite.Add("OUTPut:DELay:OFF " + PowerOFF_delay.ToString() + "\r\n");//power off delay time
                COMmsgToWrite.Add("OUTPut:STATe:IMMediate 0\r\n");//power on
                btnPowerOut.Image = Properties.Resources.PowerOFF80;
                PowerONF = false;
                txtinfo.Clear();
                txtinfo.AppendText("Power Off!\r\n");
                tmrStatus.Stop();
                txtinfoBoxF = true;
            }
            else//Turn ON
            {
               //1. set OVP, OCP, both output voltage and current
                COMmsgToWrite.Add("*IDN?\r\n");//query product info
                COMmsgToWrite.Add("SOUR:VOLT:PROT:LEV "+ OVP_voltage.ToString()+"\r\n");//set OVP
                COMmsgToWrite.Add("APPly " + VoltageOut.ToString() +","+ CurrentOut.ToString()+"\r\n");//set Output Voltage, and Current
                COMmsgToWrite.Add("SOUR:CURR:PROT:LEV " + OCP_current.ToString()+"\r\n");//set OCP

                //2. set Power ON/OFF delay time
                COMmsgToWrite.Add("OUTPut:DELay:ON "+PowerON_delay.ToString() +"\r\n");//power on delay time
                //COMmsgToWrite.Add("OUTPut:DELay:OFF " + PowerOFF_delay.ToString() + "\r\n");//power off delay time

                COMmsgToWrite.Add("OUTPut:STATe:IMMediate 1\r\n");//power on
                btnPowerOut.Image = Properties.Resources.PowerON80;
                PowerONF = true;

                tmrStatus.Start();//reading PSU status
                Thread.Sleep(500);//tested 50ms will do the clear, but delay 500ms here
                mCaptureSB.Clear();

                txtinfoBoxF = false;//hiding incoming COM msg, let tmrStatus takeover

            }

          
        }

        private void txtOVP_TextChanged(object sender, EventArgs e)
        {
           
            OVP_voltage =Convert.ToDouble(txtOVP.Text);
            Properties.Settings.Default.OVP_voltagePreset = OVP_voltage;
            Properties.Settings.Default.Save();
        }

        private void txtVoltageLevel_TextChanged(object sender, EventArgs e)
        {
            VoltageOut = Convert.ToDouble(txtVoltageLevel.Text);
            Properties.Settings.Default.VoltageOutPreset = VoltageOut;
            Properties.Settings.Default.Save();
        }

        private void txtOCP_TextChanged(object sender, EventArgs e)
        {
            //min current > 5A for PSW 30-108
            OCP_current = Convert.ToDouble(txtOCP.Text);
            if(OCP_current<5)
            {
                MessageBox.Show("For PSW 30-108 Min OCP voltage is 5V!");
                OCP_current = 5;
            }
            Properties.Settings.Default.OCP_currentPreset = OCP_current;
            Properties.Settings.Default.Save();
        }

        private void txtCurrentLevel_TextChanged(object sender, EventArgs e)
        {
            CurrentOut = Convert.ToDouble(txtCurrentLevel.Text);
            Properties.Settings.Default.CurrentOutPreset = CurrentOut;
            Properties.Settings.Default.Save();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            PowerON_delay = Convert.ToDouble(txtPowerON_Delay.Text);
            Properties.Settings.Default.PowerONdelayPreset = PowerON_delay;
            Properties.Settings.Default.Save();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PowerOFF_delay = Convert.ToDouble(txtPowerOFF_Delay.Text);
            Properties.Settings.Default.PowerOFFdelayPreset = PowerOFF_delay;
            Properties.Settings.Default.Save();
        }


        private void txtOVP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(ch==46 && txtOVP.Text.IndexOf('.') !=-1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch !=8 && ch!=46)
            {
                e.Handled = true;               
            }
        }

        private void txtVoltageLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && txtVoltageLevel.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtOCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && txtOCP.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtCurrentLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && txtCurrentLevel.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtPowerON_Delay_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && txtPowerON_Delay.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtPowerOFF_Delay_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && txtPowerOFF_Delay.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        private Int16 ConditionStatusRegister;//0~32767, 0x7FFF see page 95

        private void process_protection(Int16 register)
        {
            pbox_OVP.Image = Properties.Resources.grayBall32;
            pbox_OCP.Image = Properties.Resources.grayBall32;
            pbox_OTP.Image = Properties.Resources.grayBall32;
            pbox_ShutdownTrip.Image = Properties.Resources.grayBall32;
            pbox_AC_Power_OFF.Image = Properties.Resources.grayBall32;


            if ((register >> 0 & 0x01) == 1)//OVP
            {
                pbox_OVP.Image = Properties.Resources.yellowBall32;
                Debug.WriteLine("OVP");
            }
            else if((register>>1 & 0x01)==1)//OCP
            {
                pbox_OCP.Image = Properties.Resources.yellowBall32;
                Debug.WriteLine("OCP");
            }
            else if ((register >> 3 & 0x01) == 1)//Power AC OFF
            {
                pbox_AC_Power_OFF.Image = Properties.Resources.yellowBall32;
                Debug.WriteLine("Power AC OFF");
            }
            else if ((register >> 4 & 0x01) == 1)//OTP
            {
                pbox_OTP.Image = Properties.Resources.yellowBall32;
                Debug.WriteLine("OTP");
            }
        }
        private void tmrStatus_Tick(object sender, EventArgs e)
        {
            COMmsgToWrite.Add("MEASure:SCALar:VOLTage:DC?\r\n");
            COMmsgToWrite.Add("MEASure:SCALar:CURRent:DC?\r\n");
            // COMmsgToWrite.Add("OUTPut:PROTection:TRIPped?\r\n");// this just any protection triggered, include OVP,OCP,OTP etc.
            COMmsgToWrite.Add("STATus:QUEStionable:CONDition?\r\n");//this is a questionable register included each protection status
                                                                    //see  page 96 for detail
        
          //  COMmsgToWrite.Add("*IDN?");



            Thread.Sleep(100);
            try
            {
                String[] spearator = { "|" };
                String[] StatusList = mCaptureSB.ToString().Split(spearator, 3, StringSplitOptions.RemoveEmptyEntries);

                txtReadVolOut.Text = StatusList[0];//for actual Voltage output               
                txtReadCurOut.Text = StatusList[1];//for actual Current output


                char[] charsToTrim = { '|', '\n' };
                ConditionStatusRegister = Convert.ToInt16(StatusList[2].Trim(charsToTrim));
                process_protection(ConditionStatusRegister);
                //if(StatusList[2].Trim(charsToTrim) == "1")//OVP tripped
                //{

                //    //pbox_OVP.Image = Properties.Resources.yellowBall32;
                //    //Debug.WriteLine("OVP detected!");
                //}
                //else
                //{
                //    pbox_OVP.Image = Properties.Resources.grayBall32;
                //}

                Debug.WriteLine(StatusList[2].Trim(charsToTrim));
                Debug.WriteLine(mCaptureSB.Length);
                mCaptureSB.Clear();
               
            }
            catch(Exception ex)
            {
                Console.WriteLine("Power may lost..." + ex.Message);
                tmrStatus.Stop();
            }
          
        }

        private void tsbtnTxtinfo_En_Dis_Click(object sender, EventArgs e)
        {
            if(txtinfoBoxF)//toggle show and hide txtinfo box text, true is use txtinfo
            {
                txtinfoBoxF = false;
                tsbtnTxtinfo_En_Dis.Image = Properties.Resources.informatics48off;
            }
            else
            {
                txtinfoBoxF = true;
                tsbtnTxtinfo_En_Dis.Image = Properties.Resources.informatics48on;
            }
        }

        private void btnClearProtection_Click(object sender, EventArgs e)
        {
            //
            COMmsgToWrite.Add("OUTPut:PROTection:CLEar\r\n");
        }

        private void cboBaudRate_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //for COM port
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string i in ports)
            {
                cbCOM.Items.Add(i);
            }
            if (cbCOM.Items.Count > 0)
            {
                //try to fixed the problem when PC com ports devcie change make saved index of the old COM port not available
                try
                {
                    SerialPortSelectIndex = Properties.Settings.Default.SerialPort_Sel_Idx;
                    cbCOM.SelectedIndex = SerialPortSelectIndex;
                }
                catch (Exception ex)
                {
                    //
                    MessageBox.Show("COM Ports changed!" + ex.Message);
                }
                //SerialPortSelectIndex = Properties.Settings.Default.SerialPort_Sel_Idx;
                //cbCOM.SelectedIndex = SerialPortSelectIndex;
            }

            cboBaudRate.SelectedIndex = 9;
            txtinfoBoxF = true; //use txtinfo box show incoming COM port message

            //for PSU GUI textbox preset
            OVP_voltage = Properties.Settings.Default.OVP_voltagePreset;
            txtOVP.Text = OVP_voltage.ToString("0.000");//force to display zero

            VoltageOut = Properties.Settings.Default.VoltageOutPreset;
            txtVoltageLevel.Text = VoltageOut.ToString("0.000");

            OCP_current = Properties.Settings.Default.OCP_currentPreset;
            txtOCP.Text = OCP_current.ToString("0.000");

            CurrentOut = Properties.Settings.Default.CurrentOutPreset;
            txtCurrentLevel.Text = CurrentOut.ToString("0.000");

            PowerON_delay = Properties.Settings.Default.PowerONdelayPreset;
            txtPowerON_Delay.Text = PowerON_delay.ToString("0.000");

            PowerOFF_delay = Properties.Settings.Default.PowerOFFdelayPreset;
            txtPowerOFF_Delay.Text = PowerOFF_delay.ToString("0.000");


        }
    }
}
