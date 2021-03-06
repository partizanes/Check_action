﻿using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Discount_check_action
{
    class Log
    {
        public static void log_write(string str, string reason, string logname)
        {
            string EntryTime = DateTime.Now.ToLongTimeString();
            string EntryDate = DateTime.Today.ToShortDateString();
            string fileName = "log/" + logname + ".log";  //log + data +logname ? 

            if (!Directory.Exists(Environment.CurrentDirectory + "/log/"))
            {
                Directory.CreateDirectory((Environment.CurrentDirectory + "/log/"));
            }

            try
            {
                StreamWriter sw = new StreamWriter(fileName, true, System.Text.Encoding.UTF8);
                sw.WriteLine("[" + EntryDate + "][" + EntryTime + "][" + reason + "]" + " " + str);
                sw.Close();
                //check this
                sw.Dispose();
            }
            catch (Exception ex)
            {
                log_write(ex.Message, "Exception", "Exception");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
