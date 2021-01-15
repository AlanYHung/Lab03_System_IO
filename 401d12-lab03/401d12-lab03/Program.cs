using System;
using System.IO;

namespace _401d12_lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            // challengeOneUserInteraction();
            // labChallenge2();
            // labChallenge3();
            // labChallenge4();
            // labChallenge5();
            // labChallenge6();
            // labChallenge7();
            // labChallenge8();
            // labChallenge9();
        }

        public static void challengeOneUserInteraction()
        {
            Console.WriteLine("Please provide 3 numbers");
            string input = Console.ReadLine();
            string[] numbersInput = input.Split(" ");
            Console.WriteLine(labChallenge1(numbersInput));
        }

        public static decimal labChallenge1(string[] numbersInput)
        {
            decimal product = 1;

            try
            {
                if (numbersInput.Length < 3)
                {
                    return 0;
                }
                for (int i = 0; i < 3; i++)
                {
                    decimal numToMult = Convert.ToDecimal(numbersInput[i]);

                    product = product * numToMult;
                }
                return product;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Negative numbers or letters are not valid.\n\nError: {e}");
                return 0;
            }
        }

        public static void labChallenge2()
        {

        }

        public static void labChallenge3()
        {
            char space = ' ';
            char asterisk = '*';
            int numberOfSpaces = 4;
            int numberOfAsterisk = 1;
            string finalOutput;

            for (int i = 1; i < 10; i++)
            {
                finalOutput = "";

                for (int j = 1; j < 10; j++)
                {
                    if (j < numberOfSpaces)
                    {
                        finalOutput += space;
                    }
                    else if (j < numberOfSpaces + numberOfAsterisk)
                    {
                        finalOutput += asterisk;
                    }
                    else
                    {
                        finalOutput += space;
                    }
                }

                if (i < 5)
                {
                    numberOfSpaces--;
                    numberOfAsterisk += 2;
                }
                else
                {
                    numberOfSpaces++;
                    numberOfAsterisk -= 2;
                }

                Console.WriteLine(finalOutput);
            }
        }

        public static int labChallenge4(int[] arr)
        {
            int returnedNumber = 0;
            int count = 0;
            int currentNumber;
            int currentCount;

            for (int i = 0; i < arr.Length; i++)
            {
                currentNumber = arr[i];
                currentCount = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == currentNumber)
                    {
                        currentCount++;
                    }
                }
                if (currentCount > count)
                {
                    returnedNumber = currentNumber;
                    count = currentCount;
                }
            }

            return returnedNumber;
        }

        public static int labChallenge5(int[] arr)
        {
            int highestVal = arr[0];
            
            for (var i = 1; i < arr.Length; i++)
            {
                if (arr[i] > highestVal)
                {
                    highestVal = arr[i];
                }
            }
         
            return highestVal;
        }

        public static void labChallenge6()
        {
            Console.WriteLine("Please enter a word.");
            string input = Console.ReadLine() + "\n";

            string path = "../../../words.txt";
            File.AppendAllText(path, input);
            labChallenge7(path);
        }

        public static void labChallenge7(string path)
        {
            Console.WriteLine(File.ReadAllText(path));
        }

        public static void labChallenge8()
        {

        }

        public static void labChallenge9()
        {

        }
    }
}
