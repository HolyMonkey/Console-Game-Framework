using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameFramework
{
    public class MovementComponent : Component
    {
        private GameObject _gameObject;
        private ConsoleKeyInfo _key;
        public MovementComponent(GameObject go, ConsoleKeyInfo key)
        {
            _gameObject = go;
            _key = key;
        }

        public override void Start()
        {

        }

        public override void Update()
        {
            if (_key.Key == ConsoleKey.A)
                _gameObject.X--;
            else if (_key.Key == ConsoleKey.D)
                _gameObject.X++;
            else if (_key.Key == ConsoleKey.W)
                _gameObject.Y--;
            else if (_key.Key == ConsoleKey.S)
                _gameObject.Y++;
        }
    }
}
