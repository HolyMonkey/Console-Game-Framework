using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameFramework
{
    public class GameObject
    {
        private List<Component> _components = new List<Component>();
        public int SpriteID { get; private set; }
        public ConsoleColor Color { get; private set; }
        public int X { get; set; }
        public int Y { get; set; }        

        /// <summary>
        /// Game Object
        /// </summary>
        /// <param name="spr">char symbol for rendering</param>
        /// <param name="x">X positon on the console</param>
        /// <param name="y">Y positon on the console</param>
        /// <param name="color">Sprite color</param>
        public GameObject(int spriteID, int x, int y, ConsoleColor color = ConsoleColor.White)
        {
            SpriteID = spriteID;
            Color = color;
            X = x;
            Y = y;
        }

        public void AddComponent(Component component)
        {
            _components.Add(component);
        }

        public IEnumerable<Component> GetAllComponents()
        {
            return _components;
        }
    }
}
