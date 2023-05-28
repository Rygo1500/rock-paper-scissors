using System;

namespace rock
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string player;
            string computer;
            bool playAgain = true;
            string choice;

            while (playAgain)
            {
                player = "";
                computer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS" && player != "LIZARD" && player != "SPOCK")
                {
                    Console.Write("Enter ROCK, PAPER, SCISSORS, LIZZARD or SPOCK: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                    }

                switch(random.Next(1,6))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                    case 4:
                        computer = "LIZZARD";
                        break;
                    case 5:
                        computer = "SPOCK";
                        break;
                 }
                Console.WriteLine("You chose: " + player);
                Console.WriteLine("Computer chose: " + computer);

                switch (player)
                {
                    case "ROCK":
                        switch (computer)
                        {
                            case "ROCK":
                                Console.WriteLine("It's a draw!");
                                break;
                            case "PAPER":
                                Console.WriteLine("Paper cover rock, you lose!");
                                break;
                            case "SCISSORS":
                                Console.WriteLine("Rock breaks scissors, you win!");
                                break;
                            case "LIZZARD":
                                Console.WriteLine("Rock crushes lizard, you win!");
                                break;
                            case "SPOCK":
                                Console.WriteLine("Spock vaporizes rock, you lose!");
                                break;
                        }
                        break;
                    case "PAPER":
                        switch (computer)
                        {
                            case "ROCK":
                                Console.WriteLine("Paper cover rock, you win!");
                                break;
                            case "PAPER":
                                Console.WriteLine("It's a draw!");
                                break;
                            case "SCISSORS":
                                Console.WriteLine("Scissors cut paper, you lose!");
                                break;
                            case "LIZZARD":
                                Console.WriteLine("Lizzard eats papaer, you lose!");
                                break;
                            case "SPOCK":
                                Console.WriteLine("Paper disproves Spock, you win!");
                                break;
                        }
                        break;
                    case "SCISSORS":
                        switch (computer)
                        {
                            case "ROCK":
                                Console.WriteLine("Rock breaks scissors, you lose!");
                                break;
                            case "PAPER":
                                Console.WriteLine("Scissors cut paper, you win!");
                                break;
                            case "SCISSORS":
                                Console.WriteLine("It's a draw!");
                                break;
                            case "LIZZARD":
                                Console.WriteLine("Scissors decapitate lizzard, you win!");
                                break;
                            case "SPOCK":
                                Console.WriteLine("Spock smashes scissors, you lose!");
                                break;
                        }
                        break;
                    case "LIZZARD":
                        switch (computer)
                        {
                            case "ROCK":
                                Console.WriteLine("Rock crushes lizzard, you lose!");
                                break;
                            case "PAPER":
                                Console.WriteLine("Lizzard eats paper, you win!");
                                break;
                            case "SCISSORS":
                                Console.WriteLine("Scissors decapitate lizzard, you lose!");
                                break;
                            case "LIZZARD":
                                Console.WriteLine("It's a draw!");
                                break;
                            case "SPOCK":
                                Console.WriteLine("Lizzard poisons spock, you win!");
                                break;
                        }
                        break;
                    case "SPOCK":
                        switch (computer)
                        {
                            case "ROCK":
                                Console.WriteLine("Spock vaporizes rock, you win!");
                                break;
                            case "PAPER":
                                Console.WriteLine("Paper disproves Spock, you win!");
                                break;
                            case "SCISSORS":
                                Console.WriteLine("Spock smashes scissors, you lose!");
                                break;
                            case "LIZZARD":
                                Console.WriteLine("It's a draw!");
                                break;
                            case "SPOCK":
                                Console.WriteLine("It's a draw!");
                                break;
                        }
                        break;
                 }
                Console.WriteLine("Do you want to play again? (Y/N)");
                choice = Console.ReadLine();
                choice = choice.ToUpper();
                if (choice == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }

            }
            Console.Write("Thanks for playing!");
            Console.ReadKey();
        }
    }
}
