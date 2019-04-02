using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameFramework
{
    public class Utility
    {
        /// <summary>
        /// this method reading whole number.
        /// </summary>
        public static int ReadInt()
        {
            int result;
            do
            {
                Console.WriteLine("Введите число");
            } while (!int.TryParse(Console.ReadLine(), out result));

            return result;
        }
    }

}