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

            const int delayTime = 10;
            const int minutesInHour = 60;

            Console.Write("Введите количество людей в очереди: ");

            int peolpeAmount;
            peolpeAmount = Convert.ToInt32(Console.ReadLine());

            int timeToWait = peolpeAmount * delayTime;
            int hoursToWait = timeToWait / minutesInHour;
            int remainingMinutesToWait = timeToWait % minutesInHour;

            Console.WriteLine($"Вам придётся отстоять в очереди {hoursToWait} часа" +
                $"и {remainingMinutesToWait} минут");
        }
    }
}
```
[task8.cs](task8.cs)