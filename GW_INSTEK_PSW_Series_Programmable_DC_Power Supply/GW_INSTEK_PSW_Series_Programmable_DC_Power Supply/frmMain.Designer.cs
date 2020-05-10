namespace GW_INSTEK_PSW_Series_Programmable_DC_Power_Supply
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnSendMixedMsg = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbCOM = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cboBaudRate = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnOpenPort = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnClearTxt = new System.Windows.Forms.ToolStripButton();
            this.tsBtnExit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnTxtinfo_En_Dis = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtinfo = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnClearProtection = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pbox_AC_Power_OFF = new System.Windows.Forms.PictureBox();
            this.pbox_ShutdownTrip = new System.Windows.Forms.PictureBox();
            this.pbox_OTP = new System.Windows.Forms.PictureBox();
            this.pbox_OCP = new System.Windows.Forms.PictureBox();
            this.pbox_OVP = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtReadCurOut = new System.Windows.Forms.TextBox();
            this.txtReadVolOut = new System.Windows.Forms.TextBox();
            this.btnPowerOut = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPowerOFF_Delay = new System.Windows.Forms.TextBox();
            this.txtPowerON_Delay = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurrentLevel = new System.Windows.Forms.TextBox();
            this.txtOCP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVoltageLevel = new System.Windows.Forms.TextBox();
            this.txtOVP = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblinfo = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.lst2rdStr = new System.Windows.Forms.ListBox();
            this.lst1stStr = new System.Windows.Forms.ListBox();
            this.txtCmd = new System.Windows.Forms.TextBox();
            this.btnSendCMD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdUnSel = new System.Windows.Forms.RadioButton();
            this.rdIEEEcommonCmd = new System.Windows.Forms.RadioButton();
            this.rdSystemFunctionCmd = new System.Windows.Forms.RadioButton();
            this.rdTRIGger = new System.Windows.Forms.RadioButton();
            this.rdSOURce = new System.Windows.Forms.RadioButton();
            this.rdSTATus = new System.Windows.Forms.RadioButton();
            this.rdSENSe = new System.Windows.Forms.RadioButton();
            this.rdOUTPut = new System.Windows.Forms.RadioButton();
            this.rdMEASure = new System.Windows.Forms.RadioButton();
            this.rdINITiate = new System.Windows.Forms.RadioButton();
            this.rdDISPlay = new System.Windows.Forms.RadioButton();
            this.rdAPPLy = new System.Windows.Forms.RadioButton();
            this.rdAbort = new System.Windows.Forms.RadioButton();
            this.tmrStatus = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_AC_Power_OFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ShutdownTrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_OTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_OCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_OVP)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendMixedMsg
            // 
            this.btnSendMixedMsg.Location = new System.Drawing.Point(1085, 56);
            this.btnSendMixedMsg.Name = "btnSendMixedMsg";
            this.btnSendMixedMsg.Size = new System.Drawing.Size(121, 42);
            this.btnSendMixedMsg.TabIndex = 0;
            this.btnSendMixedMsg.Text = "Send CMD";
            this.btnSendMixedMsg.UseVisualStyleBackColor = true;
            this.btnSendMixedMsg.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cbCOM,
            this.toolStripSeparator1,
            this.cboBaudRate,
            this.toolStripSeparator3,
            this.tsbtnOpenPort,
            this.toolStripSeparator2,
            this.tsBtnClearTxt,
            this.tsBtnExit,
            this.tsbtnTxtinfo_En_Dis,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1258, 57);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(214, 52);
            this.toolStripLabel1.Text = "Select PSW COM Port -->";
            // 
            // cbCOM
            // 
            this.cbCOM.Name = "cbCOM";
            this.cbCOM.Size = new System.Drawing.Size(121, 57);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "76800",
            "115200",
            "230400",
            "250000",
            "500000",
            "1000000"});
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(121, 57);
            this.cboBaudRate.Click += new System.EventHandler(this.cboBaudRate_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 57);
            // 
            // tsbtnOpenPort
            // 
            this.tsbtnOpenPort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnOpenPort.Image = global::GW_INSTEK_PSW_Series_Programmable_DC_Power_Supply.Properties.Resources.disconnected_48;
            this.tsbtnOpenPort.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnOpenPort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOpenPort.Name = "tsbtnOpenPort";
            this.tsbtnOpenPort.Size = new System.Drawing.Size(52, 52);
            this.tsbtnOpenPort.Click += new System.EventHandler(this.tsbtnOpenPort_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // tsBtnClearTxt
            // 
            this.tsBtnClearTxt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnClearTxt.Image = global::GW_INSTEK_PSW_Series_Programmable_DC_Power_Supply.Properties.Resources.Clear48;
            this.tsBtnClearTxt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnClearTxt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnClearTxt.Name = "tsBtnClearTxt";
            this.tsBtnClearTxt.Size = new System.Drawing.Size(52, 52);
            this.tsBtnClearTxt.Click += new System.EventHandler(this.tsBtnClearTxt_Click);
            // 
            // tsBtnExit
            // 
            this.tsBtnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnExit.Image = global::GW_INSTEK_PSW_Series_Programmable_DC_Power_Supply.Properties.Resources.exit48;
            this.tsBtnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnExit.Name = "tsBtnExit";
            this.tsBtnExit.Size = new System.Drawing.Size(52, 52);
            this.tsBtnExit.Text = "Exit";
            this.tsBtnExit.Click += new System.EventHandler(this.tsBtnExit_Click);
            // 
            // tsbtnTxtinfo_En_Dis
            // 
            this.tsbtnTxtinfo_En_Dis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnTxtinfo_En_Dis.Image = global::GW_INSTEK_PSW_Series_Programmable_DC_Power_Supply.Properties.Resources.informatics48on;
            this.tsbtnTxtinfo_En_Dis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnTxtinfo_En_Dis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnTxtinfo_En_Dis.Name = "tsbtnTxtinfo_En_Dis";
            this.tsbtnTxtinfo_En_Dis.Size = new System.Drawing.Size(52, 52);
            this.tsbtnTxtinfo_En_Dis.Text = "Click to Disable/Enable txtinfo";
            this.tsbtnTxtinfo_En_Dis.Click += new System.EventHandler(this.tsbtnTxtinfo_En_Dis_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 57);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPort});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1006);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1258, 32);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblPort
            // 
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(90, 25);
            this.lblPort.Text = "COM Port";
            // 
            // txtinfo
            // 
            this.txtinfo.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtinfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtinfo.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinfo.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtinfo.Location = new System.Drawing.Point(0, 694);
            this.txtinfo.Multiline = true;
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtinfo.Size = new System.Drawing.Size(1258, 312);
            this.txtinfo.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1258, 637);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.btnPowerOut);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1250, 604);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PSW 30-180 GUI";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.groupBox6.Controls.Add(this.btnClearProtection);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.pbox_AC_Power_OFF);
            this.groupBox6.Controls.Add(this.pbox_ShutdownTrip);
            this.groupBox6.Controls.Add(this.pbox_OTP);
            this.groupBox6.Controls.Add(this.pbox_OCP);
            this.groupBox6.Controls.Add(this.pbox_OVP);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(546, 255);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(410, 331);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Protection Tripped";
            // 
            // btnClearProtection
            // 
            this.btnClearProtection.Location = new System.Drawing.Point(22, 258);
            this.btnClearProtection.Name = "btnClearProtection";
            this.btnClearProtection.Size = new System.Drawing.Size(280, 52);
            this.btnClearProtection.TabIndex = 17;
            this.btnClearProtection.Text = "Protection Clear";
            this.btnClearProtection.UseVisualStyleBackColor = true;
            this.btnClearProtection.Click += new System.EventHandler(this.btnClearProtection_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label22.Location = new System.Drawing.Point(75, 202);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(170, 29);
            this.label22.TabIndex = 16;
            this.label22.Text = "AC Power Off";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label20.Location = new System.Drawing.Point(75, 164);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(228, 29);
            this.label20.TabIndex = 15;
            this.label20.Text = "Shutdown Tripped";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label19.Location = new System.Drawing.Point(75, 88);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(168, 29);
            this.label19.TabIndex = 13;
            this.label19.Text = "OCP Tripped";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label21.Location = new System.Drawing.Point(75, 126);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(167, 29);
            this.label21.TabIndex = 14;
            this.label21.Text = "OTP Tripped";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label18.Location = new System.Drawing.Point(75, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(166, 29);
            this.label18.TabIndex = 12;
            this.label18.Text = "OVP Tripped";
            // 
            // pbox_AC_Power_OFF
            // 
            this.pbox_AC_Power_OFF.Image = global::GW_INSTEK_PSW_Series_Programmable_DC_Power_Supply.Properties.Resources.grayBall32;
            this.pbox_AC_Power_OFF.Location = new System.Drawing.Point(23, 200);
            this.pbox_AC_Power_OFF.Name = "pbox_AC_Power_OFF";
            this.pbox_AC_Power_OFF.Size = new System.Drawing.Size(32, 32);
            this.pbox_AC_Power_OFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox_AC_Power_OFF.TabIndex = 11;
            this.pbox_AC_Power_OFF.TabStop = false;
            // 
            // pbox_ShutdownTrip
            // 
            this.pbox_ShutdownTrip.Image = global::GW_INSTEK_PSW_Series_Programmable_DC_Power_Supply.Properties.Resources.grayBall32;
            this.pbox_ShutdownTrip.Location = new System.Drawing.Point(23, 162);
            this.pbox_ShutdownTrip.Name = "pbox_ShutdownTrip";
            this.pbox_ShutdownTrip.Size = new System.Drawing.Size(32, 32);
            this.pbox_ShutdownTrip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox_ShutdownTrip.TabIndex = 10;
            this.pbox_ShutdownTrip.TabStop = false;
            // 
            // pbox_OTP
            // 
            this.pbox_OTP.Image = global::GW_INSTEK_PSW_Series_Programmable_DC_Power_Supply.Properties.Resources.grayBall32;
            this.pbox_OTP.Location = new System.Drawing.Point(23, 124);
            this.pbox_OTP.Name = "pbox_OTP";
            this.pbox_OTP.Size = new System.Drawing.Size(32, 32);
            this.pbox_OTP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox_OTP.TabIndex = 9;
            this.pbox_OTP.TabStop = false;
            // 
            // pbox_OCP
            // 
            this.pbox_OCP.Image = global::GW_INSTEK_PSW_Series_Programmable_DC_Power_Supply.Properties.Resources.grayBall32;
            this.pbox_OCP.Location = new System.Drawing.Point(23, 86);
            this.pbox_OCP.Name = "pbox_OCP";
            this.pbox_OCP.Size = new System.Drawing.Size(32, 32);
            this.pbox_OCP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox_OCP.TabIndex = 8;
            this.pbox_OCP.TabStop = false;
            // 
            // pbox_OVP
            // 
            this.pbox_OVP.Image = global::GW_INSTEK_PSW_Series_Programmable_DC_Power_Supply.Properties.Resources.grayBall32;
            this.pbox_OVP.Location = new System.Drawing.Point(23, 48);
            this.pbox_OVP.Name = "pbox_OVP";
            this.pbox_OVP.Size = new System.Drawing.Size(32, 32);
            this.pbox_OVP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox_OVP.TabIndex = 0;
            this.pbox_OVP.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1013, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(166, 29);
            this.label17.TabIndex = 6;
            this.label17.Text = "Output Enable";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.txtReadCurOut);
            this.groupBox5.Controls.Add(this.txtReadVolOut);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(8, 255);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(532, 151);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Actual Output";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(470, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 32);
            this.label13.TabIndex = 5;
            this.label13.Text = "A";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(201, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 32);
            this.label14.TabIndex = 4;
            this.label14.Text = "V";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(291, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 29);
            this.label15.TabIndex = 3;
            this.label15.Text = "Current";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(22, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 29);
            this.label16.TabIndex = 1;
            this.label16.Text = "Voltage";
            // 
            // txtReadCurOut
            // 
            this.txtReadCurOut.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtReadCurOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadCurOut.ForeColor = System.Drawing.Color.Lime;
            this.txtReadCurOut.Location = new System.Drawing.Point(291, 76);
            this.txtReadCurOut.Name = "txtReadCurOut";
            this.txtReadCurOut.Size = new System.Drawing.Size(173, 48);
            this.txtReadCurOut.TabIndex = 2;
            this.txtReadCurOut.Text = "0.000";
            // 
            // txtReadVolOut
            // 
            this.txtReadVolOut.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtReadVolOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadVolOut.ForeColor = System.Drawing.Color.Lime;
            this.txtReadVolOut.Location = new System.Drawing.Point(22, 76);
            this.txtReadVolOut.Name = "txtReadVolOut";
            this.txtReadVolOut.Size = new System.Drawing.Size(173, 48);
            this.txtReadVolOut.TabIndex = 0;
            this.txtReadVolOut.Text = "0.000";
            // 
            // btnPowerOut
            // 
            this.btnPowerOut.AutoSize = true;
            this.btnPowerOut.BackColor = System.Drawing.Color.Transparent;
            this.btnPowerOut.Image = global::GW_INSTEK_PSW_Series_Programmable_DC_Power_Supply.Properties.Resources.PowerOFF80;
            this.btnPowerOut.Location = new System.Drawing.Point(1034, 56);
            this.btnPowerOut.Name = "btnPowerOut";
            this.btnPowerOut.Size = new System.Drawing.Size(129, 108);
            this.btnPowerOut.TabIndex = 4;
            this.btnPowerOut.UseVisualStyleBackColor = false;
            this.btnPowerOut.Click += new System.EventHandler(this.btnPowerOut_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(107)))));
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtPowerOFF_Delay);
            this.groupBox4.Controls.Add(this.txtPowerON_Delay);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(546, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(410, 243);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Power ON/OFF Delay (s)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(148, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 32);
            this.label11.TabIndex = 7;
            this.label11.Text = "Second";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(146, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 32);
            this.label12.TabIndex = 6;
            this.label12.Text = "Second";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Power OFF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Power ON";
            // 
            // txtPowerOFF_Delay
            // 
            this.txtPowerOFF_Delay.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtPowerOFF_Delay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPowerOFF_Delay.ForeColor = System.Drawing.Color.Lime;
            this.txtPowerOFF_Delay.Location = new System.Drawing.Point(22, 176);
            this.txtPowerOFF_Delay.Name = "txtPowerOFF_Delay";
            this.txtPowerOFF_Delay.Size = new System.Drawing.Size(120, 48);
            this.txtPowerOFF_Delay.TabIndex = 2;
            this.txtPowerOFF_Delay.Text = "0.00";
            this.txtPowerOFF_Delay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtPowerOFF_Delay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPowerOFF_Delay_KeyPress);
            // 
            // txtPowerON_Delay
            // 
            this.txtPowerON_Delay.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtPowerON_Delay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPowerON_Delay.ForeColor = System.Drawing.Color.Lime;
            this.txtPowerON_Delay.Location = new System.Drawing.Point(22, 76);
            this.txtPowerON_Delay.Name = "txtPowerON_Delay";
            this.txtPowerON_Delay.Size = new System.Drawing.Size(120, 48);
            this.txtPowerON_Delay.TabIndex = 0;
            this.txtPowerON_Delay.Text = "0.00";
            this.txtPowerON_Delay.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtPowerON_Delay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPowerON_Delay_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(153)))), ((int)(((byte)(125)))));
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtCurrentLevel);
            this.groupBox3.Controls.Add(this.txtOCP);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(277, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 243);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 32);
            this.label9.TabIndex = 7;
            this.label9.Text = "A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 32);
            this.label10.TabIndex = 6;
            this.label10.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Current Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "OCP";
            // 
            // txtCurrentLevel
            // 
            this.txtCurrentLevel.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtCurrentLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentLevel.ForeColor = System.Drawing.Color.Lime;
            this.txtCurrentLevel.Location = new System.Drawing.Point(22, 176);
            this.txtCurrentLevel.Name = "txtCurrentLevel";
            this.txtCurrentLevel.Size = new System.Drawing.Size(132, 48);
            this.txtCurrentLevel.TabIndex = 2;
            this.txtCurrentLevel.Text = "2.000";
            this.txtCurrentLevel.TextChanged += new System.EventHandler(this.txtCurrentLevel_TextChanged);
            this.txtCurrentLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrentLevel_KeyPress);
            // 
            // txtOCP
            // 
            this.txtOCP.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtOCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOCP.ForeColor = System.Drawing.Color.Lime;
            this.txtOCP.Location = new System.Drawing.Point(22, 76);
            this.txtOCP.Name = "txtOCP";
            this.txtOCP.Size = new System.Drawing.Size(132, 48);
            this.txtOCP.TabIndex = 0;
            this.txtOCP.Text = "10.000";
            this.txtOCP.TextChanged += new System.EventHandler(this.txtOCP_TextChanged);
            this.txtOCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOCP_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(204)))), ((int)(((byte)(65)))));
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtVoltageLevel);
            this.groupBox2.Controls.Add(this.txtOVP);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 243);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Voltage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 32);
            this.label8.TabIndex = 5;
            this.label8.Text = "V";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "V";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Voltage Level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "OVP";
            // 
            // txtVoltageLevel
            // 
            this.txtVoltageLevel.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtVoltageLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoltageLevel.ForeColor = System.Drawing.Color.Lime;
            this.txtVoltageLevel.Location = new System.Drawing.Point(22, 176);
            this.txtVoltageLevel.Name = "txtVoltageLevel";
            this.txtVoltageLevel.Size = new System.Drawing.Size(132, 48);
            this.txtVoltageLevel.TabIndex = 2;
            this.txtVoltageLevel.Text = "12.000";
            this.txtVoltageLevel.TextChanged += new System.EventHandler(this.txtVoltageLevel_TextChanged);
            this.txtVoltageLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVoltageLevel_KeyPress);
            // 
            // txtOVP
            // 
            this.txtOVP.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtOVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOVP.ForeColor = System.Drawing.Color.Lime;
            this.txtOVP.Location = new System.Drawing.Point(22, 76);
            this.txtOVP.Name = "txtOVP";
            this.txtOVP.Size = new System.Drawing.Size(132, 48);
            this.txtOVP.TabIndex = 0;
            this.txtOVP.Text = "25.000";
            this.txtOVP.TextChanged += new System.EventHandler(this.txtOVP_TextChanged);
            this.txtOVP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOVP_KeyPress);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblinfo);
            this.tabPage1.Controls.Add(this.txtMsg);
            this.tabPage1.Controls.Add(this.lst2rdStr);
            this.tabPage1.Controls.Add(this.lst1stStr);
            this.tabPage1.Controls.Add(this.txtCmd);
            this.tabPage1.Controls.Add(this.btnSendCMD);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnSendMixedMsg);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1250, 604);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Command List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.Location = new System.Drawing.Point(962, 19);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(35, 20);
            this.lblinfo.TabIndex = 7;
            this.lblinfo.Text = "info";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(966, 64);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(100, 26);
            this.txtMsg.TabIndex = 6;
            // 
            // lst2rdStr
            // 
            this.lst2rdStr.FormattingEnabled = true;
            this.lst2rdStr.ItemHeight = 20;
            this.lst2rdStr.Location = new System.Drawing.Point(782, 31);
            this.lst2rdStr.Name = "lst2rdStr";
            this.lst2rdStr.Size = new System.Drawing.Size(178, 304);
            this.lst2rdStr.TabIndex = 5;
            // 
            // lst1stStr
            // 
            this.lst1stStr.FormattingEnabled = true;
            this.lst1stStr.ItemHeight = 20;
            this.lst1stStr.Location = new System.Drawing.Point(347, 31);
            this.lst1stStr.Name = "lst1stStr";
            this.lst1stStr.Size = new System.Drawing.Size(429, 424);
            this.lst1stStr.TabIndex = 4;
            this.lst1stStr.Click += new System.EventHandler(this.lst1stStr_Click);
            this.lst1stStr.SelectedIndexChanged += new System.EventHandler(this.lst1stStr_SelectedIndexChanged);
            this.lst1stStr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lst1stStr_KeyDown);
            // 
            // txtCmd
            // 
            this.txtCmd.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmd.Location = new System.Drawing.Point(8, 488);
            this.txtCmd.Name = "txtCmd";
            this.txtCmd.Size = new System.Drawing.Size(362, 31);
            this.txtCmd.TabIndex = 3;
            // 
            // btnSendCMD
            // 
            this.btnSendCMD.Location = new System.Drawing.Point(391, 485);
            this.btnSendCMD.Name = "btnSendCMD";
            this.btnSendCMD.Size = new System.Drawing.Size(143, 36);
            this.btnSendCMD.TabIndex = 2;
            this.btnSendCMD.Text = "Send CMD";
            this.btnSendCMD.UseVisualStyleBackColor = true;
            this.btnSendCMD.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdUnSel);
            this.groupBox1.Controls.Add(this.rdIEEEcommonCmd);
            this.groupBox1.Controls.Add(this.rdSystemFunctionCmd);
            this.groupBox1.Controls.Add(this.rdTRIGger);
            this.groupBox1.Controls.Add(this.rdSOURce);
            this.groupBox1.Controls.Add(this.rdSTATus);
            this.groupBox1.Controls.Add(this.rdSENSe);
            this.groupBox1.Controls.Add(this.rdOUTPut);
            this.groupBox1.Controls.Add(this.rdMEASure);
            this.groupBox1.Controls.Add(this.rdINITiate);
            this.groupBox1.Controls.Add(this.rdDISPlay);
            this.groupBox1.Controls.Add(this.rdAPPLy);
            this.groupBox1.Controls.Add(this.rdAbort);
            this.groupBox1.Location = new System.Drawing.Point(8, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 437);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commands";
            // 
            // rdUnSel
            // 
            this.rdUnSel.AutoSize = true;
            this.rdUnSel.Checked = true;
            this.rdUnSel.Location = new System.Drawing.Point(23, 399);
            this.rdUnSel.Name = "rdUnSel";
            this.rdUnSel.Size = new System.Drawing.Size(76, 24);
            this.rdUnSel.TabIndex = 12;
            this.rdUnSel.TabStop = true;
            this.rdUnSel.Text = "None";
            this.rdUnSel.UseVisualStyleBackColor = true;
            // 
            // rdIEEEcommonCmd
            // 
            this.rdIEEEcommonCmd.AutoSize = true;
            this.rdIEEEcommonCmd.Location = new System.Drawing.Point(22, 361);
            this.rdIEEEcommonCmd.Name = "rdIEEEcommonCmd";
            this.rdIEEEcommonCmd.Size = new System.Drawing.Size(295, 24);
            this.rdIEEEcommonCmd.TabIndex = 11;
            this.rdIEEEcommonCmd.Text = "IEEE 488.2 Common Commands";
            this.rdIEEEcommonCmd.UseVisualStyleBackColor = true;
            this.rdIEEEcommonCmd.CheckedChanged += new System.EventHandler(this.rdIEEEcommonCmd_CheckedChanged);
            // 
            // rdSystemFunctionCmd
            // 
            this.rdSystemFunctionCmd.AutoSize = true;
            this.rdSystemFunctionCmd.Location = new System.Drawing.Point(22, 331);
            this.rdSystemFunctionCmd.Name = "rdSystemFunctionCmd";
            this.rdSystemFunctionCmd.Size = new System.Drawing.Size(253, 24);
            this.rdSystemFunctionCmd.TabIndex = 10;
            this.rdSystemFunctionCmd.Text = "System Function Command";
            this.rdSystemFunctionCmd.UseVisualStyleBackColor = true;
            this.rdSystemFunctionCmd.CheckedChanged += new System.EventHandler(this.rdSystemFunctionCmd_CheckedChanged);
            // 
            // rdTRIGger
            // 
            this.rdTRIGger.AutoSize = true;
            this.rdTRIGger.Location = new System.Drawing.Point(22, 301);
            this.rdTRIGger.Name = "rdTRIGger";
            this.rdTRIGger.Size = new System.Drawing.Size(103, 24);
            this.rdTRIGger.TabIndex = 9;
            this.rdTRIGger.Text = "TRIGger";
            this.rdTRIGger.UseVisualStyleBackColor = true;
            this.rdTRIGger.CheckedChanged += new System.EventHandler(this.rdTRIGger_CheckedChanged);
            // 
            // rdSOURce
            // 
            this.rdSOURce.AutoSize = true;
            this.rdSOURce.Location = new System.Drawing.Point(22, 271);
            this.rdSOURce.Name = "rdSOURce";
            this.rdSOURce.Size = new System.Drawing.Size(104, 24);
            this.rdSOURce.TabIndex = 8;
            this.rdSOURce.Text = "SOURce";
            this.rdSOURce.UseVisualStyleBackColor = true;
            this.rdSOURce.CheckedChanged += new System.EventHandler(this.rdSOURce_CheckedChanged);
            // 
            // rdSTATus
            // 
            this.rdSTATus.AutoSize = true;
            this.rdSTATus.Location = new System.Drawing.Point(22, 241);
            this.rdSTATus.Name = "rdSTATus";
            this.rdSTATus.Size = new System.Drawing.Size(97, 24);
            this.rdSTATus.TabIndex = 7;
            this.rdSTATus.Text = "STATus";
            this.rdSTATus.UseVisualStyleBackColor = true;
            this.rdSTATus.CheckedChanged += new System.EventHandler(this.rdSTATus_CheckedChanged);
            // 
            // rdSENSe
            // 
            this.rdSENSe.AutoSize = true;
            this.rdSENSe.Location = new System.Drawing.Point(22, 211);
            this.rdSENSe.Name = "rdSENSe";
            this.rdSENSe.Size = new System.Drawing.Size(92, 24);
            this.rdSENSe.TabIndex = 6;
            this.rdSENSe.Text = "SENSe";
            this.rdSENSe.UseVisualStyleBackColor = true;
            this.rdSENSe.CheckedChanged += new System.EventHandler(this.rdSENSe_CheckedChanged);
            // 
            // rdOUTPut
            // 
            this.rdOUTPut.AutoSize = true;
            this.rdOUTPut.Location = new System.Drawing.Point(22, 181);
            this.rdOUTPut.Name = "rdOUTPut";
            this.rdOUTPut.Size = new System.Drawing.Size(97, 24);
            this.rdOUTPut.TabIndex = 5;
            this.rdOUTPut.Text = "OUTPut";
            this.rdOUTPut.UseVisualStyleBackColor = true;
            this.rdOUTPut.CheckedChanged += new System.EventHandler(this.rdOUTPut_CheckedChanged);
            // 
            // rdMEASure
            // 
            this.rdMEASure.AutoSize = true;
            this.rdMEASure.Location = new System.Drawing.Point(22, 151);
            this.rdMEASure.Name = "rdMEASure";
            this.rdMEASure.Size = new System.Drawing.Size(110, 24);
            this.rdMEASure.TabIndex = 4;
            this.rdMEASure.Text = "MEASure";
            this.rdMEASure.UseVisualStyleBackColor = true;
            this.rdMEASure.CheckedChanged += new System.EventHandler(this.rdMEASure_CheckedChanged);
            // 
            // rdINITiate
            // 
            this.rdINITiate.AutoSize = true;
            this.rdINITiate.Location = new System.Drawing.Point(22, 121);
            this.rdINITiate.Name = "rdINITiate";
            this.rdINITiate.Size = new System.Drawing.Size(98, 24);
            this.rdINITiate.TabIndex = 3;
            this.rdINITiate.Text = "INITiate";
            this.rdINITiate.UseVisualStyleBackColor = true;
            this.rdINITiate.CheckedChanged += new System.EventHandler(this.rdINITiate_CheckedChanged);
            // 
            // rdDISPlay
            // 
            this.rdDISPlay.AutoSize = true;
            this.rdDISPlay.Location = new System.Drawing.Point(22, 91);
            this.rdDISPlay.Name = "rdDISPlay";
            this.rdDISPlay.Size = new System.Drawing.Size(98, 24);
            this.rdDISPlay.TabIndex = 2;
            this.rdDISPlay.Text = "DISPlay";
            this.rdDISPlay.UseVisualStyleBackColor = true;
            this.rdDISPlay.CheckedChanged += new System.EventHandler(this.rdDISPlay_CheckedChanged);
            // 
            // rdAPPLy
            // 
            this.rdAPPLy.AutoSize = true;
            this.rdAPPLy.Location = new System.Drawing.Point(22, 61);
            this.rdAPPLy.Name = "rdAPPLy";
            this.rdAPPLy.Size = new System.Drawing.Size(86, 24);
            this.rdAPPLy.TabIndex = 1;
            this.rdAPPLy.Text = "APPLy";
            this.rdAPPLy.UseVisualStyleBackColor = true;
            this.rdAPPLy.CheckedChanged += new System.EventHandler(this.rdAPPLy_CheckedChanged);
            // 
            // rdAbort
            // 
            this.rdAbort.AutoSize = true;
            this.rdAbort.Location = new System.Drawing.Point(22, 31);
            this.rdAbort.Name = "rdAbort";
            this.rdAbort.Size = new System.Drawing.Size(78, 24);
            this.rdAbort.TabIndex = 0;
            this.rdAbort.Text = "Abort";
            this.rdAbort.UseVisualStyleBackColor = true;
            this.rdAbort.CheckedChanged += new System.EventHandler(this.rdAbort_CheckedChanged);
            // 
            // tmrStatus
            // 
            this.tmrStatus.Tick += new System.EventHandler(this.tmrStatus_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 1038);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtinfo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PSW Programmable DC Power Supply";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_AC_Power_OFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ShutdownTrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_OTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_OCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_OVP)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendMixedMsg;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cbCOM;
        private System.Windows.Forms.ToolStripButton tsbtnOpenPort;
        private System.Windows.Forms.ToolStripButton tsBtnClearTxt;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblPort;
        private System.Windows.Forms.TextBox txtinfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdIEEEcommonCmd;
        private System.Windows.Forms.RadioButton rdSystemFunctionCmd;
        private System.Windows.Forms.RadioButton rdTRIGger;
        private System.Windows.Forms.RadioButton rdSOURce;
        private System.Windows.Forms.RadioButton rdSTATus;
        private System.Windows.Forms.RadioButton rdSENSe;
        private System.Windows.Forms.RadioButton rdOUTPut;
        private System.Windows.Forms.RadioButton rdMEASure;
        private System.Windows.Forms.RadioButton rdINITiate;
        private System.Windows.Forms.RadioButton rdDISPlay;
        private System.Windows.Forms.RadioButton rdAPPLy;
        private System.Windows.Forms.RadioButton rdAbort;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSendCMD;
        private System.Windows.Forms.TextBox txtCmd;
        private System.Windows.Forms.ToolStripButton tsBtnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ListBox lst1stStr;
        private System.Windows.Forms.RadioButton rdUnSel;
        private System.Windows.Forms.ListBox lst2rdStr;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.ToolStripComboBox cboBaudRate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPowerOFF_Delay;
        private System.Windows.Forms.TextBox txtPowerON_Delay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrentLevel;
        private System.Windows.Forms.TextBox txtOCP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVoltageLevel;
        private System.Windows.Forms.TextBox txtOVP;
        private System.Windows.Forms.Button btnPowerOut;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtReadCurOut;
        private System.Windows.Forms.TextBox txtReadVolOut;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Timer tmrStatus;
        private System.Windows.Forms.ToolStripButton tsbtnTxtinfo_En_Dis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pbox_OVP;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pbox_AC_Power_OFF;
        private System.Windows.Forms.PictureBox pbox_ShutdownTrip;
        private System.Windows.Forms.PictureBox pbox_OTP;
        private System.Windows.Forms.PictureBox pbox_OCP;
        private System.Windows.Forms.Button btnClearProtection;
    }
}

