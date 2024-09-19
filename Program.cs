namespace Topic_1_6___Summative_Game__Electric_Boogaloo_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1 = new Die();
            Die die2 = new Die();
            double money = 100;
            double bet;
            int betChoice;
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
                Console.WriteLine("3 - Even Sum (1/2 - 1x bet)");
                Console.WriteLine("4 - Odd Sum (1/2 - 1x bet)");
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
                Console.WriteLine($"(Reminder, your current balance is {money.ToString("C")}");

                while (!Double.TryParse(Console.ReadLine().Trim(), out bet) || bet <= 0 || bet > money)
                {
                    Console.WriteLine("That is not a valid bet. Please enter a positive amount that is less than you current balance:");
                }

                if (betChoice == 1)
                {
                    Console.WriteLine($"Okay, so you have chosen to bet {bet} on Doubles.");
                }
                else if (betChoice == 2)
                {
                    Console.WriteLine($"Okay, so you have chosen to bet {bet} on Not Doubles.");
                }
                else if (betChoice == 3)
                {
                    Console.WriteLine($"Okay, so you have chosen to bet {bet} on Even Sum.");
                }
                else if (betChoice == 4)
                {
                    Console.WriteLine($"Okay, so you have chosen to bet {bet} on Odd Sum.");
                }

                Console.WriteLine("Press ENTER to roll the dice:");
                Console.ReadLine();



                Console.ReadLine();
            }











        }
    }
}
