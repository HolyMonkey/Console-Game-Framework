namespace ConsoleGameFramework
{
    public class Sprite
    {
        public int ID { get; private set; }
        public char[,] Image { get; private set; }

        public Sprite(int id, char[,] image)
        {
            ID = id;
            Image = image;
        }
    }
}
