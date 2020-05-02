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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnSendMixedMsg = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbCOM = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnOpenPort = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnClearTxt = new System.Windows.Forms.ToolStripButton();
            this.tsBtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtinfo = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.tsbtnOpenPort,
            this.toolStripSeparator2,
            this.tsBtnClearTxt,
            this.tsBtnExit,
            this.toolStripSeparator3});
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 57);
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1258, 637);
            this.tabControl1.TabIndex = 4;
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1250, 604);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
    }
}

