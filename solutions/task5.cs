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

            string tmpName = name;
            name = surname;
            surname = tmpName;

            Console.WriteLine($"Имя: {name}; Фамилия: {surname}");
        }
    }
}
