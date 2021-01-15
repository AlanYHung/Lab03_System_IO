using System;
using System.IO;

namespace lab03
{
    public class Program
    {
        static void Main(string[] args)
        {
            // labChallengeOneUserInteraction();
            // labChallengeTwoUserInteractionPart1();
            // labChallenge3();
            // Console.WriteLine(labChallenge4(new int[] { 1, 1, 1, 2, 2, 2 }));
            // Console.WriteLine(labChallenge5(new int[] { 1, 1, 66, 2, 200, 2 }));
            // labChallenge6();
            // labChallengeNineUserInteraction();
        }

        public static void labChallengeOneUserInteraction()
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

        public static void labChallengeTwoUserInteractionPart1()
        {
            Console.Write("Please enter a number between 2-10: ");
            string userInput = Console.ReadLine();
            int userInputConverted = Convert.ToInt32(userInput);

            if (userInputConverted < 2 || userInputConverted > 10)
            {
                labChallengeTwoUserInteractionPart1();
            }
            else
            {
                labChallengeTwoUserInteractionPart2(userInputConverted);
            }
        }

        public static void labChallengeTwoUserInteractionPart2(int userLoopNumber)
        {
            decimal[] userNumbersArray = new decimal[userLoopNumber];
            string currentUserNumber;
            decimal currentUserNumberConverted;

            for (int i = 1; i <= userLoopNumber; i++)
            {
                Console.Write($"{i} of {userLoopNumber} - Enter a number: ");
                currentUserNumber = Console.ReadLine();
                currentUserNumberConverted = Convert.ToDecimal(currentUserNumber);

                if (currentUserNumberConverted < 0)
                {
                    Console.WriteLine("Only positive numbers allowed");
                    i--;
                }
                else
                {
                    userNumbersArray[i - 1] = currentUserNumberConverted;
                }
            }

            labChallenge2(userNumbersArray);
        }

        public static decimal labChallenge2(decimal[] userNumArr)
        {
            decimal average = 0;
            decimal countOfNums = userNumArr.Length;

            for(int i = 0; i < countOfNums; i++)
            {
                average += userNumArr[i];
            }

            average = average / countOfNums;
            Console.WriteLine("The average of these {0} numbers is: {1}", countOfNums, average);
            return average;
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
                    if (j <= numberOfSpaces)
                    {
                        finalOutput += space;
                    }
                    else if (j <= numberOfSpaces + numberOfAsterisk)
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
            labChallenge8(path);
        }

        public static void labChallenge8(string path)
        {
            // http://www.blackwasp.co.uk/CountTextFileLines.aspx
            string[] fileContents = File.ReadAllLines(path);
            int numOfLines = fileContents.Length;
            int userInput;

            do
            {
                Console.Write("Which Line would you like to remove? (1-{0})", numOfLines);
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput < 1 || userInput > numOfLines)
                {
                    Console.WriteLine("Need to enter a number between 1-{0}", numOfLines);
                }
            } while (userInput < 1 || userInput > numOfLines);

            // https://stackoverflow.com/questions/2695444/clearing-content-of-text-file-using-c-sharp
            File.WriteAllText(path, String.Empty);

            for(int i = 0; i < numOfLines; i++)
            {
                if(i != userInput - 1)
                {
                    File.AppendAllText(path, fileContents[i] + "\n");
                }
            }
        }

        public static void labChallengeNineUserInteraction()
        {
            string[] userInput;

            Console.WriteLine("Please enter a sentence.");
            userInput = Console.ReadLine().Split(" ");
            labChallenge9(userInput);
        }

        public static string[] labChallenge9(string[] userInput)
        {
            for(int i = 0; i < userInput.Length; i++)
            {
                userInput[i] += ": " + userInput[i].Length;
                Console.WriteLine(userInput[i]);
            }

            return userInput;
        }
    }
}
