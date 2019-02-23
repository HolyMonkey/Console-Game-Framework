using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameFramework
{

    public class GameObject
    {
        public char Sprite { get; private set; }
        public ConsoleColor Color { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }

        /// <summary>
        /// Game Object
        /// </summary>
        /// <param name="spr">char symbol for rendering</param>
        /// <param name="x">X positon on the console</param>
        /// <param name="y">Y positon on the console</param>
        /// <param name="color">Sprite color</param>
        public GameObject(char sprite, int x, int y, ConsoleColor color = ConsoleColor.White)
        {
            Sprite = sprite;
            Color = color;
            X = x;
            Y = y;
        }
    }
}
