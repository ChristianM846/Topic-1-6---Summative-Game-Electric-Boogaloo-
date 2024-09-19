using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_1_6___Summative_Game__Electric_Boogaloo_
{
    public class Die
    {
        private Random _generator;
        private int _roll;

        public Die()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
        }

        public Die(int roll)
        {
            _generator = new Random();

            if (roll < 1)
            {
                roll = 1;
            }
            else if (roll > 6)
            {
                roll = 6;
            }
            else
            {
                _roll = roll;
            }

        }

        public int Roll { get { return _roll; } }

        public void RollDie()
        {
            _roll = _generator.Next(1, 7);
        }

        public override string ToString()
        {
            return _roll.ToString();
        }

        public void DrawRoll()
        {
            if (_roll == 1)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|   |");
                Console.WriteLine("| o |");
                Console.WriteLine("|   |");
                Console.WriteLine("-----");
            }
            else if (_roll == 2)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o  |");
                Console.WriteLine("|   |");
                Console.WriteLine("|  o|");
                Console.WriteLine("-----");
            }
            else if (_roll == 3)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o  |");
                Console.WriteLine("| o |");
                Console.WriteLine("|  o|");
                Console.WriteLine("-----");
            }
            else if (_roll == 4)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("|   |");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else if (_roll == 5)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("| o |");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else if (_roll == 6)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("|o o|");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
        }



    }

}
