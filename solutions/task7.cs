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
            int costOfCrystals= 99;

            Console.Write("Сколько золота вы имеете? ");
            gold = Convert.ToInt32(Console.ReadLine());

            int tmpMaxCrystalsAmountToBuy = gold / costOfCrystals;

            Console.Write($"Вы можете приобрести {tmpMaxCrystalsAmountToBuy} кристалов.\n" +
                $"Сколько кристалов хотите приобрести? ");

            int tmpCrystalsAmountWantToBuy;
            tmpCrystalsAmountWantToBuy = Convert.ToInt32(Console.ReadLine());
            gold -= tmpCrystalsAmountWantToBuy * costOfCrystals;
            сrystals += tmpCrystalsAmountWantToBuy;

            Console.WriteLine($"У вас осталось {gold} золота и {сrystals} кристаллов");
        }
    }
}
