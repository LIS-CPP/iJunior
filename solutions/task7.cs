using System;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            int gold = 0;
            int сrystals = 0;
            int costOfOneCrystal = 99;

            Console.Write("Сколько золота вы имеете? ");
            gold = Convert.ToInt32(Console.ReadLine());

            int tempMaxCrystalsAmountToBuy = gold / costOfOneCrystal;

            Console.Write($"Вы можете приобрести {tempMaxCrystalsAmountToBuy} кристалов.\n" +
                $"Сколько кристалов хотите приобрести? ");

            int tempCrystalsAmountWantToBuy;
            tempCrystalsAmountWantToBuy = Convert.ToInt32(Console.ReadLine());
            gold -= tempCrystalsAmountWantToBuy * costOfOneCrystal;
            сrystals += tempCrystalsAmountWantToBuy;

            Console.WriteLine($"У вас осталось {gold} золота и {сrystals} кристаллов");
        }
    }
}
