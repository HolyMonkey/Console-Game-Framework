﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleGameFramework;
namespace FrameworkExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Scene scene = new Scene();
            SceneRenderer renderer = new SceneRenderer();
            GameObject go = new GameObject('#', 0, 0, ConsoleColor.Red);
            GameObject go1 = new GameObject('$', 1, 0, ConsoleColor.Green);

            scene.AddObject(go);
            scene.AddObject(go1);
            Input input = new Input();

            input.StartInput();
            MovementComponent movement = new MovementComponent(go, input);
            go.AddComponent(movement);

            while (true)
            {
                foreach (var item in go.GetAllComponents())
                {
                    item.Start();   
                    item.Update();
                }

                renderer.DrawScene(scene);
                Thread.Sleep(100);
                Console.Clear();
            }
        }
    }
}
