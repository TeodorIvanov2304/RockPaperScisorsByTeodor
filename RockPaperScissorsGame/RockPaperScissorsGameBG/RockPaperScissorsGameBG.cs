using System;
using System.Data;
using System.Net.WebSockets;

namespace RockPaperScissorsGame
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string Камък = "Камък";
            const string Хартия = "Хартия";
            const string Ножица = "Ножица";

        start:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Изберете [к]амък, [н]ожица или [х]артия:");
            string playerMove = Console.ReadLine();

            if (playerMove == "камък" || playerMove == "к" || playerMove == "Камък")
            {
                playerMove = Камък;
            }
            else if (playerMove == "хартия" || playerMove == "х" || playerMove == "Хартия")
            {
                playerMove = Хартия;
            }
            else if (playerMove == "ножица" || playerMove == "н" || playerMove == "Ножица")
            {
                playerMove = Ножица;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Грешен вход. Опитайте отново...");

            }
            Random random = new Random();
            byte computerRandomNumber = (byte)random.Next(1, 4);
            string computerMove = string.Empty;

            switch (computerRandomNumber)
            {
                case 1:
                    computerMove = Камък;
                    break;
                case 2:
                    computerMove = Хартия;
                    break;
                case 3:
                    computerMove = Ножица;
                    break;

            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Компютърът избра {computerMove}.");

            if (playerMove == Камък && computerMove == Ножица
                || playerMove == Хартия && computerMove == Камък
                || playerMove == Ножица && computerMove == Хартия)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Вие печелите.");
            }
            else if (playerMove == Камък && computerMove == Хартия
                || playerMove == Хартия && computerMove == Ножица
                || playerMove == Ножица && computerMove == Камък)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вие губите.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Играта завърши наравно");
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
