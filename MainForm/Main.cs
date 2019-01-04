using MaterialSkin;
using MaterialSkin.Controls;
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

namespace MainForm
{
    public partial class Main : MaterialForm
    {
     

        public Main()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            FormBorderStyle = FormBorderStyle.None;//设置无边框的窗口样式
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
            tb_InfoDisplay.SelectionStart = tb_InfoDisplay.Text.Length - 1;
            tb_InfoDisplay.ScrollToCaret();
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
            tb_InfoDisplay.SelectionStart = tb_InfoDisplay.Text.Length - 1;
            tb_InfoDisplay.ScrollToCaret();
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
            tb_ReadInfo.SelectionStart = tb_ReadInfo.Text.Length - 1;
            tb_ReadInfo.ScrollToCaret();
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
            tb_WriteInfo.SelectionStart = tb_WriteInfo.Text.Length - 1;
            tb_WriteInfo.ScrollToCaret();
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
            tb_ContextDisplay.SelectionStart = tb_ContextDisplay.Text.Length - 1;
            tb_ContextDisplay.ScrollToCaret();
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

            //

        }
        private void Main_ResizeEnd(object sender, EventArgs e)
        {
            this.Size = mainFormSize;

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
        private void ReadHandle(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                Read(btn.Name);
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
        private void Read(string btnName)
        {
            string addr = "";
            try
            {
                addr = Convert.ToInt32(tb_ReadAddr.Text, 16).ToString();
            }
            catch {

                ShowMsg("请输入正确的16进制地址");
                return;
            }
            try
            {
                switch (btnName)
                {
                    case "btn_ReadInt16":
                        ShowMsgToReadRegion(mbClient.ReadInt16(addr).ToString());
                        break;
                    default: return;
                }
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }





        #endregion

        #region 报文操作区域
        private void btn_Send_Click(object sender, EventArgs e)
        {
            ShowMsgToContentRegion(mbClient.ContentTest(tb_ContentInput.Text));
        }

        #endregion

        private void Rtb_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键  
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数  
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符  
                }
            }

        }

        private void Rtb_Address_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
