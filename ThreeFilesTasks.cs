using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            var path = Environment.CurrentDirectory + "/ThreeFiles/first.txt";
            var text = File.ReadAllText(path);
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

            Console.WriteLine($"first file = {count} spaces. Time = {stopwatch.Elapsed}");
        }
        public static void ParseFile2()
        {
            Stopwatch stopwatch = new Stopwatch();

            var path = Environment.CurrentDirectory + "/ThreeFiles/second.txt";
            var text = File.ReadAllText(path);
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
            Console.WriteLine($"second file = {count} spaces. Time = {stopwatch.Elapsed}");

        }
        public static void ParseFile3()
        {
            Stopwatch stopwatch = new Stopwatch();

            var path = Environment.CurrentDirectory + "/ThreeFiles/third.txt";
            var text = File.ReadAllText(path);
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
            Console.WriteLine($"third file = {count} spaces. Time = {stopwatch.Elapsed}");
        }
    }
}
