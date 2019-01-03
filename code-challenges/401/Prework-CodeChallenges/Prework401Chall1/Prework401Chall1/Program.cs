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
            int p1GuessCounter = 0;
            string[] p1NumArray = new string[5];
            string p1TempNum = "";
            do
            {
                Console.WriteLine("Please enter a number between 1 to 10?");
                p1TempNum = Console.ReadLine();
                if (p1TempNum == "1" || p1TempNum == "2" || p1TempNum == "3" || p1TempNum == "4" || p1TempNum == "5" || p1TempNum == "6" || p1TempNum == "7" || p1TempNum == "8" || p1TempNum == "9" || p1TempNum == "10")
                {
                    p1NumArray[p1GuessCounter] = p1TempNum;
                    p1GuessCounter++;
                }
                else
                {
                    Console.WriteLine("that isn't a valid entry");
                }
            } while (p1GuessCounter < 5);

            //part 2 of problem 1: prints array and ask user for a number and return a score
            Console.Write("The numbers in the list: ");
            for (int i = 0; i < 5;i++)
            {
                Console.Write(p1NumArray[i] + " ");
            }
            Console.WriteLine("Please select a number from the list?");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            //******calls prob 1 method (just highlighting for easier grading) *****//
            ArrayMax(p1NumArray, userChoice);
            //*****end of prob 1 in MAIN ****//
            Console.ReadLine();
        }

        private static void ArrayMax(string[] array, int selection)
        {
            int scoreMult1 = 0;
            int scoreMult2 = 0;
            int scoreMult3 = 0;
            int scoreMult4 = 0;
            int scoreMult5 = 0;
            int scoreMult6 = 0;
            int scoreMult7 = 0;
            int scoreMult8 = 0;
            int scoreMult9 = 0;
            int scoreMult10 = 0;
            int score = 0;

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
            if (selection == 1)
                score = selection * scoreMult1;
            else if (selection == 2)
                score = selection * scoreMult2;
            else if (selection == 3)
                score = selection * scoreMult3;
            else if (selection == 4)
                score = selection * scoreMult4;
            else if (selection == 5)
                score = selection * scoreMult5;
            else if (selection == 6)
                score = selection * scoreMult6;
            else if (selection == 7)
                score = selection * scoreMult7;
            else if (selection == 8)
                score = selection * scoreMult8;
            else if (selection == 9)
                score = selection * scoreMult9;
            else if (selection == 10)
                score = selection * scoreMult10;
            else
                Console.Write("You didn't pick a possible number in the list");
 
            Console.Write("your score is: ");
            Console.WriteLine(score); 
        }
    }
}

/*
Questions: 
-How do I add documents? (like a readme.md)
-from my research, i can't just show the array, i have to loop through it, can you verify this is true
-when submit note this was in .netframework and already talked to amanada and i wouldn't lose points for it.

    
-note to self use .net core moving forward
-note to self, can use ubuntu for git ACP still if want but should get famil with power shell (not same as CDM)
-be able to and famil with ACP in VS (as MS uses that)
-but it really is whatever is most comfortable for you
-add docs with right click on folder and add file

*/
