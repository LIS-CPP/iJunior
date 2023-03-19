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

            int cols = 3;
            int pictureCount = 52;
            int rows = pictureCount / cols;
            int leftovers = pictureCount % cols;

            Console.WriteLine($"Полностью заполненых рядов: {rows}\n" +
                $"Картинок сверх меры: {leftovers}\n");
        }
    }
}

```
[task6.cs](task6.cs)
