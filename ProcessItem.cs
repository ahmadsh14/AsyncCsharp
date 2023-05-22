using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async
{
    public class ProcessItem
    {
        public async Task<string> ProcessItemAsync(string item)
        {
            await Task.Delay(1000);
            string result = $"Processed items: {item}";
            return result;
        }
    }
}