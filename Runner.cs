using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace jf
{
    class Runner
    {
        public void run()
        {
            const string commandFilePath = "../../board/commands.txt";
            //string line;
            //string totalFile = "";
            int counter = 0;
            using (StreamWriter sw = new StreamWriter(commandFilePath))
            {
                while (true)
                {
                    sw.WriteLine(counter.ToString());
                    counter++;
                    //if (counter == 10) break;
                }
            }
            /*try
            {
                using (StreamReader sr = new StreamReader(commandFilePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        totalFile += line + "\n";
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return "Exception: " + e.Message;
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }*/
            //return totalFile;
        }
    }
}
