using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;


namespace WindowsFormsApp1
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static jf.Compiler compiler = new jf.Compiler();
        static Queue<jf.Command> queue = new Queue<jf.Command>();
        static jf.SensorHandler sensorHandler = new jf.SensorHandler();
        [STAThread]
        static void Main()
        {

            sensorHandler.setSensor("T1", 80);
            sensorHandler.setSensor("T2", 130);
            sensorHandler.setSensor("T3", 80);
            sensorHandler.setSensor("n", 80);
            jf.Runner runner = new jf.Runner(Program.compiler, queue, sensorHandler);

            Thread backendThread = new Thread(new ThreadStart(runner.run));
            backendThread.Start();

            Thread UIThread = new Thread(new ThreadStart(Program.runUI));
            UIThread.SetApartmentState(ApartmentState.STA);
            UIThread.Start();
        }

        [STAThread]
        public static void runUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(Program.compiler, queue));
        }
    }
}
