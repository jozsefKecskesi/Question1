using System;
using System.Collections.Generic;
using System.Linq;

namespace Question1
{
    class Question1
    {
        // List for the MultiArrayMatrixSum
        public static List<int> values = new List<int>();

        static void Main()
        {
            AddTwo();
            AmericanFlag();
            ChristmasTree();
            DivideOfTwo();
            SumOfTwo();
            CalculateEasy();
            TimeFromSeconds();
            GrossPayTax();
            ParseNumber();
            TaxCalculatorElseIf();
            CardSwitch();
            DaysSwitch();
            LessThan();
            SimpleCalc();
            TravelAge();
            VoteEgibleAge();
            CoinFlipRandomGuess();
            EvenOrOdd();
            GuessGame();
            RandomMonthSwitch();
            ProductCompare();
            MultiArrayMatrixSum();
            ListNumbersForeach();
            RainfallAveregeRolling();
            UserNumbersReverseList();
            GeneralLoopsAndStuff();
            RawDataSlice();
            MovieList();
            NumberArrayFrequency();

        }
        private static void AddTwo()
        {
            int num1, num2, sumOfTwo;

            Console.WriteLine("Enter a number:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter one more number");
            num2 = int.Parse(Console.ReadLine());

            sumOfTwo = num1 + num2;

            Console.WriteLine("Sum is {0}", sumOfTwo);

            Console.ReadLine();
        }
        private static void AmericanFlag()
        {
            Console.WriteLine("*******---------------\n*******---------------\n*******---------------\n" +
                            "*******---------------\n----------------------\n----------------------");
            Console.ReadLine();
        }
        private static void ChristmasTree()
        {
            Console.WriteLine("    *\n   ***\n  *****\n *******\n*********");
            Console.ReadLine();
        }
        private static void DivideOfTwo()
        {
            double num1, num2, divOfTwo;

            Console.WriteLine("Enter a number:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter one more number");
            num2 = int.Parse(Console.ReadLine());

            divOfTwo = num1 / num2;

            Console.WriteLine("The result is {0}", divOfTwo);

            Console.ReadLine();
        }
        private static void SumOfTwo()
        {
            int num1, num2, sumPlusOne;

            Console.WriteLine("Enter a number:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter one more number:");
            num2 = int.Parse(Console.ReadLine());

            num1 = num1 + 1;

            sumPlusOne = num1 + num2;

            Console.WriteLine("Sum of two number, plus one = {0}", sumPlusOne);

            Console.ReadLine();
        }
        private static void CalculateEasy()
        {
            int a = 1, b = 4, result;

            result = a * b * b;

            Console.WriteLine("Result is {0}", result);

            Console.ReadLine();
        }
        private static void TimeFromSeconds()
        {
            int seconds;

            //prompt the user for the information
            Console.WriteLine("Enter an amount of seconds.");
            seconds = int.Parse(Console.ReadLine());

            TimeSpan CalcTime = TimeSpan.FromSeconds(seconds);

            //displaying infromation
            Console.WriteLine("Time calculated from seconds (hh:mm:ss) = {0}", CalcTime);
            Console.ReadLine();
        }
        private static void GrossPayTax()
        {
            string name;
            int age;
            double grossPay, taxRate, netPay;

            Console.WriteLine("Enter name");
            name = Console.ReadLine();

            Console.WriteLine("Enter age");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter gross pay");
            grossPay = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter tax rate");
            taxRate = double.Parse(Console.ReadLine());

            taxRate = taxRate / 100;

            netPay = grossPay - grossPay * taxRate;

            Console.WriteLine("Name: {0}\nAge: {1}\nGross Pay: {2}\nTax Rate: {3}\nNet Pay: {4}",
                name, age, grossPay, taxRate, netPay);
            Console.ReadLine();
        }
        private static void ParseNumber()
        {
            int var;

            Console.WriteLine("Enter a number");
            var = int.Parse(Console.ReadLine());

            Console.WriteLine("Your number (" + var + ") plus one" +
                " = " + (var + 1));

            Console.ReadLine();
        }
        private static void TaxCalculatorElseIf()
        {
            Console.WriteLine("Tax calculator.");
            Console.WriteLine("Enter your annual wage:");
            int wage = int.Parse(Console.ReadLine());
            int tax;
            int taxRateOne;
            int taxRateHigh;
            int rateOne;
            int rateHigh;

            if (wage <= 10000)
            {
                Console.WriteLine("You do not have to pay any tax, as you earn 10.000 or less.");
            }
            else if (wage >= 10001 && wage <= 50000)
            {
                taxRateOne = 20;
                rateOne = wage - 10000;
                tax = (rateOne / 100) * taxRateOne;
                Console.WriteLine("Your tax (over 10.000) is {0}%, {1}$ for a year.", taxRateOne, tax);
            }
            else if (wage >= 50001)
            {
                taxRateOne = 20;
                taxRateHigh = 40;
                rateOne = wage - 10000;
                rateHigh = wage - 50000;
                tax = ((rateOne / 100) * taxRateOne) + ((rateHigh / 100) * taxRateHigh);
                Console.WriteLine("Your tax over 10.000 income is {0}% and over 50000 is {1}%, altogether = {2}$ for a year.", taxRateOne, taxRateHigh, tax);
            }
            else
            {
                Console.WriteLine("Something went wrong...");
            }

            Console.ReadLine();
        }
        private static void CardSwitch()
        {
            int card;

            Console.WriteLine("Enter a number between 1 and 4.");
            card = int.Parse(Console.ReadLine());


            switch (card)
            {
                case 1:
                    Console.WriteLine("Hearts");
                    break;

                case 2:
                    Console.WriteLine("Clubs");
                    break;

                case 3:
                    Console.WriteLine("Diamonds");
                    break;

                case 4:
                    Console.WriteLine("Spades");
                    break;

                default:
                    Console.WriteLine("Something went wrong.");
                    break;
            }

            Console.ReadLine();
        }
        private static void DaysSwitch()
        {
            int days;

            Console.WriteLine("Enter a number between 1 and 7 to determine the day of the week.");
            days = int.Parse(Console.ReadLine());


            switch (days)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("Something went wrong.");
                    break;
            }

            Console.ReadLine();
        }
        private static void LessThan()
        {
            Console.WriteLine("Which number is greater?");
            Console.WriteLine("Enter a value for the number A:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for the number B:");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Number A is greater than B.");
            }
            else if (b > a)
            {
                Console.WriteLine("Number B is greater than A.");
            }
            else if (a == b)
            {
                Console.WriteLine("Both numbers are equal.");
            }
            else
            {
                Console.WriteLine("Something went wrong.");
            }

            Console.ReadLine();
        }
        private static void SimpleCalc()
        {
            Console.WriteLine("Welcome to the SimpleCalc " +
                           "\nPress 1 to add two numbers " +
                           "\nPress 2 to substract two numbers " +
                           "\nPress 3 to divide two numbers " +
                           "\nPress 4 to multiple two numbers");

            int chosen = int.Parse(Console.ReadLine());

            Console.WriteLine("Now, enter two number one by one.");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            switch (chosen)
            {
                case 1:
                    Console.WriteLine(num1 + num2);
                    break;

                case 2:
                    Console.WriteLine(num1 - num2);
                    break;

                case 3:
                    Console.WriteLine(num1 / num2);
                    break;

                case 4:
                    Console.WriteLine(num1 * num2);
                    break;

                default:
                    Console.WriteLine("Something went wrong.");
                    break;
            }

            Console.ReadLine();
        }
        private static void TravelAge()
        {
            Console.WriteLine("We offer travel services customers age between 18 and 30?");
            Console.WriteLine("Enter Your age, Please:");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18 && age <= 30)
            {
                Console.WriteLine("You can use our Travel services.");
            }
            else
            {
                Console.WriteLine("Unfortunately you cannot use our services.");
            }

            Console.ReadLine();
        }
        private static void VoteEgibleAge()
        {
            Console.WriteLine("Are you egible to vote?");
            Console.WriteLine("Enter Your age:");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are egible to vote.");
            }
            else
            {
                Console.WriteLine("You cannot vote.");
            }

            Console.ReadLine();
        }
        private static void CoinFlipRandomGuess()
        {
            Random random = new Random();

            int coinFlip = random.Next(0, 1);

            Console.WriteLine("I flipped a coin, guess if it is head or tail and write down your answer just in one word");

            string userGuess = Console.ReadLine();
            string userGuessLowerCase = userGuess.ToLower();

            if (coinFlip == 0 && userGuessLowerCase == "head" || coinFlip == 1 && userGuessLowerCase == "tail")
            {
                Console.WriteLine("\n\n\n***\nYour bet was right\n***");
            }
            else if (coinFlip != 0 && userGuessLowerCase == "head" || coinFlip != 1 && userGuessLowerCase == "tail")
            {
                Console.WriteLine("\n\n\n***\nNot a winner, better luck next time\n***");
            }
            else
            {
                Console.WriteLine("\n\n\n***\nMake sure you enter only HEAD or Tail as an answer next time!\n***");
            }
            Console.ReadLine();
        }
        private static void TrianglePerimeter()
        {
            Console.WriteLine("Triangle perimeter calculator. Please enter the lenght of three edges one by one.");
            double edgeOne = double.Parse(Console.ReadLine());
            double edgeTwo = double.Parse(Console.ReadLine());
            double edgeThree = double.Parse(Console.ReadLine());

            if (edgeOne + edgeTwo > edgeThree && edgeOne + edgeThree > edgeTwo && edgeTwo + edgeThree > edgeOne)
            {
                Console.WriteLine("The perimeter is: " + (edgeOne + edgeTwo + edgeThree));
            }
            else
            {
                Console.WriteLine("The input is invalid.");
            }

            Console.ReadLine();
        }
        private static void EvenOrOdd()
        {
            int userNum;

            Console.WriteLine("Please enter a number between 0 and 1000.");
            userNum = int.Parse(Console.ReadLine());

            if (userNum > 1000 || userNum < 1)
            {
                Console.WriteLine("You entered an invalid number.");
            }
            else
            {
                if (userNum % 2 == 0)
                {
                    Console.WriteLine("Number is even");
                }
                else
                {
                    Console.WriteLine("Number is odd");
                }
            }

            Console.ReadLine();
        }
        private static void GuessGame()
        {
            Random random = new Random();

            int numberToGuess = random.Next(0, 20);
            Console.WriteLine("I am thinking of a number between 0 and 20.  Can you guess what it is?");


            int userGuess = 0;
            while (userGuess != numberToGuess)
            {
                userGuess = int.Parse(Console.ReadLine());

                if (userGuess > 20 || userGuess < 0)
                {
                    Console.WriteLine("Guess between 0 and 20!");
                }
                else if (userGuess < numberToGuess)
                {
                    Console.WriteLine("No, the number I am thinking of is higher than " + userGuess + ". Can you guess what it is?");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("No, the number I am thinking of is lower than " + userGuess + ". Can you guess what it is?");
                }

            }

            Console.WriteLine("Well done! The answer was " + numberToGuess);
            Console.ReadLine();
        }
        private static void RandomMonthSwitch()
        {
            Random random = new Random();

            int monthNum = random.Next(1, 12);

            switch (monthNum)
            {

                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("Julay");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Something went wrong, no month to display!");
                    break;
            }
            Console.ReadLine();
        }
        private static void ProductCompare()
        {
            Console.WriteLine("Please enter the price of the first package of rice.");
            double priceOne = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the weight of the first package of rice.");
            double weightOne = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the price of the second package of rice.");
            double priceTwo = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the weight of the second package of rice.");
            double weightTwo = double.Parse(Console.ReadLine());

            if (priceOne / weightOne == priceTwo / weightTwo)
            {
                Console.WriteLine("\n\n***\nThe two package have the same value.\n***");
            }
            else
            {
                if (priceOne / weightOne < priceTwo / weightTwo)
                {
                    Console.WriteLine("\n\n***\nThe second item has more value based on weight and price.\n***");
                }
                else
                {
                    Console.WriteLine("\n\n***\nThe second item has more value based on weight and price.\n***");
                }
            }

            Console.ReadLine();
        }
        private static void MultiArrayMatrixSum()
        {
            //in clas level!: public static List<int> values = new List<int>();
            int[,] multiArray = new int[4, 4]
            {
                {1, 2, 4, 5},
                {6, 7, 8, 9},
                {10, 11, 12, 13},
                {14, 15, 16, 17}
            };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    values.Add(multiArray[i, j]);
                    Console.WriteLine(multiArray[i, j]);
                }

            }

            int total = values.Sum();
            Console.WriteLine("\n\nThe sum of the listed numbers is: {0} ", total);
            Console.ReadLine();
        }
        private static void ListNumbersForeach()
        {
            Console.WriteLine("Generate numbers 1 - 10. \n\n ");

            var numbersArray = new int[10];

            Console.WriteLine("Now save them in an  array, there are what numbers saved to the array: \n\n");

            for (var i = 1; i <= 10; i++)
            {
                numbersArray[i - 1] = i;
                Console.WriteLine(i);
            }

            Console.WriteLine("\n\nFinally list the numbers from the array itself: \n\n");

            foreach (var item in numbersArray)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }
        private static void RainfallAveregeRolling()
        {
            Console.WriteLine("Enter Rainfall data, Please - Month by mont begin with January.");

            string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            decimal[] userInputs = new decimal[12];

            for (int i = 0; i < userInputs.Length; i++)
            {
                Console.WriteLine(months[i]);
                userInputs[i] = Decimal.Parse(Console.ReadLine());
                decimal userInputsAverage = Math.Round(userInputs.Sum() / (i + 1), 2);
                //string[] numberOfMonths = { i.ToString() };
                //string[] userEntered = { userInputs.ToString() };

                if (i == 11)
                {
                    Console.WriteLine("The yearly average rainfall up to date is {0}. Se thee data in chart below. \n", userInputsAverage);

                    for (i = 0; i < 12; i++)
                    {
                        Console.WriteLine("Month: {0} - Rainfall: {1} \n", months[i], userInputs[i]);
                    }

                }
                else
                {
                    Console.WriteLine("The average rainfall up to date is {0}. Please enter next month's data!", userInputsAverage);

                }

            }

            Console.ReadLine();
        }
        private static void UserNumbersReverseList()
        {
            Console.WriteLine("Enter 5 numbers, Please - one by one.");

            string[] userInputs = new string[5];
            for (int i = 0; i < userInputs.Length; i++)
            {
                userInputs[i] = Console.ReadLine();
            }

            string[] userInpRev = new string[5];

            int j = 0;

            for (int i = userInputs.Length - 1; i >= 0; i--)
            {
                userInpRev[j] = userInputs[i];
                j++;
            }

            Console.WriteLine("\n***\nNow here are your numbers in reversed orders: \n***\n");

            foreach (var item in userInpRev)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }
        private static void GeneralLoopsAndStuff()
        {
            //Foreach
            string[] books = { "Databases", "Economics", "Law" };
            foreach (string x in books)
            {
                Console.WriteLine("Book is : " + x);
            }
            Console.ReadLine();

            //ForLoop
            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine("x is : " + x);

                if (x == 5)
                {
                    break;
                }
            }
            Console.ReadLine();

            //ElseIf
            Console.WriteLine("Enter a value for a");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("a is greater than b");
            }
            else if (b > a)
            {
                Console.WriteLine("b is greater than a");
            }
            else if (a == b)
            {
                Console.WriteLine("Both are equal");
            }
            else
            {
                Console.WriteLine("Not sure...");
            }
            Console.ReadLine();

            //Switch
            string book;

            Console.WriteLine("Enter Book Type");
            book = Console.ReadLine();


            switch (book.ToLower())
            {
                case "economics":
                    Console.WriteLine("Price is €50");
                    break;

                case "law":
                    Console.WriteLine("Price is €100");
                    break;

                default:
                    Console.WriteLine("We don't have this book!!");
                    break;
            }
            Console.ReadLine();

            //WhileLoop

            //int books = 5;

            //while(books > 0)
            //{
            //    Console.WriteLine("There are " + books + " left");
            //    books--;
            //}
            //Console.WriteLine("There are no books left!!!");

            Console.WriteLine("Enter movie name");
            string movie = Console.ReadLine();            

            while (movie.ToLower() != "exit")
            {
                Console.WriteLine("You chose movie : " + movie);

                Console.WriteLine("Enter movie name");
                movie = Console.ReadLine();
            }
            Console.WriteLine("You are exiting");
            Console.ReadLine();

            //Enum should be declaes in namespace level!

            //enum Priority
            //{
            //   Critical = 11,
            //   High = 2,
            //   Medium = 3,
            //   Low = 4
            //};

            //enum DaysOfTheWeek
            //{
            //   Monday,
            //   Tuesday
            //}

            //1 Single Dimensional Arrays - Declaring
            //int[] intArray = { 1, 2, 3, 4, 5 };

            //int[] intArray2 = new int[5];
            //intArray2[0] = 1;
            //intArray2[1] = 2;
            //intArray2[2] = 3;
            //intArray2[3] = 4;
            //intArray2[4] = 5;

            ////Iterating an Array
            //for(int i = 0; i<intArray2.Length; i++)
            //{
            //    Console.WriteLine("Array value at index {0} is : {1}", i, intArray2[i]);
            //}

            //foreach(int x in intArray2)
            //{
            //    Console.WriteLine(x);
            //}


            ////2 Resizing an array
            //Array.Resize(ref intArray2, 7);
            //intArray2[5] = 6;
            //intArray2[6] = 7;

            //for (int i = 0; i < intArray2.Length; i++)
            //{
            //    Console.WriteLine("Array value at index {0} is : {1}", i, intArray2[i]);
            //}


            ////3 Sort Arrays

            //Array.Sort(intArray2);

            //for (int i = 0; i < intArray2.Length; i++)
            //{
            //    Console.WriteLine("Array value at index {0} is : {1}", i, intArray2[i]);
            //}

            //Array.Reverse(intArray2);


            //for (int i = 0; i < intArray2.Length; i++)
            //{
            //    Console.WriteLine("Array value at index {0} is : {1}", i, intArray2[i]);
            //}



            //4 Multidimensional Arrays
            int[,] multiArray = new int[3, 4]
            {
                {0, 1, 2, 3},
                {4, 5, 6, 7},
                {8, 9, 10, 11}
            };

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j < 4; i++)
                {
                    Console.WriteLine(multiArray[i, j]);
                }

            }


            //Console.WriteLine("DEFECT TRACKER");
            //Console.WriteLine("11 - Critical");
            //Console.WriteLine("2 - High");
            //Console.WriteLine("3 - Medium");
            //Console.WriteLine("4 - Low");

            //int defectStatus = int.Parse(Console.ReadLine());

            //if(defectStatus == (int)Priority.Critical)
            //{


            //}

            //switch(defectStatus)
            //{
            //    case (int)Priority.Critical:
            //        Console.WriteLine("Critical Defect");
            //        break;
            //    case (int)Priority.High:
            //        Console.WriteLine("High Defect");
            //        break;
            //    default:
            //        Console.WriteLine("Uknown status");
            //        break;
            //}



            Console.ReadLine();
        }
        private static void RawDataSlice()
        {
            // Setting up variables
            string rawData = " ";
            string delim = " ";
            // Collecting raw data - text - from the user
            Console.WriteLine("Please enter the data row:");
            rawData = Console.ReadLine();
            // A quick check if the entry is not empty
            while (rawData.Length <= 2)
            {
                Console.WriteLine("Enter some raw data Please!");
                rawData = Console.ReadLine();
            }
            // Collecting the delimiter type
            Console.WriteLine("Please enter the delimiter:");
            delim = Console.ReadLine();
            // Check if the user provided delimiter and that actually exists in the raw data
            while (delim.Length < 1 || rawData.Contains(delim) == false)
            {
                Console.WriteLine("Enter the correct delimiter Please!");
                delim = Console.ReadLine();
            }
            // Replace the delimiters and print out the data line by line
            rawData = rawData.Replace(delim, "\n");
            Console.WriteLine(rawData);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
        private static void MovieList()
        {
            // Setting up the array
            string[] movies;
            // Welcome message
            Console.WriteLine("####################################\n" +
                                "WELCOME TO THE DBS CONSOLE\n" +
                                "####################################\n\n" +
                                "Enter Number of movies : ");
            // Check if the first user entry is number - if it is not the logic won't work
            try
            {
                // Collecting the amount of movie names from the user and validate                
                var numberOfMovies = int.Parse(Console.ReadLine());
                if (numberOfMovies < 0)
                {
                    Console.Write("You must enter a positive number.");
                }
                // If the validation passed adding the entries to the array via a loop
                else
                {
                    movies = new string[numberOfMovies];
                    for (int i = 0; i < numberOfMovies; i++)
                    {
                        Console.Write("Enter Movie Name:\n");
                        string tempMovie = Console.ReadLine();
                        // If the user entry is exit finish the loop - do not collect the rest movie names
                        if (tempMovie.ToUpper() == "EXIT")
                        {
                            break;
                        }
                        else
                        {
                            // If all validations passed and not exit, adding the new array record here
                            movies[i] = tempMovie;
                        }
                    }
                    // Filter out the empty arrays if there are any
                    Console.WriteLine("\n");
                    movies = movies.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    // List the movies
                    for (int x = 1; x < movies.Length + 1; x++)
                    {
                        Console.WriteLine("Movie {0} is {1}.", x, movies[x - 1]);
                    }
                    Console.ReadLine();
                }
            }
            // If the first user entry is not a number restart the process
            catch (FormatException)
            {
                Console.Write("You must enter a whole number.");
                Console.ReadLine();
                Main();
            }
        }
        private static void NumberArrayFrequency()
        {
            // Setting up the array - number elements
            int[] elements;
            // Print out welcome message and asking the numbers of entries
            Console.WriteLine("####################################\n" +
                                "WELCOME TO THE DBS CONSOLE\n" +
                                "####################################\n\n" +
                                "Input the number of elements to be stored in the array:");
            // Validate if the entry is a number
            try
            {
                // Collect the entry and check for positive number
                var numberOfElements = int.Parse(Console.ReadLine());
                if (numberOfElements < 0)
                {
                    Console.Write("You must enter a positive number.");
                }
                else
                {
                    // Adding the user entries to the array via a loop
                    elements = new int[numberOfElements];
                    for (int i = 0; i < numberOfElements; i++)
                    {
                        Console.Write("element - {0} : ", i);
                        try
                        {
                            var elementsPortions = int.Parse(Console.ReadLine());
                            elements[i] = elementsPortions;
                        }
                        // If the entry is not a number restart the process
                        catch (FormatException)
                        {
                            Console.Write("You must enter a whole number.");
                            Console.ReadLine();
                            Main();
                        }
                    }
                    // Create a list from the array and calculate how many
                    // times each element occurs in the list
                    Console.WriteLine("\nThe frequency of all elements of the aray :");
                    List<int> myArraysList = elements.ToList();
                    Dictionary<int, int> myDict = new Dictionary<int, int>();
                    foreach (int i in myArraysList)
                    {
                        if (myDict.ContainsKey(i))
                        {
                            int value = myDict[i];
                            value++;
                            myDict[i] = value;
                        }
                        else
                        {
                            myDict.Add(i, 1);
                        }
                    }
                    // Print out the results via a loop
                    for (int x = 0; x < myDict.Count(); x++)
                    {
                        Console.WriteLine("Number {0} occurs {1} times", myDict.Keys.ElementAt(x), myDict[myDict.Keys.ElementAt(x)]);
                    }
                    Console.ReadLine();
                }
            }
            // Restart the process if the first entry is not a number
            catch (FormatException)
            {
                Console.Write("You must enter a whole number.");
                Console.ReadLine();
                Main();
            }
        }
    }
}
