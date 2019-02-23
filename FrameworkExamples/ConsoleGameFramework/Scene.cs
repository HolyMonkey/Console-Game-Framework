using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameFramework
{
    public class Scene 
    {
        private List<GameObject> _gameObjects = new List<GameObject>();

        public void AddObject(GameObject go)
        {
            _gameObjects.Add(go);
        }

        public IEnumerable<GameObject> GetObjects()
        {
            return _gameObjects;
        }


    }
}
