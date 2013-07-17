using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {
        static int numberOfDice, sidesOnDice, rolled;
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Example of Dice Notation: '2d20' would indicated rolling two 20-faced die.\nPlease enter the specifications of the dice to be rolled using Dice Notation:\n");
            String diceRequest = Console.ReadLine();
            Console.WriteLine("You requested: " + diceRequest);

            MakeDice(diceRequest);

            for (int a = 0; a < numberOfDice; a++)
            {
                rollDice(sidesOnDice);
            }
            Console.ReadLine();
        }

        static void MakeDice(String diceRequest)
        {
            String[] sidesNumber = diceRequest.Split('d');
            numberOfDice = int.Parse(sidesNumber[0]);
            sidesOnDice = int.Parse(sidesNumber[1]);

        }

        static void rollDice(int sidesOnDice)
        {
            int rolled = random.Next(1, sidesOnDice);
            Console.WriteLine(rolled);
        }
    }
}
