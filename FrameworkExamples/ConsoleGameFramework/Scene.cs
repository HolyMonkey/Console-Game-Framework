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

        /// <summary>
        /// Adds an object to the scene.
        /// </summary>
        /// <param name="go">What game object to add</param>
        public void AddObject(GameObject go)
        {
            _gameObjects.Add(go);
        }

        /// <summary>
        /// Return all objects in the scene
        /// </summary>
        /// <returns>IEnumerable List</returns>
        public IEnumerable<GameObject> GetAllGameObjects()
        {
            return _gameObjects;
        }
    }
}
