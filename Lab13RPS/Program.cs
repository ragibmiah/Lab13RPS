using System;

namespace Lab13RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Player1 rock = new Player1();
            Player2 rando = new Player2();
            //Player3 human = new Player3();
            bool success = true;

            Console.WriteLine("Welcome to Rock, Paper, Scissors!");

            Console.Write("Please enter your name: ");
            Player3 human = new Player3();
          
            while (success)
            { 
                Console.Write("Would you like to play against Price or Ghost? (P or G) ");
                string choice = Console.ReadLine().ToLower();

            
                if (choice == "p")
                {
                    Console.WriteLine($"{human.PlayerName}: {human.GenerateRoshambo()}");
                    Console.WriteLine($"{rock.PlayerName}: {Roshambo.Rock}");
                    if (human.GenerateRoshambo() == Roshambo.Rock)
                    {
                        Console.WriteLine("Draw!");
                    }
                    else if (human.GenerateRoshambo() == Roshambo.Paper)
                    {
                        Console.WriteLine($"{human.PlayerName} wins!");
                    }
                    else if (human.GenerateRoshambo() == Roshambo.Scissors)
                    {
                        Console.WriteLine($"{rock.PlayerName} wins!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                        success = true;
                    }
                }
                else if (choice == "g")
                {
                    Console.WriteLine($"{human.PlayerName}: {human.GenerateRoshambo()}");
                    Console.WriteLine($"{rando.PlayerName}: {rando.GenerateRoshambo()}");


                    if (human.GenerateRoshambo() == rando.GenerateRoshambo())
                    {
                        Console.WriteLine($"Draw!");
                    }
                    else if (human.GenerateRoshambo() == Roshambo.Rock && rando.GenerateRoshambo() == Roshambo.Paper)
                    {
                        Console.WriteLine($"{rando.PlayerName} wins!");
                    }
                    else if (human.GenerateRoshambo() == Roshambo.Rock && rando.GenerateRoshambo() == Roshambo.Scissors)
                    {
                        Console.WriteLine($"{human.PlayerName} wins!");
                    }
                    else if (human.GenerateRoshambo() == Roshambo.Scissors && rando.GenerateRoshambo() == Roshambo.Paper)
                    {
                        Console.WriteLine($"{human.PlayerName} wins!");
                    }
                    else if (human.GenerateRoshambo() == Roshambo.Scissors && rando.GenerateRoshambo() == Roshambo.Rock)
                    {
                        Console.WriteLine($"{rando.PlayerName} wins!");
                    }
                    else if (human.GenerateRoshambo() == Roshambo.Paper && rando.GenerateRoshambo() == Roshambo.Rock)
                    {
                        Console.WriteLine($"{human.PlayerName} wins!");
                    }
                    else if (human.GenerateRoshambo() == Roshambo.Paper && rando.GenerateRoshambo() == Roshambo.Scissors)
                    {
                        Console.WriteLine($"{rando.PlayerName} wins!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                        success = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid");
                    success = true;
                }
                Console.Write("Do you want to play again? (y or n): ");
                string doAgain = Console.ReadLine().ToLower();

                if (doAgain == "y")
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
          
        }

    }
}
