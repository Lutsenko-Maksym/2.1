using System;

class GuessNumberGame
{
    static void Main()
    {
        Random random = new Random();
        int targetNumber = random.Next(1, 11);
        int userGuess;
        bool guessedCorrectly = false;

        Console.WriteLine("Гра 'Вгадай число'! Загадано число від 1 до 10.");

        while (!guessedCorrectly)
        {
            Console.Write("Введіть ваше число (або 0 для завершення): ");
            if (!int.TryParse(Console.ReadLine(), out userGuess) || userGuess < 0 || userGuess > 10)
            {
                Console.WriteLine("Некоректний ввід. Спробуйте знову.");
                continue;
            }

            if (userGuess == 0)
            {
                Console.WriteLine("Гру завершено.");
                break;
            }

            if (userGuess == targetNumber)
            {
                Console.WriteLine("Вітаємо! Ви вгадали число.");
                guessedCorrectly = true;
            }
            else if (userGuess < targetNumber)
            {
                Console.WriteLine("Загадане число більше.");
            }
            else
            {
                Console.WriteLine("Загадане число менше.");
            }
        }
    }
}
