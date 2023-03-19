using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            int picturesInRow = 3;
            int picturesCount = 52;
            int filledRows = picturesCount / picturesInRow;
            int remainingPictures = picturesAmount % picturesInRow;

            Console.WriteLine($"Полностью заполненых рядов: {filledRows}\n" +
                $"Картинок сверх меры: {remainingPictures}\n");
        }
    }
}
