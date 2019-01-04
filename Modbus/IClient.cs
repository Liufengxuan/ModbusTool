using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modbus
{
 public  interface IClient 
    {
         //IClient GetClient();


        /// <summary>
        ///  RTU:串口是否打开  TCP：一直为true
        /// </summary>
        /// <returns></returns>
        bool IsOpen();
        /// <summary>
        /// RTU:打开串口   TCP：切换到长连接
        /// </summary>
        void Open();

        /// <summary>
        ///  RTU:关闭串口   TCP：切换到短连接
        /// </summary>
        void Close();


        string ContentTest(string sendContent);

        string ReadCoil(string address);

        byte Read(string address, ushort length);
       double ReadDouble(string address, ushort length);
      
        double ReadDouble(string address);
 
        float ReadFloat(string address, ushort length);
    
        float ReadFloat(string address);
   
        short ReadInt16(string address);
    
        short ReadInt16(string address, ushort length);
      
        int ReadInt32(string address);
      
        int ReadInt32(string address, ushort length);
      
        long ReadInt64(string address);
       
        long ReadInt64(string address, ushort length);
     
         string  ReadString(string address, ushort length);
     
         ushort  ReadUInt16(string address);
     
         ushort[]  ReadUInt16(string address, ushort length);
     
         uint[]  ReadUInt32(string address, ushort length);
     
         uint  ReadUInt32(string address);
       
         ulong  ReadUInt64(string address);
       
         ulong[]  ReadUInt64(string address, ushort length);
      
        void Write(string address, string value, int length);
      
        void Write(string address, string value);
      
        void Write(string address, double[] values);
       
        void Write(string address, double value);
       
        void Write(string address, float[] values);
      
        void Write(string address, float value);
     
        void Write(string address, long value);
       
        void Write(string address, int[] values);
       
        void Write(string address, int value);
       
        void Write(string address, short[] values);
     
        void Write(string address, short value);
       
        void Write(string address, long[] values);
    



    }
}
