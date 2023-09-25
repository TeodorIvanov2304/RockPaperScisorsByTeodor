using System;
using System.Data;
using System.Net.WebSockets;

namespace RockPaperScissorsGame
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string Rock = "Камък";
            const string Paper = "Ножица";
            const string Scissors = "Хартия";

        start:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Изберете [к]амък, [н]ожица или [х]артия:");
            string playerMove = Console.ReadLine();

            if (playerMove == "камък" || playerMove == "к" || playerMove == "Камък")
            {
                playerMove = Rock;
            }
            else if (playerMove == "хартия" || playerMove == "х" || playerMove == "Хартия")
            {
                playerMove = Paper;
            }
            else if (playerMove == "ножица" || playerMove == "н" || playerMove == "Ножица")
            {
                playerMove = Scissors;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Грешен вход. Опитайте отново...");
                return;

            }
            Random random = new Random();
            byte computerRandomNumber = (byte)random.Next(1, 4);
            string computerMove = string.Empty;

            switch (computerRandomNumber)
            {
                case 1:
                    computerMove = Rock;
                    break;
                case 2:
                    computerMove = Paper;
                    break;
                case 3:
                    computerMove = Scissors;
                    break;

            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Компютърът избра {computerMove}.");

            if (playerMove == Rock && computerMove == Scissors
                || playerMove == Paper && computerMove == Rock
                || playerMove == Scissors && computerMove == Paper)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Вие печелите.");
            }
            else if (computerMove == Rock && playerMove == Scissors
                || computerMove == Paper && playerMove == Rock
                || computerMove == Scissors && playerMove == Paper)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вие губите.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Играта е наравно");
            }

        start2:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Искате ли да играете още? Напишете 'д' за Да или 'н' за Не.");
            char input = char.Parse(Console.ReadLine());
            if (input == 'д')
            {
                goto start;
            }
            else if (input == 'н')
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Благодаря, че играхте!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Грешен вход. Моля, въведи 'д' или 'н'.");
                goto start2;
            }

        }
    }
}
