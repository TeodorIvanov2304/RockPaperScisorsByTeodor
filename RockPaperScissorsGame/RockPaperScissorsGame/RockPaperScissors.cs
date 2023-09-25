using System;
using System.Data;

namespace RockPaperScissorsGame
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissor";

            start:
            Console.WriteLine("Choose [r]ock, [p]aper or [s]cissors: ");
            string playerMove = Console.ReadLine();

            if(playerMove == "rock"|| playerMove == "r"|| playerMove == "Rock")
            {
                playerMove = Rock;
            }
            else if(playerMove == "paper"||playerMove == "p"||playerMove == "Paper")
            {
                playerMove = Paper;
            }
            else if(playerMove =="scissors"||playerMove == "s"||playerMove == "Scissors")
            {
                playerMove = Scissors;
            }
            else 
            {
                Console.WriteLine("Invalid Input. Try Again...");
                return;
                    
            }
            Random random = new Random();
            byte computerRandomNumber = (byte)random.Next(1, 4);
            string computerMove = string.Empty;

            switch(computerRandomNumber)
            {
               case 1: computerMove = Rock; 
                    break;
               case 2: computerMove = Paper; 
                    break;
               case 3: computerMove = Scissors; 
                    break;

            }
            Console.WriteLine($"The computer chose {computerMove}.");

            if(playerMove == Rock && computerMove == Paper
                ||playerMove==Paper && computerMove==Rock
                ||playerMove == Scissors && computerMove == Paper) 
            {
                Console.WriteLine("You win.");
            }
            else if(computerMove == Rock && playerMove == Paper
                || computerMove == Paper && playerMove == Rock
                || computerMove == Scissors && playerMove == Paper)
            {
                Console.WriteLine("You lose.");
            }
            else
            {
                Console.WriteLine("This game was a draw");
            }
            

            start2:
            Console.WriteLine("Do you want to play more? Type 'y' for Yes and 'n' for No. ");
            char input = char.Parse(Console.ReadLine());
            if(input == 'y')
            {
                goto start;
            }
            else if(input =='n')
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid input! Pleas, enter 'y' or 'n'!");
                goto start2;
            }

        }
    }
}
