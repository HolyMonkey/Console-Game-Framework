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
        private Input _input;
        public MovementComponent(GameObject go, Input input)
        {
            _gameObject = go;
            _input = input;
        }

        public override void Start()
        {
        }

        public override void Update()
        {
            if (_input.currentKey.Key == ConsoleKey.A)
                _gameObject.X--;
            else if (_input.currentKey.Key == ConsoleKey.D)
                _gameObject.X++;
            else if (_input.currentKey.Key == ConsoleKey.W)
                _gameObject.Y--;
            else if (_input.currentKey.Key == ConsoleKey.S)
                _gameObject.Y++;
        }
    }
}
