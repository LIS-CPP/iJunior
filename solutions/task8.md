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

            const int DelayTimeInSeconds = 10;
            const int MinutesInHour = 60;

            Console.Write("Введите количество людей в очереди: ");

            int peopleCount;
            peopleCount = Convert.ToInt32(Console.ReadLine());

            int timeToWait = peopleCount * DelayTimeInSeconds;
            int hoursToWait = timeToWait / MinutesInHour;
            int remainingMinutesToWait = timeToWait % MinutesInHour;

            Console.WriteLine($"Вам придётся отстоять в очереди {hoursToWait} часа" +
                $"и {remainingMinutesToWait} минут");
        }
    }
}
```
[task8.cs](task8.cs)
