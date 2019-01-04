using HslCommunication.ModBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using HslCommunication;

namespace Modbus.Client
{
    public class SerialClient : IClient
    {
        #region 内部实现部分   
        private static  ModbusRtu rtu { get; set; } = null;
        private static Parity _parity = Parity.None;
        private static byte _station = 10;
        private static string _com = "COM1";
        private static int _baudRate = 57600;
        private static StopBits _stopBits = StopBits.One;
        private static int _dataBit = 8;
        #region 需要映射到界面的字段  
        /// <summary>
        /// 地址
        /// </summary>
        public static byte Station
        {
            get
            {
                return _station;
            }
            set
            {
                _station = value;
                InitModbusRtu();
            }
        } 
        /// <summary>
        /// 串口地址
        /// </summary>
        public static string Com
        {
            get {
                return _com;
            }
            set {
                _com = value;
                InitModbusRtu();
            }
        }
        /// <summary>
        /// 波特率
        /// </summary>
        public static int BaudRate
        {
            get
            {
                return _baudRate;
            }
            set
            {
                _baudRate = value;
                InitModbusRtu();
            }
        }
        /// <summary>
        /// 数据位
        /// </summary>
        public static int DataBit
        {
            get
            {
                return _dataBit;
            }
            set
            {
                _dataBit = value;
                InitModbusRtu();
            }
        }
        /// <summary>
        /// 停止位
        /// </summary>
        public static StopBits StopBits
        {
            get
            {
                return _stopBits;
            }
            set
            {
                _stopBits = value;
                InitModbusRtu();
            }
        }
        /// <summary>
        /// 奇偶校验
        /// </summary>
        public static Parity Parity
        {
            get
            {
                return _parity;
            }
            set
            {
                _parity = value;
                InitModbusRtu();
            }
        }
        #endregion

        /// <summary>
        /// 初始化modbusrtu对象
        /// </summary>
        private static void InitModbusRtu()
        {
            if (rtu != null)
            {
                if (rtu.IsOpen())
                    rtu.Close();
            }
            else
            {
                rtu = new ModbusRtu();
            }
            try
            {
                rtu.Station = _station;
                rtu.SerialPortInni(sp =>
                {
                    sp.PortName = _com;
                    sp.BaudRate = _baudRate;
                    sp.DataBits = _dataBit;
                    sp.StopBits = _stopBits;
                    sp.Parity = _parity;
                    sp.ReadTimeout = 500;
                    sp.WriteTimeout = 500;
                });
                // rtu.Open(); // 打开
            }
            catch (Exception ex)
            {
                MsgChannl.SendMsg(ex.Message);
            }

        }

        private SerialClient()
        {

        }
        ~SerialClient()
        {
            if (rtu != null)
            {
                if (rtu.IsOpen())
                    rtu.Close();
            }
        }

        private static SerialClient _client = null;

        #endregion
        //接口实现部分——————————————————————————————————————————————————————————————————————————————————
        public static IClient GetClient()
        {
            if (_client != null)
            {
                return _client;
            }
            else {
                InitModbusRtu();
                _client = new SerialClient();
                return _client;
            }
        }


        public bool IsOpen()
        {
            return rtu.IsOpen();
        }
        public void Open()
        {
            if (!rtu.IsOpen())
            {
                rtu.Open();
            }
        }
        public void Close()
        {
            if (rtu.IsOpen())
            {
                rtu.Close();
            }
        }

        public byte Read(string address, ushort length)
        {
            throw new NotImplementedException();
        }

        public double ReadDouble(string address, ushort length)
        {
            throw new NotImplementedException();
        }

        public double ReadDouble(string address)
        {
            throw new NotImplementedException();
        }

        public float ReadFloat(string address, ushort length)
        {
            throw new NotImplementedException();
        }

        public float ReadFloat(string address)
        {
            throw new NotImplementedException();
        }

        public short ReadInt16(string address)
        {
            HslCommunication.OperateResult<short> rst;
            rst =rtu.ReadInt16(address);
            if (rst.IsSuccess) //判断是否成功
            {
                return rst.Content;
            }
            MsgChannl.SendMsg(rst.Message);//未成功就发送错误消息
            return 0;
        }

        public short ReadInt16(string address, ushort length)
        {
            throw new NotImplementedException();
        }

        public int ReadInt32(string address)
        {
            throw new NotImplementedException();
        }

        public int ReadInt32(string address, ushort length)
        {
            throw new NotImplementedException();
        }

        public long ReadInt64(string address)
        {
            throw new NotImplementedException();
        }

        public long ReadInt64(string address, ushort length)
        {
            throw new NotImplementedException();
        }

        public string ReadString(string address, ushort length)
        {
            throw new NotImplementedException();
        }

        public ushort ReadUInt16(string address)
        {
            throw new NotImplementedException();
        }

        public ushort[] ReadUInt16(string address, ushort length)
        {
            throw new NotImplementedException();
        }

        public uint[] ReadUInt32(string address, ushort length)
        {
            throw new NotImplementedException();
        }

        public uint ReadUInt32(string address)
        {
            throw new NotImplementedException();
        }

        public ulong ReadUInt64(string address)
        {
            throw new NotImplementedException();
        }

        public ulong[] ReadUInt64(string address, ushort length)
        {
            throw new NotImplementedException();
        }

        public void Write(string address, string value, int length)
        {
            throw new NotImplementedException();
        }

        public void Write(string address, string value)
        {
            throw new NotImplementedException();
        }

        public void Write(string address, double[] values)
        {
            throw new NotImplementedException();
        }

        public void Write(string address, double value)
        {
            throw new NotImplementedException();
        }

        public void Write(string address, float[] values)
        {
            throw new NotImplementedException();
        }

        public void Write(string address, float value)
        {
            throw new NotImplementedException();
        }

        public void Write(string address, long value)
        {
            throw new NotImplementedException();
        }

        public void Write(string address, int[] values)
        {
            throw new NotImplementedException();
        }

        public void Write(string address, int value)
        {
            throw new NotImplementedException();
        }

        public void Write(string address, short[] values)
        {
            throw new NotImplementedException();
        }

        public void Write(string address, short value)
        {
            throw new NotImplementedException();
        }

        public void Write(string address, long[] values)
        {
            throw new NotImplementedException();
        }

        public string ContentTest(string sendContent)
        {
            string rst = "";
            try
            {
                OperateResult<byte[]> read = rtu.ReadBase(HslCommunication.Serial.SoftCRC16.CRC16(HslCommunication.BasicFramework.SoftBasic.HexStringToBytes(sendContent)));
                if (read.IsSuccess)
                {
                    rst = HslCommunication.BasicFramework.SoftBasic.ByteToHexString(read.Content, ' ');
                }
                else
                {
                    MsgChannl.SendMsg("读取失败：" + read.Message);
                }
            }
            catch (Exception ex)
            {
                MsgChannl.SendMsg("读取失败：" + ex.Message);
            }
            return rst;
        }

        public string ReadCoil(string address)
        {
            HslCommunication.OperateResult<bool> rst;
            rst = rtu.ReadCoil(address);
            if (rst.IsSuccess)
            {
                return rst.Content ? "ON" : "OFF";
            }
            MsgChannl.SendMsg(rst.Message);
            return "Exception";
        }
    }
}
