using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            string name, surname, job;

            Console.WriteLine("Напишите своё имя:");
            name = Console.ReadLine();

            Console.WriteLine("Напишите свою фамилию:");
            surname = Console.ReadLine();

            Console.WriteLine("Укажите свою должность:");
            job = Console.ReadLine();

            Console.WriteLine($"Вас зовут {surname} {name}, вы {job}.");
        }
    }
}
