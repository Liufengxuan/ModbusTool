using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modbus
{
   public static class MsgChannl
    {
        public delegate void DelReceiveMsg(string msg);
        public static event DelReceiveMsg MsgEvent;


        internal static void SendMsg(string msg)
        {
            MsgEvent?.Invoke(msg);
        }
       
    }
}
