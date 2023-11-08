using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otusParallelGlazev
{
    public class ThreeFilesTasks
    {
        public static void ParseFile1()
        {
            Stopwatch stopwatch = new Stopwatch();

            List<string> paths = new List<string>(){
                 Environment.CurrentDirectory + "/ThreeFiles/first.txt",
                 Environment.CurrentDirectory + "/ThreeFiles/second.txt",
                 Environment.CurrentDirectory + "/ThreeFiles/third.txt",
                };

            for (int i = 0; i < paths.Count; i++)
            {
                var text = File.ReadAllText(paths[i]);
                int count = 0;

                stopwatch.Start();

                foreach (var item in text)
                {
                    if (item == ' ')
                    {
                        count++;
                    }
                }

                stopwatch.Stop();

                Console.WriteLine($"{paths[i]} file = {count} spaces. Time = {stopwatch.Elapsed}");
            }
        }
    }
}
