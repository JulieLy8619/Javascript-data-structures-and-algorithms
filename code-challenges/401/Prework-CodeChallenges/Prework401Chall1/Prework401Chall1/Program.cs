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
            //part 1 of problem 1, collect numbers from user and populate array
            int guessCounter = 0;
            string[] numArray = new string[5];
            string tempNum = "";
            do
            {
                Console.WriteLine("Please enter a number between 1 to 10?");
                tempNum = Console.ReadLine();
                if (tempNum == "1" || tempNum == "2" || tempNum == "3" || tempNum == "4" || tempNum == "5" || tempNum == "6" || tempNum == "7" || tempNum == "8" || tempNum == "9" || tempNum == "10")
                {
                    numArray[guessCounter] = tempNum;
                    //Console.WriteLine(numArray[guessCounter]); //this shows there is info in the array
                    guessCounter++;
                }
                else
                {
                    Console.WriteLine("that isn't a valid entry");
                }
            } while (guessCounter < 5);

            //part 2 of problem 1: prints array and ask user for a number and return a score
            Console.Write("The numbers in the list: ");
            for (int i = 0; i < 5;i++)
            {
                Console.Write(numArray[i] + " ");
            }
            Console.WriteLine("Please select a number from the list?");
            string userChoice = Console.ReadLine();
            Console.WriteLine("userschoice " + userChoice); //just for testing
            //it defaults to 50, and if I put in a number it does i dont know math to it (1 put it at 49, 3 put it at 51
            ArrayMax(numArray,userChoice);
            Console.ReadLine();
        }

        private static void ArrayMax(string[] array, string selection)
        {
            int scoreMult1 = 1;
            int scoreMult2 = 1;
            int scoreMult3 = 1;
            int scoreMult4 = 1;
            int scoreMult5 = 1;
            int scoreMult6 = 1;
            int scoreMult7 = 1;
            int scoreMult8 = 1;
            int scoreMult9 = 1;
            int scoreMult10 = 1;
            int score = 1;
            int intSelection = 0;

            //iterate through array and count number of times a number was selected
            for (int i = 0; i < 5; i++)
            {
                if (array[i] == "1")
                    scoreMult1++;
                else if (array[i] == "2")
                    scoreMult2++;
                else if (array[i] == "3")
                    scoreMult3++;
                else if (array[i] == "4")
                    scoreMult4++;
                else if (array[i] == "5")
                    scoreMult5++;
                else if (array[i] == "6")
                    scoreMult6++;
                else if (array[i] == "7")
                    scoreMult7++;
                else if (array[i] == "8")
                    scoreMult8++;
                else if (array[i] == "9")
                    scoreMult9++;
                else if (array[i] == "10")
                    scoreMult10++;
            }
            Console.WriteLine("selection :" + selection); //just for testing
            if (selection == "1")
            {
                intSelection = 1;
                score = intSelection * scoreMult1;
            }
            else if (selection == "2")
            {
                intSelection = 2;
                score = intSelection * scoreMult2;
            }
            else if (selection == "3")
            {
                intSelection = 3;
                score = intSelection * scoreMult3;
            }
            else if (selection == "4")
            {
                intSelection = 4;
                score = intSelection * scoreMult4;
            }
            else if (selection == "5")
            {
                intSelection
                score = intSelection * scoreMult5;
            }
            else if (selection == "6")
            {
                intSelection
                score = intSelection * scoreMult6;
            }
            else if (selection == "7")
                score = intSelection * scoreMult7;
            else if (selection == "8")
                score = intSelection * scoreMult8;
            else if (selection == "9")
                score = intSelection * scoreMult9;
            else if (selection == "10")
                score = intSelection * scoreMult10;
 
            Console.Write("your score is: ");
            Console.WriteLine(score); //score is zero because that was my defaul and I never make it into my if's
            Console.ReadLine();
        }
    }
}

/*
Questions: 
-How do I add documents? (like a readme.md)
-from my research, i can't just show the array, i have to loop through it, can you verify this is true
*/
