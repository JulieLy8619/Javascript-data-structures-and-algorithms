﻿using System;
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
            //*****start of prob 1 in MAIN ****//
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
            Console.WriteLine();
            Console.WriteLine("Please select a number and I'll tell you your score?");
            int p1UserChoice = Convert.ToInt32(Console.ReadLine());

            ArrayMax(p1NumArray, p1UserChoice);
            //*****end of prob 1 in MAIN ****//

            //*****start of prob 2 in MAIN ****//
            Console.WriteLine("Please select a year and I will tell you if it is a leap year or not");
            int p2UserYearInput = Convert.ToInt32(Console.ReadLine());
            LeapYear(p2UserYearInput);
            //******end of prob 2 in MAIN*******//

            //*****start of prob 3 in MAIN ****//
            //the instruction didn't state to get the array from the user, Amanda said it is OK I hard coded in the information
//            int[] p3ParamArrayBad = new int[] { 1, 2, 3, 4, 5 };
            int[] p3ParamArrayGood = new int[] {1,3,2};
//            int[] p3ParamArrayGood2 = new int[] {0, 0, 0};
//            int[] p3ParamArrayBad2 = new int[] { 1, 3, 2, 0 };
//            int[] p3ParamArrayBad3 = new int[] { 1, 3, -2, 0 };
            //would 1,3,2,0 be a perfect sequence? I don't think so because the prod would become zero when it gets to the last digit...
            PerfectSequence(p3ParamArrayGood);
            //******end of prob 3 in MAIN

            //*****start of prob 4 in MAIN ****//
            //ask user for dimension of matrix, I chose to randomly fill in the matrix than make the user populate it all
            Console.WriteLine("Please provide the # of COLUMNS you would like for the Matrix: ");
            int p4UserColNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please provide the # of ROWS you would like for the Matrix: ");
            int p4UserRowNum = Convert.ToInt32(Console.ReadLine());
            SumRows(p4UserColNum, p4UserRowNum);
            //******end of prob 4 in MAIN

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
                Console.WriteLine("You didn't pick a possible number in the list");
 
            Console.Write("your score is: ");
            Console.WriteLine(score); 
        }
        private static void LeapYear(int year)
        {
            if (year % 400 == 0)
                Console.WriteLine($"{year} is a leap year");
            else if (year % 4 == 0 && year % 100 != 0)
                Console.WriteLine($"{year} is a leap year");
            else
                Console.WriteLine($"{year} is not a leap year");
        }
        private static void PerfectSequence(int[] arr)
        {
            Console.WriteLine("Evaluating Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int sumTotal = 0;
            int prodTotal = 1; 
            for (int i = 0; i < arr.Length; i++)
            {
                //I don't need to test for other than integers (like strings) because it would have errored out at function call
                if (arr[i] < 0)
                    break;
                else
                {
                    sumTotal = sumTotal + arr[i];
                    prodTotal = prodTotal * arr[i];
                }
            }
            if (sumTotal == prodTotal)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
        private static void SumRows(int col, int row)
        {
            int[] p4FunctionanswerArray = new int[col];
            int[,] p4FuncMatrix = new int[row, col];
            Random rand = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    int p4TempNum = rand.Next(1, 100);
                    p4FuncMatrix[i,j] = p4TempNum;
                    Console.Write(p4FuncMatrix[i, j] + " "); //so you can see the matrix
                    p4FunctionanswerArray[i] = p4FunctionanswerArray[i] + p4TempNum;
                }
                Console.WriteLine();
            }
            Console.Write("Answer for total for each row in an array: ");
            for (int i = 0; i < col; i++)
            {
                Console.Write(p4FunctionanswerArray[i] + " ");
            }
        }
    }
}

/*
Note to self: 
-when submit note this was in console app .netframework and already talked to amanada and i wouldn't lose points for it (because this was just prework).
*/
