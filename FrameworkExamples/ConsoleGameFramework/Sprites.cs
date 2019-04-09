using System.Collections.Generic;
using System.Linq;

namespace ConsoleGameFramework
{
    public static class Sprites
    {
        static private List<Sprite> _spriteList = new List<Sprite>();

        static public void AddSprite(Sprite newSpite)
        {
            _spriteList.Add(newSpite);
        }

        static public Sprite GetSprite(int id)
        {
            return _spriteList.FirstOrDefault(x => x.ID == id);
        }
    }
}
