using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGameFramework
{
    public class Input
    {
        public ConsoleKeyInfo currentKey = new ConsoleKeyInfo();
        public void StartInput()
        {
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    currentKey = Console.ReadKey(false);
                }
            });
        }
    }
}
