```csharp
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
            int picturesAmount = 52;
            int filledRows = picturesAmount / picturesInRow;
            int remainingPictures = picturesAmount % picturesInRow;

            Console.WriteLine($"Полностью заполненых рядов: {filledRows}\n" +
                $"Картинок сверх меры: {remainingPictures}\n");
        }
    }
}
```
[task6.cs](task6.cs)
