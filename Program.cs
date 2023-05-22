using System;
using System.IO;
using System.Threading.Tasks;

namespace Async
{

    class Program
    {
        static async Task Main(string[] args)
        {
            ProcessItem PI = new ProcessItem();
            List<string> items = new List<string> { "A 1", "B 2", "C 3" };
            List<Task<string>> ProcessingItem = new List<Task<string>>();
            
            foreach (string item in items)
            {
                Task<string> processingTask = PI.ProcessItemAsync(item);
                ProcessingItem.Add(processingTask);
            }

            await Task.WhenAll(ProcessingItem);

            foreach (Task<string> task in ProcessingItem)
            {
                Console.WriteLine(task.Result);
            }
        }

    }
}