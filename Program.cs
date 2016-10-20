using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        //boolean sets ups that play equals true
        static bool play = true;

        static void Main(string[] args)
        {
            string answer = "";
            do
            {
                Console.WriteLine("Rock, paper, scissors?");

                Console.WriteLine("Player 1, please enter your hand");

                string hand1 = Console.ReadLine().ToLower();

                Console.WriteLine("Player 2, please enter your hand");
                

                string hand2 = Console.ReadLine().ToLower();

                if (hand1 == hand2)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if (hand1 == "rock" && hand2 == "paper")
                {
                    Console.WriteLine("Player 2 wins!");
                }
                
                else if (hand1 == "paper" && hand2 == "rock")
                {

                    Console.WriteLine("Player 1 wins!");
                }

                else if (hand1 == "scissors" && hand2 == "paper")
                {
                    Console.WriteLine("Player 1 wins!");
                }
                else if (hand1 == "paper" && hand2 == "scissors")
                {
                    Console.WriteLine("Player 2 wins!");
                }

                else if (hand1 == "scissors" && hand2 == "rock")
                {
                    Console.WriteLine("Player 2 wins!");
                }
                else if (hand1 == "rock" && hand2 == "scissors")
                {
                    Console.WriteLine("Player 1 wins!");
                }
                Console.WriteLine("Do you want to play again? Yes or no?");

                answer = Console.ReadLine().ToLower();

                if (Console.ReadLine() == "n")
                    play = false;
                Console.Clear();

            }

            while (answer == "yes");

            Console.WriteLine("Thanks for playing!");

        }
    }
}
