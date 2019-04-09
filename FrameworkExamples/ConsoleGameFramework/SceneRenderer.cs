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
            foreach (var go in scene.GetAllGameObjects())
            {
                ConsoleColor lastColor = Console.ForegroundColor;
                Console.ForegroundColor = go.Color;

                char[,] image = Sprites.GetSprite(go.SpriteID).Image;
                for (int i = 0; i < image.GetLength(0); i++)
                {
                    for (int j = 0; j < image.GetLength(1); j++)
                    {
                        Console.SetCursorPosition(go.X + j, go.Y + i);
                        Console.Write(image[i,j]);
                    }
                }

                Console.ForegroundColor = lastColor;
            }
        }
    }
}
