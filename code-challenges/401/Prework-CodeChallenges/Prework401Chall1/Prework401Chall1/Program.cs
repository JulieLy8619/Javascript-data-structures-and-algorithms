using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prework401Chall1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayMax();
            Console.ReadLine();
        }
        private static void ArrayMax()
        {
            int guessCounter = 0;
            string[] numArray = new string[5];
            string tempNum = "";
            do
            {
                Console.Write("Please enter a number between 1 to 10? \n");
                tempNum = Console.ReadLine();
                if (tempNum == "1" || tempNum == "2" || tempNum == "3" || tempNum == "4" || tempNum == "5" || tempNum == "6" || tempNum == "7" || tempNum == "8" || tempNum == "9" || tempNum == "10")
                {
                    numArray[guessCounter] = tempNum;
                    Console.Write(numArray[guessCounter]); //this shows there is info in the array
                    guessCounter++;
                }
                else
                {
                    Console.Write("that isn't a valid entry");
                }
                Console.Write("guess counter " + guessCounter);
            } while (guessCounter < 5);
        }
    }
}
