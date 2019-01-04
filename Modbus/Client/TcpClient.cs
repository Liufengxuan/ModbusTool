using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HslCommunication.ModBus;

namespace Modbus.Client
{
   public class TcpClient : IClient
    {
        private static TcpClient tcpClient = null;

        #region 内部处理部分

       
        private static ModbusTcpNet _tcp = null;
        private static ModbusTcpNet TCP
        {
            get {
                if (_tcp != null)
                {
                    return _tcp;
                }
                else {
                    _tcp = new ModbusTcpNet(_address, _port, _station);
                    return _tcp;

                }
            }
        }
     
        private static string _address="192.168.168.201";
        private static int _port=28192;
        private static byte _station = 10;

  
        private TcpClient()
        {

        }
        private static void InitModbusTcp()
        {
            TCP.ConnectClose();
            TCP.IpAddress = _address;
            TCP.Port = _port;
            TCP.Station = _station;
            TCP.ConnectTimeOut = 500;
            TCP.ReceiveTimeOut = 500;
           // TCP.ConnectServer();
        }
        ~TcpClient()
        {
            _tcp = null;
        }


        #region 需要映射的字段。
        public static string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                InitModbusTcp();
            }
        }
        public static int Port
        {
            get { return _port; }
            set
            {
                _port = value;
                InitModbusTcp();

            }
        }
        public static byte Station
        {
            get { return _station; }
            set
            {
                _station = value;
                InitModbusTcp();
            }
        }
      
        #endregion
        #endregion


        public void Close()
        {
            TCP.ConnectClose();
        }

      
        public static IClient GetClient()
        {
            if (tcpClient != null)
            {
                return tcpClient;
            }
            else {
                tcpClient = new TcpClient();
                InitModbusTcp();
                return tcpClient;             
            }
        }

        public bool IsOpen()
        {
            return true;
        }

        public void Open()
        {
            TCP.ConnectServer();
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
            rst = TCP.ReadInt16(address);
            if (rst.IsSuccess)
            {
                return rst.Content;
            }
            MsgChannl.SendMsg(rst.Message);
            return 0;
        }

        public short ReadInt16(string address, ushort length)
        {
            HslCommunication.OperateResult<short> rst;
            rst = TCP.ReadInt16(address);
            if (rst.IsSuccess)
            {
                return rst.Content;
            }
            MsgChannl.SendMsg(rst.Message);
            return 0;
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
            byte[] data = HslCommunication.BasicFramework.SoftBasic.HexStringToBytes(sendContent);
            string rst = "";
            HslCommunication.OperateResult<byte[]> read = TCP.ReadFromCoreServer(data);
            if (read.IsSuccess)
            {
                // 获取结果，并转化为Hex字符串，方便显示
                rst = HslCommunication.BasicFramework.SoftBasic.ByteToHexString(read.Content, ' ');
            }
            else
            {
                MsgChannl.SendMsg(read.Message);
            }
            return rst;
        }

        public string ReadCoil(string address)
        {
            HslCommunication.OperateResult<bool> rst;
            rst = TCP.ReadCoil(address);
            if (rst.IsSuccess)
            {
                return rst.Content?"ON":"OFF";
            }
            MsgChannl.SendMsg(rst.Message);
            return "Exception";
        }
    }
}
