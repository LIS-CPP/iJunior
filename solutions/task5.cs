using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            string name = "Pozov", surname = "Igor";

            Console.WriteLine($"Имя: {name}; Фамилия: {surname}");

            string tmp = name;
            name = surname;
            surname = tmp;

            Console.WriteLine($"Имя: {name}; Фамилия: {surname}");
        }
    }
}
