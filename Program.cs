using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;


namespace WindowsFormsApp1
{
    /// <summary>
    /// class <c>Program</c> is main class that control backend and UI part of program
    /// </summary>
    class Program
    {
        #region Global Variables
        static jf.Compiler compiler = new jf.Compiler();
        static Queue<jf.Command> queue = new Queue<jf.Command>();
        static jf.SensorHandler sensorHandler = new jf.SensorHandler();
        static List<string> fileNames = new List<string>();
        #endregion

        [STAThread]

        #region Start Threads
        static void Main()
        {

            Thread backendThread = new Thread(new ThreadStart(runBackeEnd));
            backendThread.Start();

            Thread UIThread = new Thread(new ThreadStart(Program.runUI));
            UIThread.SetApartmentState(ApartmentState.STA);
            UIThread.Start();
        }
        #endregion

        [STAThread]

        #region UI Part
        public static void runUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(Program.compiler, queue, fileNames));
        }
        #endregion

        #region Backend Part
        public static void runBackeEnd()
        {
            #region Test Sensors Value
            sensorHandler.setSensor("T1", 80);
            sensorHandler.setSensor("T2", 130);
            sensorHandler.setSensor("T3", 80);
            sensorHandler.setSensor("n", 80);
            #endregion

            while (true)
            {
                run_runner:
                    if(Program.fileNames.Count != 0)
                    {
                        compiler.compile(Program.fileNames[0], queue);
                        jf.Runner runner = new jf.Runner(Program.compiler, queue, sensorHandler);
                        int runCompletedWithoutError = runner.run();
                        if (runCompletedWithoutError == 0)
                        {
                            Program.fileNames.RemoveAt(0);
                            goto run_runner;
                        }
                        Program.fileNames.RemoveAt(0);
                        if (Program.fileNames.Count == 0)
                        {
                            goto run_runner;
                        }
                        jf.Command clearTextBox = new jf.Command("delete ritchbox");
                        Program.queue.Enqueue(clearTextBox);
                    }
            }
        }
        #endregion
    }
}
