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

            string name = "Pozov";
            string surname = "Igor";

            Console.WriteLine($"Имя: {name}; Фамилия: {surname}");

            string tempName = name;
            name = surname;
            surname = tempName;

            Console.WriteLine($"Имя: {name}; Фамилия: {surname}");
        }
    }
}
```
[task5.cs](task5.cs)
