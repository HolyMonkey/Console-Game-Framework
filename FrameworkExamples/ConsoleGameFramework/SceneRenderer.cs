using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameFramework
{
    public class SceneRenderer
    {

        /// <summary>
        /// Drawing scene
        /// </summary>
        /// <param name="scene">Scene for render</param>
        public void DrawScene(Scene scene)
        {
            foreach (var go in scene.GetObjects())
            {
                Console.SetCursorPosition(go.X, go.Y);
                Console.ForegroundColor = go.Color;
                Console.Write(go.Sprite);
            }
        }
    }
}
