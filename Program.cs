namespace Topic_1_6___Summative_Game__Electric_Boogaloo_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1 = new Die();
            Die die2 = new Die();
            string doneChoice;
            double money = 100;
            double bet;
            int betChoice;
            int rollSum;
            bool done = false;

            Console.WriteLine("Welcome to the Dice Game table");
            Console.WriteLine($"I see you're buying in with {money.ToString("C")}, very well, have a seat.");
            Console.WriteLine("Press ENTER to have a seat:");
            Console.ReadLine();
            Console.WriteLine("Thank you. Now, let me explain the game.");
            Console.WriteLine("You will place a bet, trying to guess what the result of a roll of two dice will be, from a provided list");
            Console.WriteLine("If you get it right, you win some money. If you get it wrong I keep your bet.");
            Console.WriteLine("Now, press ENTER to begin the game.");
            Console.ReadLine();

            while (!done)
            {
                Console.WriteLine("Here are your betting options:");
                Console.WriteLine("(Format:Guess (Probability - Payout))");
                Console.WriteLine();
                Console.WriteLine("1 - Doubles (1/6 - 2x bet)");
                Console.WriteLine("2 - Not Doubles (5/6 - 0.5x bet)");
                Console.WriteLine("3 - Even Sum (6/11 - 1x bet)");
                Console.WriteLine("4 - Odd Sum (5/11 - 1x bet)");
                Console.WriteLine();
                Console.WriteLine("Please enter the number corosponding to your bet:");

                while (!Int32.TryParse(Console.ReadLine().Trim(), out betChoice) || betChoice != 1 && betChoice != 2 && betChoice != 3 && betChoice != 4)
                {
                    Console.WriteLine("That is not a valid guess, please select one of the four options above:");
                }

                if (betChoice == 1)
                {
                    Console.WriteLine("You have chosen to bet on Doubles.");
                }
                else if (betChoice == 2)
                {
                    Console.WriteLine("You have chosen to bet on Not Doubles.");
                }
                else if (betChoice == 3)
                {
                    Console.WriteLine("You have chosen to bet on Even Sum.");
                }
                else if (betChoice == 4)
                {
                    Console.WriteLine("You have chosen to bet on Odd Sum.");
                }

                Console.WriteLine("Now, how much would you like to bet?");
                Console.WriteLine($"(Reminder, your current balance is {money.ToString("C")})");

                while (!Double.TryParse(Console.ReadLine().Trim(), out bet) || bet <= 0 || bet > money)
                {
                    Console.WriteLine("That is not a valid bet. Please enter a positive amount that is less than you current balance:");
                }

                bet = Math.Round(bet, 2);

                if (betChoice == 1)
                {
                    Console.WriteLine($"Okay, so you have chosen to bet {bet.ToString("C")} on Doubles.");
                }
                else if (betChoice == 2)
                {
                    Console.WriteLine($"Okay, so you have chosen to bet {bet.ToString("C")} on Not Doubles.");
                }
                else if (betChoice == 3)
                {
                    Console.WriteLine($"Okay, so you have chosen to bet {bet.ToString("C")} on Even Sum.");
                }
                else if (betChoice == 4)
                {
                    Console.WriteLine($"Okay, so you have chosen to bet {bet.ToString("C")} on Odd Sum.");
                }

                Console.WriteLine("Press ENTER to roll the dice:");
                Console.ReadLine();

                die1.RollDie();
                Console.WriteLine($"Die 1 = {die1}");
                die1.DrawRoll();
                Thread.Sleep(800);
                die2.RollDie();
                Console.WriteLine($"Die 2 = {die2}");
                die2.DrawRoll();
                Console.WriteLine();
                Thread.Sleep(500);

                if (betChoice == 1)
                {
                    if (die1.Roll == die2.Roll)
                    {
                        Console.WriteLine("Doubles! You got it right!");

                        money += bet * 2;

                        Console.WriteLine($"You won {(bet * 2).ToString("C")}");
                    }
                    else
                    {
                        Console.WriteLine("Not Doubles. You were wrong");

                        money -= bet;

                        Console.WriteLine($"You lost {bet.ToString("C")}");
                    }
                }
                else if (betChoice == 2)
                {
                    if (die1.Roll != die2.Roll)
                    {
                        Console.WriteLine("Not Doubles! You were right!");

                        money += Math.Round((bet / 2), 2);

                        Console.WriteLine($"You won {Math.Round((bet/2), 2).ToString("C")}");
                    }
                    else
                    {
                        Console.WriteLine("Doubles. You were wrong.");

                        money -= bet;

                        Console.WriteLine($"You lost {bet.ToString("C")}");
                    }
                }
                else if (betChoice == 3)
                {
                    rollSum = die1.Roll + die2.Roll;

                    if (rollSum == 2 || rollSum == 4 || rollSum == 6 || rollSum == 8 || rollSum == 10 || rollSum == 12)
                    {
                        Console.WriteLine($"The sum of the rolls is {rollSum}. That's even, you were right!");

                        money += bet;

                        Console.WriteLine($"You won {bet.ToString("C")}");
                    }
                    else
                    {
                        Console.WriteLine($"The sum of the rolls is {rollSum}. That's odd, you were wrong.");

                        money -= bet;

                        Console.WriteLine($"You lost {bet.ToString("C")}");
                    }
                }
                else if (betChoice == 4)
                {
                    rollSum = die1.Roll + die2.Roll;

                    if (rollSum == 3 || rollSum == 5 || rollSum == 7 || rollSum == 9 || rollSum == 11)
                    {
                        Console.WriteLine($"The sum of the rolls is {rollSum}. That's odd, you were right!");

                        money += bet;

                        Console.WriteLine($"You won {bet.ToString("C")}");
                    }
                    else
                    {
                        Console.WriteLine($"The sum of the rolls is {rollSum}. That's even, you were wrong.");

                        money -= bet;

                        Console.WriteLine($"You lost {bet.ToString("C")}");
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"You have {money.ToString("C")} remaining");
                Console.WriteLine();
                Thread.Sleep(1000);

                if (money <= 0)
                {
                    Console.WriteLine("I'm sorry, it appears you have no money left, I must ask you to leave the table.");
                    Console.WriteLine("Better luck next time.");

                    done = true;
                }
                else
                {
                    Console.WriteLine("Would you like to play another round? (y/n):");

                    doneChoice = Console.ReadLine().Trim().ToLower();

                    while (doneChoice != "y" && doneChoice != "n")
                    {
                        Console.WriteLine("I'm sorry, I need to know if you wish to play another round. (y/n)");

                        doneChoice = Console.ReadLine().Trim().ToLower();
                    }

                    if (doneChoice == "y")
                    {
                        Console.WriteLine("Okay, let's reset the table for another round!");
                        Console.WriteLine("(Press ENTER to reset the table)");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (doneChoice == "n")
                    {
                        done = true;

                        Console.WriteLine("Okay, thank you for playing.");
                        Console.Write($"You ended with {money.ToString("C")}, ");

                        if (money >= 100)
                        {
                            Console.WriteLine($"a total profit of {(money - 100).ToString("C")}");
                            Thread.Sleep(1000);
                            Console.WriteLine("Good job!");
                        }
                        else
                        {
                            Console.WriteLine($"a total loss of {Math.Abs(money - 100).ToString("C")}");
                            Thread.Sleep(1000);
                            Console.WriteLine("Better luck next time!");
                        }
                    }


                }
            }











        }
    }
}
