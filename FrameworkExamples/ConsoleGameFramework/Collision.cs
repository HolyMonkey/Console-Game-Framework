using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameFramework
{
    public class Collision
    {
        public static bool Enter(GameObject a, GameObject b)
        {
            return a.X == b.X;
        }
    }
}
