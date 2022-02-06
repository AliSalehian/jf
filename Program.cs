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
        static List<string> fileNames = new List<string>();
        [STAThread]
        static void Main()
        {

            Thread backendThread = new Thread(new ThreadStart(runBackeEnd));
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
            Application.Run(new Form1(Program.compiler, queue, fileNames));
        }

        public static void runBackeEnd()
        {
            sensorHandler.setSensor("T1", 80);
            sensorHandler.setSensor("T2", 130);
            sensorHandler.setSensor("T3", 80);
            sensorHandler.setSensor("n", 80);
            while (true)
            {
                if(Program.fileNames.Count != 0)
                {
                    compiler.compile(Program.fileNames[0], queue);
                    jf.Runner runner = new jf.Runner(Program.compiler, queue, sensorHandler);
                    int status = runner.run();
                    Console.WriteLine(status);
                    Program.fileNames.RemoveAt(0);
                    jf.Command clearTextBox = new jf.Command("delete ritchbox");
                    Program.queue.Enqueue(clearTextBox);
                }
            }
        }

    }
}
