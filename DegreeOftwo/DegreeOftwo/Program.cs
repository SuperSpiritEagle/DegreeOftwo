using System;

namespace DegreeOftwo
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = 2;
            int minNumber = 1;
            int maxNumber = 100;
            int randomNumber = 0;
            int degree = 1;
            int sumNumber = 1;

            Random random = new Random();

            randomNumber = random.Next(minNumber, maxNumber);

            while (randomNumber >= sumNumber)
            {
                
                sumNumber *= number;
                degree++;
            }

            degree--;
            Console.WriteLine($"Для числа {randomNumber} будет {number} в степени {degree} = {sumNumber}");
        }
    }
}
