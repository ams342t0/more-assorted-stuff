﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace quickOCR
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static System.Drawing.Bitmap pbitmap;
        public static int srows, scolumns;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
