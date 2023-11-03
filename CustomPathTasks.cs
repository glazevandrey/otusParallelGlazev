using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace otusParallelGlazev
{
    public class CustomPathTasks
    {
        public static void Start(string path)
        {
            List<Task> tasks = new List<Task>();
            var files = Directory.GetFiles(path);

            for (int i = 0; i < files.Length; i++)
            {
                var text = File.ReadAllText(files[i]);
                var name = files[i];
                tasks.Add(Task.Run(() => { ParseFile(name, text); }));
            }

            Task.WaitAll(tasks.ToArray());
        }
        private static void ParseFile(string name, string text)
        {
            Stopwatch stopwatch = new Stopwatch();

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
            Console.WriteLine($"file {name}. spaces = {count}. Time = {stopwatch.Elapsed}");
        }
    }
}
