using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameFramework
{

    public class GameObject
    {
        private char _sprite;
        public char Sprite
        {
            get
            {
                return _sprite;
            }

            set
            {
                _sprite = value;
            }
        }
        private ConsoleColor _color;
        public ConsoleColor Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }
        private int _x;
        private int _y;
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }

        /// <summary>
        /// Game Object
        /// </summary>
        /// <param name="spr">char symbol for rendering</param>
        /// <param name="x">X positon on the console</param>
        /// <param name="y">Y positon on the console</param>
        /// <param name="color">Sprite color</param>
        public GameObject(char spr, int x, int y, ConsoleColor color = ConsoleColor.Black)
        {
            Sprite = spr;
            Color = color;
            X = x;
            Y = y;
        }
    }
}
