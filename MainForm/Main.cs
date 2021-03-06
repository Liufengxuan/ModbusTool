﻿
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
using Modbus;
using Modbus.Client;
using System.Threading;

namespace MainForm
{
    public partial class Main : Form
    {
     

        public Main()
        {
            InitializeComponent();
          
        }
        #region 通知消息处理
        /// <summary>
        ///消息显示
        /// </summary>
        /// <param name="info"></param>
        private void ShowMsg(string info)
        {

            info = "[" + DateTime.Now.ToLongTimeString() + "]: " + info + "\r\n";



            if (tb_InfoDisplay.InvokeRequired)
            {
                // 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
                Action<string> actionDelegate = (x) => { tb_InfoDisplay.Text += x.ToString(); };
                // 或者
                // Action<string> actionDelegate = delegate(string txt) { this.label2.Text = txt; };
                tb_InfoDisplay.Invoke(actionDelegate, info);
            }
            else
            {
                tb_InfoDisplay.Text += info;
            }

            if (tb_InfoDisplay.InvokeRequired)
            {
                // 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
                Action<string> actionDelegate = (x) => { tb_InfoDisplay.SelectionStart += tb_InfoDisplay.Text.Length - 1; tb_InfoDisplay.ScrollToCaret(); };
                // 或者
                // Action<string> actionDelegate = delegate(string txt) { this.label2.Text = txt; };
                tb_InfoDisplay.Invoke(actionDelegate, info);
            }
            else
            {
                tb_InfoDisplay.SelectionStart = tb_InfoDisplay.Text.Length - 1;
                tb_InfoDisplay.ScrollToCaret();

            }

        }
        private void ShowMsg(string info, bool emptyMessages)
        {

            if (emptyMessages) tb_InfoDisplay.Text = "";

            info = "[" + DateTime.Now.ToLongTimeString() + "]: " + info + "\r\n";



            if (tb_InfoDisplay.InvokeRequired)
            {
                // 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
                Action<string> actionDelegate = (x) => { tb_InfoDisplay.Text += x.ToString(); };
                // 或者
                // Action<string> actionDelegate = delegate(string txt) { this.label2.Text = txt; };
                tb_InfoDisplay.Invoke(actionDelegate, info);
            }
            else
            {
                tb_InfoDisplay.Text += info;
            }
            if (tb_InfoDisplay.InvokeRequired)
            {
                // 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
                Action<string> actionDelegate = (x) => { tb_InfoDisplay.SelectionStart += tb_InfoDisplay.Text.Length - 1; tb_InfoDisplay.ScrollToCaret(); };
                // 或者
                // Action<string> actionDelegate = delegate(string txt) { this.label2.Text = txt; };
                tb_InfoDisplay.Invoke(actionDelegate, info);
            }
            else
            {
                tb_InfoDisplay.SelectionStart = tb_InfoDisplay.Text.Length - 1;
                tb_InfoDisplay.ScrollToCaret();
            }
        }

        private void ShowMsgToReadRegion(string info)
        {

            info = "[" + DateTime.Now.ToLongTimeString() + "]: " + info + "\r\n";
            if (tb_ReadInfo.InvokeRequired)
            {
                // 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
                Action<string> actionDelegate = (x) => { tb_ReadInfo.Text += x.ToString(); };
                // 或者
                // Action<string> actionDelegate = delegate(string txt) { this.label2.Text = txt; };
                tb_ReadInfo.Invoke(actionDelegate, info);
            }
            else
            {
                tb_ReadInfo.Text += info;
            }
            if (tb_ReadInfo.InvokeRequired)
            {
                // 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
                Action<string> actionDelegate = (x) => { tb_ReadInfo.SelectionStart += tb_ReadInfo.Text.Length - 1; tb_ReadInfo.ScrollToCaret(); };
                // 或者
                // Action<string> actionDelegate = delegate(string txt) { this.label2.Text = txt; };
                tb_ReadInfo.Invoke(actionDelegate, info);
            }
            else
            {
                tb_ReadInfo.SelectionStart = tb_ReadInfo.Text.Length - 1;
                tb_ReadInfo.ScrollToCaret();
            }
        }
        private void ShowMsgToWriteRegion(string info)
        {

            info = "[" + DateTime.Now.ToLongTimeString() + "]: " + info + "\r\n";



            if (tb_WriteInfo.InvokeRequired)
            {
                // 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
                Action<string> actionDelegate = (x) => { tb_WriteInfo.Text += x.ToString(); };
                // 或者
                // Action<string> actionDelegate = delegate(string txt) { this.label2.Text = txt; };
                tb_WriteInfo.Invoke(actionDelegate, info);
            }
            else
            {
                tb_WriteInfo.Text += info;
            }
            if (tb_WriteInfo.InvokeRequired)
            {
                // 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
                Action<string> actionDelegate = (x) => { tb_WriteInfo.SelectionStart += tb_WriteInfo.Text.Length - 1; tb_WriteInfo.ScrollToCaret(); };
                // 或者
                // Action<string> actionDelegate = delegate(string txt) { this.label2.Text = txt; };
                tb_WriteInfo.Invoke(actionDelegate, info);
            }
            else
            {
                tb_WriteInfo.SelectionStart = tb_WriteInfo.Text.Length - 1;
                tb_WriteInfo.ScrollToCaret();
            }
        }
        private void ShowMsgToContentRegion(string info)
        {

            info = "[" + DateTime.Now.ToLongTimeString() + "]: " + info + "\r\n";



            if (tb_ContextDisplay.InvokeRequired)
            {
                // 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
                Action<string> actionDelegate = (x) => { tb_ContextDisplay.Text += x.ToString(); };
                // 或者
                // Action<string> actionDelegate = delegate(string txt) { this.label2.Text = txt; };
                tb_ContextDisplay.Invoke(actionDelegate, info);
            }
            else
            {
                tb_ContextDisplay.Text += info;
            }
            if (tb_ContextDisplay.InvokeRequired)
            {
                // 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
                Action<string> actionDelegate = (x) => { tb_ContextDisplay.SelectionStart += tb_ContextDisplay.Text.Length - 1; tb_ContextDisplay.ScrollToCaret(); };
                // 或者
                // Action<string> actionDelegate = delegate(string txt) { this.label2.Text = txt; };
                tb_ContextDisplay.Invoke(actionDelegate, info);
            }
            else
            {
                tb_ContextDisplay.SelectionStart = tb_ContextDisplay.Text.Length - 1;
                tb_ContextDisplay.ScrollToCaret();
            }
         
        }

        #endregion

        #region 全局变量

        private Size mainFormSize { get; set; }//用来存储页面的原始大小
        private Modbus.IClient mbClient
        {
            get; set;
        } //用来存储当前使用的modbus通讯类。

        #endregion

        #region Main窗口上的事件
        private void Main_Load(object sender, EventArgs e)
        {
            mainFormSize = this.Size;
            SwitchCommunicationMode();
            MsgChannl.MsgEvent += ShowMsg;

            //注册过滤事件
            Rtb_Address.KeyPress += MainFormVerification.InputOnlyNumber;
     
            Rcb_BaudRate.KeyPress += MainFormVerification.InputOnlyNumber;
            Rtb_DataBit.KeyPress += MainFormVerification.InputOnlyNumber;


            tb_ContentInput.KeyPress += MainFormVerification.InputOnlyNumberAndLetter;
            tb_ContentInput.TextChanged += MainFormVerification.InputModbusContent;

            tb_ReadAddr.KeyPress += MainFormVerification.InputOnlyNumberAndLetter;
            tb_WriteAddr.KeyPress += MainFormVerification.InputOnlyNumberAndLetter;
            tb_WriteValue.KeyPress += MainFormVerification.InputOnlyNumber;
            //

        }
      
        #endregion

        #region tabControl_Client 控件的事件和  通讯配置相关、通讯切换事件
        /// <summary>
        /// 打开和关闭串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rbtn_SerialState_Click(object sender, EventArgs e)
        {
            try
            {
                if (mbClient.IsOpen())
                {
                    mbClient.Close();
                    Rbtn_SerialState.BackColor = Color.Red;
                    Rbtn_SerialState.Text = "关";
                    ShowMsg("串口已关闭\r\n");
                }
                else
                {
                    mbClient.Open();
                    Rbtn_SerialState.BackColor = Color.Green;
                    Rbtn_SerialState.Text = "开";
                    ShowMsg("串口已打开\r\n");
                }
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }

        }

        /// <summary>
        ///  串口的保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rbtn_Save_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.Save();
            ShowMsg("保存成功！");
            SetSerialParams();

        }

        /// <summary>
        /// 网口的保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tbtn_Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            ShowMsg("保存成功");
            SetTcpParams();
        }

        /// <summary>
        /// 当page页切换时来改变IClient的实列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl_Client_Selecting(object sender, TabControlCancelEventArgs e)
        {
            SwitchCommunicationMode();
        }



        private void SwitchCommunicationMode()//切换通讯方式事件；
        {
            if (tabControl_Client.SelectedIndex == 0)
            {
                mbClient = Modbus.Client.SerialClient.GetClient();
                ShowMsg("已切换为 *串口通讯\r\n", true);
                SetSerialParams();
            }
            else
            {
                mbClient = Modbus.Client.TcpClient.GetClient();
                ShowMsg("已切换为 *网口通讯\r\n", true);
                SetTcpParams();

            }
        }
        private void SetSerialParams()//将界面的参数设置到串口类
        {
            try
            {
                Parity parity = (Parity)Rcb_Parity.SelectedIndex;
                byte station = Convert.ToByte(Rtb_Address.Text);
                string com = Rcb_Com.Text;
                int baudRate = Convert.ToInt32(Rcb_BaudRate.Text);
                StopBits stopBits = (StopBits)Rcb_StopBit.SelectedIndex;
                int dataBit = Convert.ToInt32(Rtb_DataBit.Text);

                if (SerialClient.Parity != parity) SerialClient.Parity = parity;
                if (SerialClient.Station != station) SerialClient.Station = station;
                if (SerialClient.Com != com) SerialClient.Com = com;
                if (SerialClient.BaudRate != baudRate) SerialClient.BaudRate = baudRate;
                if (SerialClient.StopBits != stopBits) SerialClient.StopBits = stopBits;
                if (SerialClient.DataBit != dataBit) SerialClient.DataBit = dataBit;
            }
            catch (Exception ex) {
                ShowMsg(ex.Message);
            }
          

    }
        private void SetTcpParams()//将界面的参数设置到网口类
        {
            try
            {
                string address =Ttb_IpAddress.Text;
                int port =Convert.ToInt32( Ttb_Port.Text);
                byte station =Convert.ToByte(Ttb_Station.Text);

                if (TcpClient.Address != address) TcpClient.Address = address;
                if (TcpClient.Port != port) TcpClient.Port = port;
                if (TcpClient.Station != station) TcpClient.Station = station;
               
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
        #endregion



        #region 功能区域

        #region  功能区域-Read  
        private class ReadModel
        {
            public string BtnName { get; set; }
            public string Address { get; set; }
            public static bool IsRun { get; set; } = false;
            public static System.Threading.Timer threadTimer { get; set; } = null;
        }
        
        private void ReadHandle(object sender, EventArgs e)
        {
            ReadModel readModel = new ReadModel();
            try
            {
                readModel.Address = Convert.ToInt32(tb_ReadAddr.Text, 16).ToString();
            }
            catch
            {

                ShowMsg("请输入正确的16进制地址");
                return;
            }
            try
            {
                Button btn = (Button)sender;
                readModel.BtnName = btn.Name;




                if (cb_ContinuousRead.Checked)
                {
                    if (ReadModel.threadTimer == null)
                    {
                        ReadModel.threadTimer = new System.Threading.Timer(new System.Threading.TimerCallback(Read), readModel,0,Convert.ToInt32( tb_period.Text));
                        ReadModel.IsRun = true;
                        btn_ReadTimerStop.Enabled = true;
                        ShowMsg("已启用循环读取");
                    }
                  
                }
                else {
                    Read(readModel);
                }


            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
        private void Read(object obj)
        {
            ReadModel para = (ReadModel)obj;
            try
            {
                switch (para.BtnName)
                {
                    case "btn_ReadInt16":
                        ShowMsgToReadRegion(mbClient.ReadInt16(para.Address).ToString());
                        break;
                    case "btn_ReadInt32":
                        ShowMsgToReadRegion(mbClient.ReadInt32(para.Address).ToString());
                        break;
                    case "btn_ReadUInt16":
                        ShowMsgToReadRegion(mbClient.ReadUInt16(para.Address).ToString());
                        break;
                    case "btn_ReadUInt32":
                        ShowMsgToReadRegion(mbClient.ReadUInt32(para.Address).ToString());
                        break;
                    case "btn_ReadCoil":
                        ShowMsgToReadRegion(mbClient.ReadCoil(para.Address).ToString());
                        break;
                    case "btn_ReadFloat":
                        ShowMsgToReadRegion(mbClient.ReadFloat(para.Address).ToString());
                        break;
                    case "btn_ReadDouble":
                        ShowMsgToReadRegion(mbClient.ReadDouble(para.Address).ToString());
                        break;
                    default: return;
                }
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btn_ReadTimerStop_Click(object sender, EventArgs e)
        {
            if (ReadModel.threadTimer != null)
            {
                ReadModel.threadTimer.Change(-1, 2);
                ReadModel.threadTimer = null;
                btn_ReadTimerStop.Enabled = false ;
                ShowMsg("已终止循环读取");
            }
        }
        #endregion

        #region 功能区域-Write
        private class WriteModel
        {
            public  int diZeng { get; set; }
            public string btnName { get; set; }
            public string address { get; set; }
            public static int value { get; set; }
            public static bool IsRun { get; set; } = false;
            public static System.Threading.Timer threadTimer { get; set; } = null;
        }
        private void btn_WriteInt_Click(object sender, EventArgs e)
        {
            try
            {
                WriteModel writeModel = new WriteModel();
                writeModel.address = Convert.ToInt32(tb_WriteAddr.Text, 16).ToString();
                WriteModel.value = Convert.ToInt32(tb_WriteValue.Text);
                writeModel.btnName = ((Button)sender).Name;
                writeModel.diZeng = Convert.ToInt32(tb_WriteDiZeng.Text);

                if (!cb_ContinuousWrite.Checked)
                {
                    Write(writeModel);
                }
                else
                {
                    if (WriteModel.threadTimer == null)
                    {
                        WriteModel.threadTimer = new System.Threading.Timer(new System.Threading.TimerCallback(Write), writeModel, 0, Convert.ToInt32(tb_periodWrite.Text));
                        WriteModel.IsRun = true;
                        btn_WriteTimerStop.Enabled = true;
                        ShowMsg("已启用循环写入");
                    }

                }
            }
            catch {
                ShowMsg("请输入正确的值");
            }       
        }

        private void Write(object wtiteModel)
        {
            try
            {
                WriteModel writeModel = (WriteModel)wtiteModel;
                bool isSuccess = false;
                switch (writeModel.btnName)
                {
                    case "btn_WriteInt32":
                        isSuccess = mbClient.Write(writeModel.address, WriteModel.value);
                        break;
                    case "btn_WriteInt16":
                        isSuccess = mbClient.Write(writeModel.address, (short)WriteModel.value);
                        break;
                    case "btn_WriteUInt16":
                        isSuccess = mbClient.Write(writeModel.address,  (ushort)WriteModel.value);
                        break;
                    case "btn_WriteUInt32":
                        uint a = Convert.ToUInt32(WriteModel.value);
                        isSuccess = mbClient.Write(writeModel.address, a);
                        break;

                    //btn_WriteInt16
                    //btn_WriteUInt16
                    //btn_WriteUInt32
                    default: return;
                }
                if (isSuccess)
                {
                    ShowMsgToWriteRegion("将值" + WriteModel.value + "写入到地址:" + writeModel.address + " - 成功！");
                }
                else
                {
                    ShowMsgToWriteRegion("将值" + WriteModel.value + "写入到地址:" + writeModel.address + " - 失败！");
                }
                if (writeModel.diZeng != 0)
                {
                    WriteModel.value += writeModel.diZeng;
                }



            }
            catch(Exception ex) {
                ShowMsg("执行写入出错:"+ex.Message);
            }
        }
        private void btn_WriteTimerStop_Click(object sender, EventArgs e)
        {
            if (WriteModel.threadTimer != null)
            {
                WriteModel.threadTimer.Change(-1, 2);
                WriteModel.threadTimer = null;
                btn_WriteTimerStop.Enabled = false;
                ShowMsg("已终止循环读取");
            }
        }

        #endregion

        #region 功能区域-报文操作区域
        private class SendModel
        {
            public string content { get; set; }
            public static bool IsRun { get; set; } = false;
            public static System.Threading.Timer threadTimer { get; set; } = null;
        }



        private void btn_Send_Click(object sender, EventArgs e)
        {
            SendModel sendModel = new SendModel();
            sendModel.content = tb_ContentInput.Text;

            if (cb_ContinuousSend.Checked)
            {
                SendModel.threadTimer=new System.Threading.Timer(new System.Threading.TimerCallback(Send), sendModel, 0, Convert.ToInt32(tb_SendPeriod.Text));
                SendModel.IsRun = true;
                btn_SendTimerStop.Enabled = true;
                ShowMsg("已启用循环读取报文");
            }
            else {
                ShowMsgToContentRegion(mbClient.ContentTest(tb_ContentInput.Text));
            }
         
        }
        private void Send(object sendModel)
        {
            SendModel s = (SendModel)sendModel;
            ShowMsgToContentRegion(mbClient.ContentTest(s.content));
        }

        private void btn_SendTimerStop_Click(object sender, EventArgs e)
        {
            if (SendModel.threadTimer != null)
            {
                SendModel.threadTimer.Change(-1, 2);
                SendModel.threadTimer = null;
                btn_SendTimerStop.Enabled = false;
                ShowMsg("已终止循环读取报文");
            }
        }






        #endregion

        #endregion






















        private void cb_ContinuousRead_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ContinuousRead.Checked)
            {
                panel_ContinuousRead.Enabled = true;
            }
            else {
                panel_ContinuousRead.Enabled = false;
            }




            if (cb_ContinuousSend.Checked)
            {
                panel_ContinuousSend.Enabled = true;
            }
            else
            {
                panel_ContinuousSend.Enabled = false;
            }

            if (cb_ContinuousWrite.Checked)
            {
                panel_ContinuousWrite.Enabled = true;
            }
            else
            {
                panel_ContinuousWrite.Enabled = false;
            }


        }

     
    }
}
