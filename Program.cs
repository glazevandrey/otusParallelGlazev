using System.Diagnostics;

namespace otusParallelGlazev
{
    internal class Program
    {
        public static List<Task> _tasks = new List<Task>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

           // ThreeFileTask();
            CustomPathTask();
        }
        static void ThreeFileTask()
        {
            Stopwatch sw = Stopwatch.StartNew();

            _tasks.Add(Task.Run(()=> ThreeFilesTasks.ParseFile1()));
            _tasks.Add(Task.Run(() => ThreeFilesTasks.ParseFile2()));
            _tasks.Add(Task.Run(() => ThreeFilesTasks.ParseFile3()));

            Task.WaitAll(_tasks.ToArray());

            sw.Stop();
            Console.WriteLine($"END THREE FILES SPACES. TIME = {sw.Elapsed}");
        }
        static void CustomPathTask()
        {
            Stopwatch sw = Stopwatch.StartNew();

            CustomPathTasks.Start("ThreeFiles");

            sw.Stop();
            Console.WriteLine($"END CUSOM PATH FILES SPACES. TIME = {sw.Elapsed}");
        }


    }
}