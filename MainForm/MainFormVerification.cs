using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public static class MainFormVerification
    {
        //private static void LetterToUpper(object sender, EventArgs e)
        //{
        //    TextBox t=sender()
        //}
        /// <summary>
        /// 只能输入数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static  void InputOnlyNumber(object sender, KeyPressEventArgs e)
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



        /// <summary>
        /// 只能输入数字和英文字母什么的
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void InputOnlyNumberAndLetter(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9')|| (e.KeyChar == 8))
                {e.Handled = false; }
            else { e.Handled = true; }
          

        }


        /// <summary>
        /// textbox 每隔两个字符加一个空格。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void InputModbusContent(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            StringBuilder sb = new StringBuilder();
            int Selection = t.SelectionStart;
            int spaceNum = 0;
            char s = '_';


            string str = t.Text.Replace(s.ToString(), "");
            for (int i = 1; i <= str.Length; i++)
            {
                sb.Append(str[i-1]);
                if ((i != 0 && i % 2 == 0 ))
                {
                    if (i == str.Length) continue;
                    sb.Append(s);
                    Selection++;
                }
            }
           Selection= Selection - t.Text.Split(s).Length+1;
            t.Text = sb.ToString();
            t.SelectionStart = Selection < 0 ? 0:Selection ;

        }
    }
}
