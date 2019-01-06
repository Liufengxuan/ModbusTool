namespace MainForm
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gb_ModbusContent = new System.Windows.Forms.GroupBox();
            this.tb_ContentInput = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.tb_ContextDisplay = new System.Windows.Forms.TextBox();
            this.gb_Write = new System.Windows.Forms.GroupBox();
            this.tb_WriteInfo = new System.Windows.Forms.TextBox();
            this.gb_Read = new System.Windows.Forms.GroupBox();
            this.panel_ContinuousRead = new System.Windows.Forms.Panel();
            this.btn_ReadTimerStop = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_period = new System.Windows.Forms.TextBox();
            this.btn_ReadFloat = new System.Windows.Forms.Button();
            this.cb_ContinuousRead = new System.Windows.Forms.CheckBox();
            this.btn_ReadDouble = new System.Windows.Forms.Button();
            this.btn_ReadCoil = new System.Windows.Forms.Button();
            this.btn_ReadUInt32 = new System.Windows.Forms.Button();
            this.btn_ReadUInt16 = new System.Windows.Forms.Button();
            this.btn_ReadInt32 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ReadAddr = new System.Windows.Forms.TextBox();
            this.btn_ReadInt16 = new System.Windows.Forms.Button();
            this.tb_ReadInfo = new System.Windows.Forms.TextBox();
            this.tb_InfoDisplay = new System.Windows.Forms.TextBox();
            this.tabControl_Client = new System.Windows.Forms.TabControl();
            this.tabPage_RTU = new System.Windows.Forms.TabPage();
            this.Rbtn_SerialState = new System.Windows.Forms.Button();
            this.Rbtn_Save = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Rcb_Parity = new System.Windows.Forms.ComboBox();
            this.Rcb_StopBit = new System.Windows.Forms.ComboBox();
            this.Rtb_DataBit = new System.Windows.Forms.TextBox();
            this.Rtb_Address = new System.Windows.Forms.TextBox();
            this.Rcb_BaudRate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Rcb_Com = new System.Windows.Forms.ComboBox();
            this.tabPage_TCP = new System.Windows.Forms.TabPage();
            this.Tbtn_Save = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Ttb_Station = new System.Windows.Forms.TextBox();
            this.Ttb_IpAddress = new System.Windows.Forms.TextBox();
            this.Ttb_Port = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer_Read = new System.Windows.Forms.Timer(this.components);
            this.da = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gb_ModbusContent.SuspendLayout();
            this.gb_Write.SuspendLayout();
            this.gb_Read.SuspendLayout();
            this.panel_ContinuousRead.SuspendLayout();
            this.tabControl_Client.SuspendLayout();
            this.tabPage_RTU.SuspendLayout();
            this.tabPage_TCP.SuspendLayout();
            this.da.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tb_InfoDisplay);
            this.panel1.Controls.Add(this.tabControl_Client);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 566);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.gb_ModbusContent);
            this.panel3.Controls.Add(this.gb_Write);
            this.panel3.Controls.Add(this.gb_Read);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(819, 483);
            this.panel3.TabIndex = 7;
            // 
            // gb_ModbusContent
            // 
            this.gb_ModbusContent.Controls.Add(this.tb_ContentInput);
            this.gb_ModbusContent.Controls.Add(this.btn_Send);
            this.gb_ModbusContent.Controls.Add(this.tb_ContextDisplay);
            this.gb_ModbusContent.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gb_ModbusContent.Location = new System.Drawing.Point(7, 341);
            this.gb_ModbusContent.Margin = new System.Windows.Forms.Padding(2);
            this.gb_ModbusContent.Name = "gb_ModbusContent";
            this.gb_ModbusContent.Padding = new System.Windows.Forms.Padding(2);
            this.gb_ModbusContent.Size = new System.Drawing.Size(805, 134);
            this.gb_ModbusContent.TabIndex = 7;
            this.gb_ModbusContent.TabStop = false;
            this.gb_ModbusContent.Text = "报文";
            // 
            // tb_ContentInput
            // 
            this.tb_ContentInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_ContentInput.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_ContentInput.Location = new System.Drawing.Point(6, 21);
            this.tb_ContentInput.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ContentInput.Name = "tb_ContentInput";
            this.tb_ContentInput.Size = new System.Drawing.Size(373, 24);
            this.tb_ContentInput.TabIndex = 7;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(145, 70);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(233, 54);
            this.btn_Send.TabIndex = 6;
            this.btn_Send.Text = "发送";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // tb_ContextDisplay
            // 
            this.tb_ContextDisplay.BackColor = System.Drawing.Color.Black;
            this.tb_ContextDisplay.ForeColor = System.Drawing.Color.Aqua;
            this.tb_ContextDisplay.Location = new System.Drawing.Point(382, 16);
            this.tb_ContextDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ContextDisplay.Multiline = true;
            this.tb_ContextDisplay.Name = "tb_ContextDisplay";
            this.tb_ContextDisplay.ReadOnly = true;
            this.tb_ContextDisplay.Size = new System.Drawing.Size(420, 110);
            this.tb_ContextDisplay.TabIndex = 5;
            // 
            // gb_Write
            // 
            this.gb_Write.Controls.Add(this.tb_WriteInfo);
            this.gb_Write.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gb_Write.Location = new System.Drawing.Point(416, 9);
            this.gb_Write.Margin = new System.Windows.Forms.Padding(2);
            this.gb_Write.Name = "gb_Write";
            this.gb_Write.Padding = new System.Windows.Forms.Padding(2);
            this.gb_Write.Size = new System.Drawing.Size(395, 329);
            this.gb_Write.TabIndex = 6;
            this.gb_Write.TabStop = false;
            this.gb_Write.Text = "写入";
            // 
            // tb_WriteInfo
            // 
            this.tb_WriteInfo.BackColor = System.Drawing.Color.Black;
            this.tb_WriteInfo.ForeColor = System.Drawing.Color.Yellow;
            this.tb_WriteInfo.Location = new System.Drawing.Point(8, 147);
            this.tb_WriteInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tb_WriteInfo.Multiline = true;
            this.tb_WriteInfo.Name = "tb_WriteInfo";
            this.tb_WriteInfo.ReadOnly = true;
            this.tb_WriteInfo.Size = new System.Drawing.Size(384, 170);
            this.tb_WriteInfo.TabIndex = 5;
            // 
            // gb_Read
            // 
            this.gb_Read.Controls.Add(this.da);
            this.gb_Read.Controls.Add(this.btn_ReadFloat);
            this.gb_Read.Controls.Add(this.btn_ReadDouble);
            this.gb_Read.Controls.Add(this.btn_ReadCoil);
            this.gb_Read.Controls.Add(this.btn_ReadUInt32);
            this.gb_Read.Controls.Add(this.btn_ReadUInt16);
            this.gb_Read.Controls.Add(this.btn_ReadInt32);
            this.gb_Read.Controls.Add(this.label3);
            this.gb_Read.Controls.Add(this.tb_ReadAddr);
            this.gb_Read.Controls.Add(this.btn_ReadInt16);
            this.gb_Read.Controls.Add(this.tb_ReadInfo);
            this.gb_Read.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gb_Read.Location = new System.Drawing.Point(7, 9);
            this.gb_Read.Margin = new System.Windows.Forms.Padding(2);
            this.gb_Read.Name = "gb_Read";
            this.gb_Read.Padding = new System.Windows.Forms.Padding(2);
            this.gb_Read.Size = new System.Drawing.Size(395, 329);
            this.gb_Read.TabIndex = 5;
            this.gb_Read.TabStop = false;
            this.gb_Read.Text = "读取";
            // 
            // panel_ContinuousRead
            // 
            this.panel_ContinuousRead.BackColor = System.Drawing.Color.Transparent;
            this.panel_ContinuousRead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ContinuousRead.Controls.Add(this.btn_ReadTimerStop);
            this.panel_ContinuousRead.Controls.Add(this.label11);
            this.panel_ContinuousRead.Controls.Add(this.label12);
            this.panel_ContinuousRead.Controls.Add(this.tb_period);
            this.panel_ContinuousRead.Enabled = false;
            this.panel_ContinuousRead.Location = new System.Drawing.Point(8, 49);
            this.panel_ContinuousRead.Name = "panel_ContinuousRead";
            this.panel_ContinuousRead.Size = new System.Drawing.Size(142, 63);
            this.panel_ContinuousRead.TabIndex = 6;
            // 
            // btn_ReadTimerStop
            // 
            this.btn_ReadTimerStop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ReadTimerStop.Enabled = false;
            this.btn_ReadTimerStop.ForeColor = System.Drawing.Color.Red;
            this.btn_ReadTimerStop.Location = new System.Drawing.Point(12, 34);
            this.btn_ReadTimerStop.Name = "btn_ReadTimerStop";
            this.btn_ReadTimerStop.Size = new System.Drawing.Size(119, 26);
            this.btn_ReadTimerStop.TabIndex = 4;
            this.btn_ReadTimerStop.Text = "停止";
            this.btn_ReadTimerStop.UseVisualStyleBackColor = false;
            this.btn_ReadTimerStop.Click += new System.EventHandler(this.btn_ReadTimerStop_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "间隔";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(103, 7);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "毫秒";
            // 
            // tb_period
            // 
            this.tb_period.BackColor = System.Drawing.SystemColors.Info;
            this.tb_period.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_period.Location = new System.Drawing.Point(48, 6);
            this.tb_period.Margin = new System.Windows.Forms.Padding(2);
            this.tb_period.Name = "tb_period";
            this.tb_period.Size = new System.Drawing.Size(51, 17);
            this.tb_period.TabIndex = 1;
            this.tb_period.Text = "1000";
            // 
            // btn_ReadFloat
            // 
            this.btn_ReadFloat.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ReadFloat.Location = new System.Drawing.Point(118, 48);
            this.btn_ReadFloat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ReadFloat.Name = "btn_ReadFloat";
            this.btn_ReadFloat.Size = new System.Drawing.Size(51, 25);
            this.btn_ReadFloat.TabIndex = 17;
            this.btn_ReadFloat.Text = "Float";
            this.btn_ReadFloat.UseVisualStyleBackColor = true;
            this.btn_ReadFloat.Click += new System.EventHandler(this.ReadHandle);
            // 
            // cb_ContinuousRead
            // 
            this.cb_ContinuousRead.AutoSize = true;
            this.cb_ContinuousRead.BackColor = System.Drawing.Color.Transparent;
            this.cb_ContinuousRead.Location = new System.Drawing.Point(10, 26);
            this.cb_ContinuousRead.Margin = new System.Windows.Forms.Padding(2);
            this.cb_ContinuousRead.Name = "cb_ContinuousRead";
            this.cb_ContinuousRead.Size = new System.Drawing.Size(56, 19);
            this.cb_ContinuousRead.TabIndex = 3;
            this.cb_ContinuousRead.Text = "启用";
            this.cb_ContinuousRead.UseVisualStyleBackColor = false;
            this.cb_ContinuousRead.CheckedChanged += new System.EventHandler(this.cb_ContinuousRead_CheckedChanged);
            // 
            // btn_ReadDouble
            // 
            this.btn_ReadDouble.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ReadDouble.Location = new System.Drawing.Point(118, 77);
            this.btn_ReadDouble.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ReadDouble.Name = "btn_ReadDouble";
            this.btn_ReadDouble.Size = new System.Drawing.Size(51, 25);
            this.btn_ReadDouble.TabIndex = 16;
            this.btn_ReadDouble.Text = "Double";
            this.btn_ReadDouble.UseVisualStyleBackColor = true;
            this.btn_ReadDouble.Click += new System.EventHandler(this.ReadHandle);
            // 
            // btn_ReadCoil
            // 
            this.btn_ReadCoil.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ReadCoil.Location = new System.Drawing.Point(4, 105);
            this.btn_ReadCoil.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ReadCoil.Name = "btn_ReadCoil";
            this.btn_ReadCoil.Size = new System.Drawing.Size(55, 25);
            this.btn_ReadCoil.TabIndex = 14;
            this.btn_ReadCoil.Text = "Bool";
            this.btn_ReadCoil.UseVisualStyleBackColor = true;
            this.btn_ReadCoil.Click += new System.EventHandler(this.ReadHandle);
            // 
            // btn_ReadUInt32
            // 
            this.btn_ReadUInt32.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ReadUInt32.Location = new System.Drawing.Point(63, 77);
            this.btn_ReadUInt32.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ReadUInt32.Name = "btn_ReadUInt32";
            this.btn_ReadUInt32.Size = new System.Drawing.Size(51, 25);
            this.btn_ReadUInt32.TabIndex = 13;
            this.btn_ReadUInt32.Text = "UInt32";
            this.btn_ReadUInt32.UseVisualStyleBackColor = true;
            this.btn_ReadUInt32.Click += new System.EventHandler(this.ReadHandle);
            // 
            // btn_ReadUInt16
            // 
            this.btn_ReadUInt16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ReadUInt16.Location = new System.Drawing.Point(63, 48);
            this.btn_ReadUInt16.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ReadUInt16.Name = "btn_ReadUInt16";
            this.btn_ReadUInt16.Size = new System.Drawing.Size(51, 25);
            this.btn_ReadUInt16.TabIndex = 12;
            this.btn_ReadUInt16.Text = "UInt16";
            this.btn_ReadUInt16.UseVisualStyleBackColor = true;
            this.btn_ReadUInt16.Click += new System.EventHandler(this.ReadHandle);
            // 
            // btn_ReadInt32
            // 
            this.btn_ReadInt32.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ReadInt32.Location = new System.Drawing.Point(4, 76);
            this.btn_ReadInt32.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ReadInt32.Name = "btn_ReadInt32";
            this.btn_ReadInt32.Size = new System.Drawing.Size(55, 25);
            this.btn_ReadInt32.TabIndex = 11;
            this.btn_ReadInt32.Text = "Int32";
            this.btn_ReadInt32.UseVisualStyleBackColor = true;
            this.btn_ReadInt32.Click += new System.EventHandler(this.ReadHandle);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "地址";
            // 
            // tb_ReadAddr
            // 
            this.tb_ReadAddr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_ReadAddr.Location = new System.Drawing.Point(46, 22);
            this.tb_ReadAddr.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ReadAddr.Name = "tb_ReadAddr";
            this.tb_ReadAddr.Size = new System.Drawing.Size(144, 24);
            this.tb_ReadAddr.TabIndex = 8;
            // 
            // btn_ReadInt16
            // 
            this.btn_ReadInt16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ReadInt16.Location = new System.Drawing.Point(4, 48);
            this.btn_ReadInt16.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ReadInt16.Name = "btn_ReadInt16";
            this.btn_ReadInt16.Size = new System.Drawing.Size(55, 25);
            this.btn_ReadInt16.TabIndex = 7;
            this.btn_ReadInt16.Text = "Int16";
            this.btn_ReadInt16.UseVisualStyleBackColor = true;
            this.btn_ReadInt16.Click += new System.EventHandler(this.ReadHandle);
            // 
            // tb_ReadInfo
            // 
            this.tb_ReadInfo.BackColor = System.Drawing.Color.Black;
            this.tb_ReadInfo.ForeColor = System.Drawing.Color.Lime;
            this.tb_ReadInfo.Location = new System.Drawing.Point(4, 147);
            this.tb_ReadInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ReadInfo.Multiline = true;
            this.tb_ReadInfo.Name = "tb_ReadInfo";
            this.tb_ReadInfo.ReadOnly = true;
            this.tb_ReadInfo.Size = new System.Drawing.Size(386, 170);
            this.tb_ReadInfo.TabIndex = 5;
            // 
            // tb_InfoDisplay
            // 
            this.tb_InfoDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.tb_InfoDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_InfoDisplay.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_InfoDisplay.ForeColor = System.Drawing.Color.Red;
            this.tb_InfoDisplay.Location = new System.Drawing.Point(514, 3);
            this.tb_InfoDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.tb_InfoDisplay.Multiline = true;
            this.tb_InfoDisplay.Name = "tb_InfoDisplay";
            this.tb_InfoDisplay.ReadOnly = true;
            this.tb_InfoDisplay.Size = new System.Drawing.Size(301, 78);
            this.tb_InfoDisplay.TabIndex = 4;
            // 
            // tabControl_Client
            // 
            this.tabControl_Client.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_Client.Controls.Add(this.tabPage_RTU);
            this.tabControl_Client.Controls.Add(this.tabPage_TCP);
            this.tabControl_Client.HotTrack = true;
            this.tabControl_Client.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Client.Multiline = true;
            this.tabControl_Client.Name = "tabControl_Client";
            this.tabControl_Client.SelectedIndex = 0;
            this.tabControl_Client.Size = new System.Drawing.Size(482, 81);
            this.tabControl_Client.TabIndex = 3;
            this.tabControl_Client.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Client_Selecting);
            // 
            // tabPage_RTU
            // 
            this.tabPage_RTU.Controls.Add(this.Rbtn_SerialState);
            this.tabPage_RTU.Controls.Add(this.Rbtn_Save);
            this.tabPage_RTU.Controls.Add(this.Rcb_Parity);
            this.tabPage_RTU.Controls.Add(this.Rcb_StopBit);
            this.tabPage_RTU.Controls.Add(this.Rtb_DataBit);
            this.tabPage_RTU.Controls.Add(this.Rtb_Address);
            this.tabPage_RTU.Controls.Add(this.Rcb_BaudRate);
            this.tabPage_RTU.Controls.Add(this.label7);
            this.tabPage_RTU.Controls.Add(this.label6);
            this.tabPage_RTU.Controls.Add(this.label5);
            this.tabPage_RTU.Controls.Add(this.label4);
            this.tabPage_RTU.Controls.Add(this.label2);
            this.tabPage_RTU.Controls.Add(this.label1);
            this.tabPage_RTU.Controls.Add(this.Rcb_Com);
            this.tabPage_RTU.Location = new System.Drawing.Point(4, 22);
            this.tabPage_RTU.Name = "tabPage_RTU";
            this.tabPage_RTU.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_RTU.Size = new System.Drawing.Size(474, 55);
            this.tabPage_RTU.TabIndex = 0;
            this.tabPage_RTU.Text = "串口通讯";
            this.tabPage_RTU.UseVisualStyleBackColor = true;
            // 
            // Rbtn_SerialState
            // 
            this.Rbtn_SerialState.BackColor = System.Drawing.Color.Red;
            this.Rbtn_SerialState.Location = new System.Drawing.Point(386, 6);
            this.Rbtn_SerialState.Margin = new System.Windows.Forms.Padding(2);
            this.Rbtn_SerialState.Name = "Rbtn_SerialState";
            this.Rbtn_SerialState.Size = new System.Drawing.Size(32, 30);
            this.Rbtn_SerialState.TabIndex = 7;
            this.Rbtn_SerialState.Text = "关";
            this.Rbtn_SerialState.UseVisualStyleBackColor = false;
            this.Rbtn_SerialState.Click += new System.EventHandler(this.Rbtn_SerialState_Click);
            // 
            // Rbtn_Save
            // 
            this.Rbtn_Save.Depth = 0;
            this.Rbtn_Save.Location = new System.Drawing.Point(421, 6);
            this.Rbtn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.Rbtn_Save.MouseState = MaterialSkin.MouseState.HOVER;
            this.Rbtn_Save.Name = "Rbtn_Save";
            this.Rbtn_Save.Primary = true;
            this.Rbtn_Save.Size = new System.Drawing.Size(47, 46);
            this.Rbtn_Save.TabIndex = 7;
            this.Rbtn_Save.Text = "保  存";
            this.Rbtn_Save.UseVisualStyleBackColor = true;
            this.Rbtn_Save.Click += new System.EventHandler(this.Rbtn_Save_Click);
            // 
            // Rcb_Parity
            // 
            this.Rcb_Parity.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MainForm.Properties.Settings.Default, "Rcb_Parity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Rcb_Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Rcb_Parity.FormattingEnabled = true;
            this.Rcb_Parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.Rcb_Parity.Location = new System.Drawing.Point(206, 32);
            this.Rcb_Parity.Margin = new System.Windows.Forms.Padding(2);
            this.Rcb_Parity.Name = "Rcb_Parity";
            this.Rcb_Parity.Size = new System.Drawing.Size(66, 20);
            this.Rcb_Parity.TabIndex = 6;
            this.Rcb_Parity.Text = global::MainForm.Properties.Settings.Default.Rcb_Parity;
            // 
            // Rcb_StopBit
            // 
            this.Rcb_StopBit.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MainForm.Properties.Settings.Default, "Rcb_StopBit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Rcb_StopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Rcb_StopBit.FormattingEnabled = true;
            this.Rcb_StopBit.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.Rcb_StopBit.Location = new System.Drawing.Point(60, 32);
            this.Rcb_StopBit.Margin = new System.Windows.Forms.Padding(2);
            this.Rcb_StopBit.Name = "Rcb_StopBit";
            this.Rcb_StopBit.Size = new System.Drawing.Size(68, 20);
            this.Rcb_StopBit.TabIndex = 5;
            this.Rcb_StopBit.Text = global::MainForm.Properties.Settings.Default.Rcb_StopBit;
            // 
            // Rtb_DataBit
            // 
            this.Rtb_DataBit.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MainForm.Properties.Settings.Default, "Rtb_DataBit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Rtb_DataBit.Location = new System.Drawing.Point(334, 32);
            this.Rtb_DataBit.Margin = new System.Windows.Forms.Padding(2);
            this.Rtb_DataBit.Name = "Rtb_DataBit";
            this.Rtb_DataBit.Size = new System.Drawing.Size(49, 21);
            this.Rtb_DataBit.TabIndex = 4;
            this.Rtb_DataBit.Text = global::MainForm.Properties.Settings.Default.Rtb_DataBit;
            // 
            // Rtb_Address
            // 
            this.Rtb_Address.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MainForm.Properties.Settings.Default, "RTU_Address", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Rtb_Address.Location = new System.Drawing.Point(334, 6);
            this.Rtb_Address.Margin = new System.Windows.Forms.Padding(2);
            this.Rtb_Address.Name = "Rtb_Address";
            this.Rtb_Address.Size = new System.Drawing.Size(49, 21);
            this.Rtb_Address.TabIndex = 3;
            this.Rtb_Address.Text = global::MainForm.Properties.Settings.Default.RTU_Address;
            // 
            // Rcb_BaudRate
            // 
            this.Rcb_BaudRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MainForm.Properties.Settings.Default, "Rcb_BaudRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Rcb_BaudRate.FormattingEnabled = true;
            this.Rcb_BaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200"});
            this.Rcb_BaudRate.Location = new System.Drawing.Point(206, 6);
            this.Rcb_BaudRate.Margin = new System.Windows.Forms.Padding(2);
            this.Rcb_BaudRate.Name = "Rcb_BaudRate";
            this.Rcb_BaudRate.Size = new System.Drawing.Size(66, 20);
            this.Rcb_BaudRate.TabIndex = 2;
            this.Rcb_BaudRate.Text = global::MainForm.Properties.Settings.Default.Rcb_BaudRate;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "停止位:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "奇偶校验:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "波特率:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "数据位:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "地址:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "串口:";
            // 
            // Rcb_Com
            // 
            this.Rcb_Com.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MainForm.Properties.Settings.Default, "Rcd_Com", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Rcb_Com.FormattingEnabled = true;
            this.Rcb_Com.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.Rcb_Com.Location = new System.Drawing.Point(60, 6);
            this.Rcb_Com.Margin = new System.Windows.Forms.Padding(2);
            this.Rcb_Com.Name = "Rcb_Com";
            this.Rcb_Com.Size = new System.Drawing.Size(68, 20);
            this.Rcb_Com.TabIndex = 0;
            this.Rcb_Com.Text = global::MainForm.Properties.Settings.Default.Rcd_Com;
            // 
            // tabPage_TCP
            // 
            this.tabPage_TCP.Controls.Add(this.Tbtn_Save);
            this.tabPage_TCP.Controls.Add(this.Ttb_Station);
            this.tabPage_TCP.Controls.Add(this.Ttb_IpAddress);
            this.tabPage_TCP.Controls.Add(this.Ttb_Port);
            this.tabPage_TCP.Controls.Add(this.label10);
            this.tabPage_TCP.Controls.Add(this.label9);
            this.tabPage_TCP.Controls.Add(this.label8);
            this.tabPage_TCP.Location = new System.Drawing.Point(4, 22);
            this.tabPage_TCP.Name = "tabPage_TCP";
            this.tabPage_TCP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TCP.Size = new System.Drawing.Size(474, 55);
            this.tabPage_TCP.TabIndex = 1;
            this.tabPage_TCP.Text = "网口通讯";
            this.tabPage_TCP.UseVisualStyleBackColor = true;
            // 
            // Tbtn_Save
            // 
            this.Tbtn_Save.Depth = 0;
            this.Tbtn_Save.Location = new System.Drawing.Point(418, 4);
            this.Tbtn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.Tbtn_Save.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tbtn_Save.Name = "Tbtn_Save";
            this.Tbtn_Save.Primary = true;
            this.Tbtn_Save.Size = new System.Drawing.Size(47, 46);
            this.Tbtn_Save.TabIndex = 8;
            this.Tbtn_Save.Text = "保  存";
            this.Tbtn_Save.UseVisualStyleBackColor = true;
            this.Tbtn_Save.Click += new System.EventHandler(this.Tbtn_Save_Click);
            // 
            // Ttb_Station
            // 
            this.Ttb_Station.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MainForm.Properties.Settings.Default, "Ttb_Station", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Ttb_Station.Location = new System.Drawing.Point(288, 5);
            this.Ttb_Station.Name = "Ttb_Station";
            this.Ttb_Station.Size = new System.Drawing.Size(41, 21);
            this.Ttb_Station.TabIndex = 3;
            this.Ttb_Station.Text = global::MainForm.Properties.Settings.Default.Ttb_Station;
            // 
            // Ttb_IpAddress
            // 
            this.Ttb_IpAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MainForm.Properties.Settings.Default, "Ttb_IpAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Ttb_IpAddress.Location = new System.Drawing.Point(66, 4);
            this.Ttb_IpAddress.Name = "Ttb_IpAddress";
            this.Ttb_IpAddress.Size = new System.Drawing.Size(100, 21);
            this.Ttb_IpAddress.TabIndex = 2;
            this.Ttb_IpAddress.Text = global::MainForm.Properties.Settings.Default.Ttb_IpAddress;
            // 
            // Ttb_Port
            // 
            this.Ttb_Port.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MainForm.Properties.Settings.Default, "Ttb_Port", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Ttb_Port.Location = new System.Drawing.Point(66, 31);
            this.Ttb_Port.Name = "Ttb_Port";
            this.Ttb_Port.Size = new System.Drawing.Size(100, 21);
            this.Ttb_Port.TabIndex = 2;
            this.Ttb_Port.Text = global::MainForm.Properties.Settings.Default.Ttb_Port;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(241, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "地址:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "端口号:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "IP地址:";
            // 
            // da
            // 
            this.da.Controls.Add(this.panel_ContinuousRead);
            this.da.Controls.Add(this.cb_ContinuousRead);
            this.da.Location = new System.Drawing.Point(228, 19);
            this.da.Name = "da";
            this.da.Size = new System.Drawing.Size(159, 120);
            this.da.TabIndex = 6;
            this.da.TabStop = false;
            this.da.Text = "循环读取";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 622);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "         Modbus测试工具";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResizeEnd += new System.EventHandler(this.Main_ResizeEnd);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.gb_ModbusContent.ResumeLayout(false);
            this.gb_ModbusContent.PerformLayout();
            this.gb_Write.ResumeLayout(false);
            this.gb_Write.PerformLayout();
            this.gb_Read.ResumeLayout(false);
            this.gb_Read.PerformLayout();
            this.panel_ContinuousRead.ResumeLayout(false);
            this.panel_ContinuousRead.PerformLayout();
            this.tabControl_Client.ResumeLayout(false);
            this.tabPage_RTU.ResumeLayout(false);
            this.tabPage_RTU.PerformLayout();
            this.tabPage_TCP.ResumeLayout(false);
            this.tabPage_TCP.PerformLayout();
            this.da.ResumeLayout(false);
            this.da.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl_Client;
        private System.Windows.Forms.TabPage tabPage_RTU;
        private System.Windows.Forms.TabPage tabPage_TCP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Rcb_Com;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Rcb_BaudRate;
        private System.Windows.Forms.TextBox Rtb_Address;
        private System.Windows.Forms.TextBox Rtb_DataBit;
        private System.Windows.Forms.ComboBox Rcb_StopBit;
        private System.Windows.Forms.ComboBox Rcb_Parity;
        private MaterialSkin.Controls.MaterialRaisedButton Rbtn_Save;
        private System.Windows.Forms.TextBox tb_InfoDisplay;
        private System.Windows.Forms.GroupBox gb_Read;
        private System.Windows.Forms.GroupBox gb_Write;
        private System.Windows.Forms.TextBox tb_WriteInfo;
        private System.Windows.Forms.TextBox tb_ReadInfo;
        private System.Windows.Forms.Button btn_ReadInt16;
        private System.Windows.Forms.TextBox tb_ReadAddr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Rbtn_SerialState;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Ttb_Station;
        private System.Windows.Forms.TextBox Ttb_IpAddress;
        private System.Windows.Forms.TextBox Ttb_Port;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialRaisedButton Tbtn_Save;
        private System.Windows.Forms.GroupBox gb_ModbusContent;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox tb_ContextDisplay;
        private System.Windows.Forms.TextBox tb_ContentInput;
        private System.Windows.Forms.Button btn_ReadCoil;
        private System.Windows.Forms.Button btn_ReadUInt32;
        private System.Windows.Forms.Button btn_ReadUInt16;
        private System.Windows.Forms.Button btn_ReadInt32;
        private System.Windows.Forms.CheckBox cb_ContinuousRead;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_period;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer_Read;
        private System.Windows.Forms.Button btn_ReadFloat;
        private System.Windows.Forms.Button btn_ReadDouble;
        private System.Windows.Forms.Button btn_ReadTimerStop;
        private System.Windows.Forms.Panel panel_ContinuousRead;
        private System.Windows.Forms.GroupBox da;
    }
}