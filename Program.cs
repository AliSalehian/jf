﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            jf.Runner runner = new jf.Runner();

            Thread backendThread = new Thread(new ThreadStart(runner.run));
            backendThread.Start();

            Thread UIThread = new Thread(new ThreadStart(Program.runUI));
            UIThread.Start();


        }

        public static void runUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
