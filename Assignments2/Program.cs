using System;

namespace Assignments2
{
    class Assignments2
    {
        static void Main(string[] args)
        {
            ConeVolume();
        }
        static void DR2()
        {
            Console.Write(" Desired sum of 2 dice rolls: ");
            int sum = Convert.ToInt32(Console.ReadLine());
            if (sum < 2)
            {
                Console.WriteLine("Sum needs to be greater than 2.");
                return;
            }
            else if (sum > 12)
            {
                Console.WriteLine("Sum needs to be less than 12.");
                return;
            }
            else
            {
                Random random = new Random();
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                Console.WriteLine("First dice roll is {0}, second dice roll is {1}. Their sum is {2}.", dice1, dice2, dice1 + dice2);
                if (sum == dice1 + dice2)
                {
                    Console.WriteLine("Congrats you guessed correct!");

                }
                else
                {
                    Console.WriteLine("Better luck next time! ");
                }
            }
        }
        static void WashMachine()
        {
            Console.WriteLine("Pick a programme:");
            int programme = Convert.ToInt32(Console.ReadLine());
            int temperature = 0;
            int time = 0;
            switch (programme)
            {
                case 1:
                    Console.WriteLine("Temperature: {0}, Time: {1}", temperature = 60, time = 125);
                    break;
                case 2:
                    Console.WriteLine("Temperature: {0}, Time: {1}", temperature = 90, time = 106);
                    break;
                case 3:
                    Console.WriteLine("Temperature: {0}, Time: {1}", temperature = 40, time = 98);
                    break;
                case 4:
                    Console.WriteLine("Temperature: {0}, Time: {1}", temperature = 50, time = 65);
                    break;
                case 5:
                    Console.Write("Desired temperature: ");
                    temperature = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Desired time: ");
                    time = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Temperature: {0}, Time: {1}", temperature, time);
                    break;
                default:
                    Console.WriteLine("No such programme.");
                    break;
            }
        }
        static void Temperatures()
        {
            Console.Write("Temperature: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unit: ");
            int unit = Convert.ToInt32(Console.ReadLine());
            double celsium;
            double kelvin;
            double fah;
            switch (unit)
            {
                case 1:
                    fah = ((9 * temp) / 5) + 32;
                    kelvin = temp + 273.15;
                    Console.WriteLine("Fahrenheit: {0} \n Kelvin: {1}", fah, kelvin);
                    break;
                case 2:
                    celsium = (5 / 9) * (temp - 32);
                    kelvin = celsium + 273.15;
                    Console.WriteLine("Celsium: {0} \n Kelvin: {1}", celsium, kelvin);
                    break;
                case 3:
                    celsium = temp - 273.15;
                    fah = (9 / 5) * celsium + 32;
                    Console.WriteLine("Fahrenheit: {0} \n Celsium: {1}", fah, celsium);
                    break;
                default:
                    Console.WriteLine("Unsupported unit");
                    break;
            }

        }
        static void Excel()
        {
            Console.WriteLine("x? ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y? ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("z? ");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pick a function: ");
            string fucntion = Console.ReadLine();
            switch (fucntion)
            {
                case "SUM":
                    double sum = z + y + x;
                    Console.WriteLine("SUM of the three numbers is: {0}", sum.ToString("N4"));
                    break;
                case "AVERAGE":
                    double average = (z + y + x) / 3;
                    Console.WriteLine("AVERAGE of the three numbers is: {0}", average.ToString("N4"));
                    break;
                case "MIN":
                    double min = Math.Min(x, Math.Min(y, z));
                    Console.WriteLine("MIN of the three numbers is: {0}", min);
                    break;
                case "MAX":
                    double max = Math.Max(x, Math.Max(y, z));
                    Console.WriteLine("MAX of the three numbers is: {0}", max);
                    break;
                default:
                    Console.WriteLine("Unsupported function");
                    break;

            }
        }
        static void CoffeeMachine()
        {
            Console.Write("Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Short espresso 0.50 \nLong espresso 0.60 \nCappuccino 0.85 \nCoffee with milk 0.90 \nCoffeine-free 0.60");
            Console.WriteLine("Your choice: ");
            int userPick = Convert.ToInt32(Console.ReadLine());
            switch (userPick)
            {
                case 1:
                    if (amount < 0.50)
                    {
                        Console.WriteLine("Not enough money.");
                        return;
                    }
                    else if (amount == 0.50)
                    {
                        Console.WriteLine("Preparing your drink...");
                    }
                    else
                    {
                        Console.WriteLine("Preparing your drink...");
                        Console.WriteLine("Change: {0}", amount - 0.50);
                    }
                    break;
                case 2:
                    if (amount < 0.60)
                    {
                        Console.WriteLine("Not enough money.");
                        return;
                    }
                    else if (amount == 0.60)
                    {
                        Console.WriteLine("Preparing your drink...");
                    }
                    else
                    {
                        Console.WriteLine("Preparing your drink...");
                        Console.WriteLine("Change: {0}", amount - 0.60);
                    }
                    break;
                case 3:
                    if (amount < 0.85)
                    {
                        Console.WriteLine("Not enough money.");
                        return;
                    }
                    else if (amount == 0.85)
                    {
                        Console.WriteLine("Preparing your drink...");
                    }
                    else
                    {
                        Console.WriteLine("Preparing your drink...");
                        Console.WriteLine("Change: {0}", amount - 0.85);
                    }
                    break;
                case 4:
                    if (amount < 0.90)
                    {
                        Console.WriteLine("Not enough money.");
                        return;
                    }
                    else if (amount == 0.90)
                    {
                        Console.WriteLine("Preparing your drink...");
                    }
                    else
                    {
                        Console.WriteLine("Preparing your drink...");
                        Console.WriteLine("Change: {0}", amount - 0.90);
                    }
                    break;
                case 5:
                    if (amount < 0.50)
                    {
                        Console.WriteLine("Not enough money.");
                        return;
                    }
                    else if (amount == 0.50)
                    {
                        Console.WriteLine("Preparing your drink...");
                    }
                    else
                    {
                        Console.WriteLine("Preparing your drink...");
                        Console.WriteLine("Change: {0}", amount - 0.50);
                    }
                    break;
                case 6:
                    if (amount < 0.60)
                    {
                        Console.WriteLine("Not enough money.");
                        return;
                    }
                    else if (amount == 0.60)
                    {
                        Console.WriteLine("Preparing your drink...");
                    }
                    else
                    {
                        Console.WriteLine("Preparing your drink...");
                        Console.WriteLine("Change: {0}", amount - 0.60);
                    }
                    break;
                default:
                    Console.WriteLine("Please select from the menu.");
                    break;
            }
        }
        static void WorldMap()
        {
            Console.Write("Longtitude 1: ");
            double longti1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Longtitude 2: ");
            double longti2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Latitude 1: ");
            double lati1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Latitude 2: ");
            double lati2 = Convert.ToDouble(Console.ReadLine());

            double latDiff = lati2 - lati1;
            double longDiff = longti2 - longti1;

            string direction = "";

            if (latDiff > 0)
            {
                direction += "NORTH";
            }
            else if (latDiff < 0)
            {
                direction += "SOUTH";
            }
            if (longDiff > 0)
            {
                direction += "EAST";
            }
            else if (longDiff < 0)
            {
                direction += "WEST";
            }
            if (direction == "")
            {
                Console.WriteLine("This is the same place");
            }
            else
            {
                Console.WriteLine("The direction is: " + direction);
            }

        }
        static void SumIfLarger()
        {
            int sum = 0;
            int previous = 0;
            int current = 0;
            while (previous <= current)
            {
                previous = current;
                sum += previous;
                current = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The sum is:{0}", sum);
        }
        static void Fibonacci()
        {
            Console.WriteLine("Limit: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            int prev1 = 0;
            int prev2 = 1;
            int current = 0;
            Console.WriteLine(prev1);
            Console.WriteLine(prev2);
            for (int i = 2; i < limit; i++)
            {
                current = prev1 + prev2;
                Console.WriteLine(current);
                prev1 = prev2;
                prev2 = current;

            }
        }
        static void ConeVolumeLoop()
        {
            Console.Write("Max Height: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.Write("Max Radius: ");
            int r = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    double v = (Math.PI * Math.Pow(j, 2) * i) / 3;
                    Console.WriteLine("Height: {0}, Radius: {1}", i, j);
                    Console.WriteLine("Volume: {0}", v.ToString("N2"));
                }
            }
        }
        static void QuadraticEquationsLoop()
        {
            Console.Write("Limit: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= limit; i++)
            {
                for (int j = 1; j <= limit; j++)
                {
                    for (int k = 1; k <= limit; k++)
                    {

                        Console.WriteLine("a = {0}, b = {1}, c = {2}", i, j, k);
                        double d = Math.Pow(j, 2) - 4 * i * k;
                        if (d > 0)
                        {
                            double x1 = (-j + Math.Sqrt(d)) / (2 * i);
                            double x2 = (-j - Math.Sqrt(d)) / (2 * i);
                            Console.WriteLine("x1 = {0}", x1);
                            Console.WriteLine("x2 = {0}", x2);
                        }
                        else
                        {
                            Console.WriteLine("No solution.");
                        }

                    }
                }
            }
        }
        static void Capital()
        {
            Console.WriteLine("How many days?");
            int days = Convert.ToInt32(Console.ReadLine());
            double[] price = new double[days];

            for (int i = 0; i < days; i++)
            {
                Console.WriteLine("Day{0}: ", i + 1);
                price[i] = Convert.ToDouble(Console.ReadLine());

            }
            double diff = 0;
            for (int i = 1; i < days; i++)
            {
                diff = price[i] - price[i - 1];
                if (diff > 0)
                {
                    Console.WriteLine("UP with {0}", diff.ToString("N4"));
                }
                else if (diff < 0)
                {
                    Console.WriteLine("DOWN with {0}", diff.ToString("N4"));
                }
                else if (diff == 0)
                {
                    Console.WriteLine("Not changed");
                }
            }
            double total = 0;
            for (int i = 0; i <= days - 1; i++)
            {
                total = +price[i];
            }
            double average = total / days;
            Console.WriteLine("The average is:{0}", average);

        }
        static void Unique()
        {
            Console.WriteLine("How many numbers? ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[num];
            for (int i = 0; i < num; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                    continue;
                for (int j = i + 1; j < num; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        Console.WriteLine("Dublicate found! ");
                        numbers[j] = 0;
                    }
                }
            }
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(numbers[i] + " ");
            }

        }
        static void Filter()
        {
            Console.WriteLine("How many numbers? ");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please write {0} numbers:", count);
            double[] num = new double[count];
            for (int i = 0; i < count; i++)
            {
                num[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Operation(>, < or =): ");
            char operation = Convert.ToChar(Console.ReadLine());
            Console.Write("Than: ");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case '>':
                    for (int i = 0; i < count; i++)
                    {
                        if (num[i] > number)
                        {
                            Console.WriteLine(num[i]);
                        }
                    }
                    break;
                case '<':
                    for (int i = 0; i < count; i++)
                    {
                        if (num[i] < number)
                        {
                            Console.WriteLine(num[i]);
                        }
                    }
                    break;
                case '=':
                    for (int i = 0; i < count; i++)
                    {
                        if (num[i] == number)
                        {
                            Console.WriteLine(num[i]);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Unsupported operation");
                    break;
            }
        }
        static void MatrixVertical()
        {
            Console.Write("Columns: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Rows: ");
            int r = Convert.ToInt32(Console.ReadLine());

            for (int j = 1; j <= c; j++)
            {
                for (int i = 1; i <= r; i++)
                {
                    Console.Write((i - 1) * c + j + " ");
                }
                Console.WriteLine();
            }
        }
        static void MatrixHorizontal()
        {
            Console.Write("Columns: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Rows: ");
            int r = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= c; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    Console.Write((i - 1) * c + j + " ");
                }
                Console.WriteLine();
            }
        }
        static void BubbleSort2()
        {
            Console.Write("Word: ");
            string word = Console.ReadLine();
            char[] wordd = word.ToCharArray();
            Array.Sort(wordd);
            wordd.ToString();
            Console.Write(wordd);
        }
        static void ArrayCompare()
        {
            Console.Write("How many in first array ? ");
            int arr1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many in second array ? ");
            int arr2 = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[arr1];
            for (int i = 0; i < arr1; i++)
            {
                Console.WriteLine("1st array number: ");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] array2 = new int[arr2];
            for (int i = 0; i < arr2; i++)
            {
                Console.WriteLine("2st array number: ");
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] arrayMatch = new int[arr1];
            for (int i = 0; i < arr1; i++)
            {
                for (int j = 0; j < arr2; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        Console.WriteLine("Match: {0}", array1[i]);
                        arrayMatch[i] = array1[i];
                    }
                }
            }
        }
        static void MatrixHorizontall()
        {
            Console.WriteLine("Columns: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rows: ");
            int r = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= c; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    Console.Write((i - 1) * c + j + " ");
                }
                Console.WriteLine();
            }
        }
        static void MatrixDiagonal()
        {
            Console.WriteLine("Enter the size of the square matrix: ");
            int size = Convert.ToInt32(Console.ReadLine());

            char[][] matrix = new char[size][];
            for (int i = 0; i < size; i++)
            {
                matrix[i] = new char[size];
            }
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (row == col || col == size - row - 1)
                    {
                        matrix[row][col] = 'X';
                    }
                    else if (col == row)
                    {
                        matrix[row][col] = 'Y';
                    }
                    else
                    {
                        matrix[row][col] = '-';
                    }
                }
            }
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
        static void ReverseWord()
        {
            Console.WriteLine("Word to reverse: ");
            string word = Console.ReadLine();
            char[] reverseWord = word.ToCharArray();
            Array.Reverse(reverseWord);
            string reversedWord = new string(reverseWord);
            Console.WriteLine(reversedWord);
        }
        static void Excel3()
        {
            int[] numbers = new int[5];
            int count = 0;
            int sum = 0;
            int min;
            int max;
            Console.WriteLine("Enter positive numbers. To finish, enter a negative number.");
            while (true)
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number < 0)
                    break;

                if (count == numbers.Length)
                {
                    Array.Resize(ref numbers, numbers.Length * 2);
                }
                numbers[count] = number;
                count++;
                sum += number;


            }
            min = numbers[0];
            for (int i = 1; i < count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            max = numbers[0];
            for (int i = 1; i < count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            double average = count > 0 ? (double)sum / count : 0;
            Console.WriteLine("SUM={0}, AVERAGE={1:F2}, COUNT={2}, MIN={3}, MAX={4}", sum, average, count, min, max);
        }
        static void ArrayCompare2()
        {
            Console.WriteLine("How many numbers in first array? ");
            int array1Size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many numbers in second array? ");
            int array2Size = Convert.ToInt32(Console.ReadLine());

            double[] array1 = new double[array1Size];
            string[] array2 = new string[array2Size];

            for (int i = 0; i < array1Size; i++)
            {
                Console.WriteLine("1st array number: ");
                array1[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < array2Size; i++)
            {
                Console.WriteLine("2st array number: ");
                array2[i] = Console.ReadLine();
            }

            for (int i = 0; i < array1Size; i++)
            {
                for (int j = 0; j < array2Size; j++)
                {
                    int x = Convert.ToInt32(array1[i]);
                    int y = Convert.ToInt32(array2[j]);

                    if (x == y)
                    {

                        Console.Write("Match:{0}", x);

                    }
                }
            }
        }
        static void Fibbonaccii()
        {
            Console.WriteLine("How many numbers: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int prev1 = 0;
            int prev2 = 1;
            Console.WriteLine(prev1);
            Console.WriteLine(prev2);
            int current = 0;
            for (int i = 2; i < num; i++)
            {
                current = prev2 + prev1;
                Console.WriteLine(current);
                prev1 = prev2;
                prev2 = current;
            }
        }
        static void BubbleSort3()
        {
            Console.WriteLine("Sentence: ");
            string sentance = Console.ReadLine();

            string[] words = sentance.Split(' ');
            Array.Sort(words);
            Console.WriteLine("Sorted words:");
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
        }
        static void SentenceCompare()
        {
            Console.Write("Sentance one: ");
            string sen1 = Console.ReadLine();
            string[] words1 = sen1.Split(' ');

            Console.Write("Sentance two: ");
            string sen2 = Console.ReadLine();
            string[] words2 = sen2.Split(' ');

            Console.Write("Sentance three: ");
            string sen3 = Console.ReadLine();
            string[] words3 = sen3.Split(' ');

            bool matchFound = false;

            for (int i = 0; i < words1.Length; i++)
            {
                for (int j = 0; j < words2.Length; j++)
                {
                    for (int k = 0; k < words3.Length; k++)
                    {
                        if (words1[i] == words2[j] && words2[j] == words3[k])
                        {
                            Console.WriteLine("The word {0} is in the three sentances.", words1[i]);
                            matchFound = true;
                        }

                    }
                }
            }
            if (!matchFound)
            {
                Console.WriteLine("No match");
            }

        }
        static void DigitNames()
        {
            Console.Write("Numbers: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string[] numbers = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "zero" };

            string numStr = num.ToString();
            int[] digits = new int[numStr.Length];
            for (int i = 0; i < numStr.Length; i++)
            {
                digits[i] = Convert.ToInt32(numStr[i].ToString());
            }
            for (int i = 0; i < digits.Length; i++)
            {
                switch (digits[i])
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                    case 0:
                        Console.WriteLine("zero");
                        break;
                    default:
                        Console.WriteLine("Please write number.");
                        break;
                }
            }
        }
        static void NoRepeat()
        {
            string[] words = new string[1];
            int currentIndex = 0;

            Console.WriteLine("Enter words (type '.' to finish):");

            while (true)
            {
                Console.WriteLine("Enter a word: ");
                string input = Console.ReadLine();

                if (input == ".")
                    break;
                bool wordExists = false;
                for (int i = 0; i < currentIndex; i++)
                {
                    if (words[i] != null && words[i].ToLower() == input.ToLower())
                    {
                        wordExists = true;
                        break;
                    }

                }
                if (wordExists)
                {
                    Console.WriteLine("The word already exists.");
                }
                else
                {
                    if (currentIndex >= words.Length)
                    {
                        Array.Resize(ref words, words.Length * 2);
                    }
                    words[currentIndex] = input;
                    currentIndex++;
                }

            }
            Console.WriteLine("Uniquie words: ");
            for (int i = 0; i < words.Length; i++)
            {

                Console.WriteLine(words[i]);


            }
        }
        static void ReverseSentance()
        {
            Console.Write("Sentance: ");
            string sentance = Console.ReadLine();
            string[] splitSent = sentance.Split(" ");

            Array.Reverse(splitSent);
            string wholeSent = string.Join(" ", splitSent);
            Console.Write("Reversed sentance: {0}", wholeSent);
        }
        static void CoffeeMachine2()
        {

            string[] menu = {
                 "short coffee",
                 "long coffee",
                 "mochaccino",
                 "cappuccino",
                 "green tea",
                 "earl grey"
            };
            double[] prices = {
                 0.70,
                 0.90,
                 1.30,
                 1.20,
                 0.80,
                 0.85
            };
            double[] allowedCoins = {
                 0,
                 0.05,
                 0.10,
                 0.20,
                 0.50,
                 1,
                 2
            };


            while (true)
            {
                Console.WriteLine("Menu:");
                for (int i = 0; i < menu.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {menu[i]} - ${prices[i]:F2}");
                }

                int currIndex = 0;
                double[] coinInsert = new double[1];
                double sum = 0;
                bool validCoin = false;
                bool restart = false;
                Console.WriteLine("Put coins into the machine: ");
                while (true)
                {

                    double coins = Convert.ToDouble(Console.ReadLine());
                    for (int j = 0; j < allowedCoins.Length; j++)
                    {
                        if (coins == allowedCoins[j])
                        {

                            validCoin = true;
                            break;
                        }
                    }
                    if (!validCoin)
                    {
                        Console.Write("No such coin.");
                        restart = true;
                        break;
                    }
                    sum += coins;
                    if (coins == 0)
                        break;
                    else
                    {
                        if (currIndex <= coinInsert.Length)
                        {
                            Array.Resize(ref coinInsert, coinInsert.Length * 2);
                        }
                        coinInsert[currIndex] = coins;
                        currIndex++;
                    }
                }
                if (restart)
                    continue;
                Console.WriteLine("Choose an item: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 6)
                {
                    Console.WriteLine("Please select between 1 and 6.");
                    break;
                }
                Console.WriteLine("Sugar(0-5):");
                int sugar = Convert.ToInt32(Console.ReadLine());
                if (sugar > 5 || sugar < 0)
                {
                    Console.WriteLine("Sugar amount can be between 0 and 5");
                    break;
                }
                switch (choice)
                {
                    case 1:
                        if (sum > prices[0])
                        {
                            Console.WriteLine("Your change: {0}", (sum - prices[0]).ToString("N2"));
                            Console.WriteLine("Preparing your drink {0} with {1} sugar for {2} leva.", menu[0], sugar, prices[0]);
                            Thread.Sleep(3000);
                            Console.WriteLine("Your drink is ready!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You dont have enough money {0}, the price is{1}", sum, prices[0]);
                        }
                        break;
                    case 2:
                        if (sum > prices[1])
                        {
                            Console.WriteLine("Your change: {0}", sum - prices[1]);
                            Console.WriteLine("Preparing your drink {0} with {1} sugar for {2} leva.", menu[1], sugar, prices[1]);
                            Thread.Sleep(3000);
                            Console.WriteLine("Your drink is ready!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You dont have enough money {0}, the price is{1}", sum, prices[1]);
                        }
                        break;
                    case 3:
                        if (sum > prices[2])
                        {
                            Console.WriteLine("Your change: {0}", sum - prices[2]);
                            Console.WriteLine("Preparing your drink {0} with {1} sugar for {2} leva.", menu[2], sugar, prices[2]);
                            Thread.Sleep(3000);
                            Console.WriteLine("Your drink is ready!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You dont have enough money {0}, the price is{1}", sum, prices[2]);
                        }
                        break;
                    case 4:
                        if (sum > prices[3])
                        {
                            Console.WriteLine("Your change: {0}", sum - prices[3]);
                            Console.WriteLine("Preparing your drink {0} with {1} sugar for {2} leva.", menu[3], sugar, prices[3]);
                            Thread.Sleep(3000);
                            Console.WriteLine("Your drink is ready!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You dont have enough money {0}, the price is{1}", sum, prices[3]);
                        }
                        break;
                    case 5:
                        if (sum > prices[4])
                        {
                            Console.WriteLine("Your change: {0}", sum - prices[4]);
                            Console.WriteLine("Preparing your drink {0} with {1} sugar for {2} leva.", menu[4], sugar, prices[4]);
                            Thread.Sleep(3000);
                            Console.WriteLine("Your drink is ready!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You dont have enough money {0}, the price is{1}", sum, prices[4]);
                        }
                        break;
                    case 6:
                        if (sum > prices[5])
                        {
                            Console.WriteLine("Your change: {0}", sum - prices[5]);
                            Console.WriteLine("Preparing your drink {0} with {1} sugar for {2} leva.", menu[5], sugar, prices[5]);
                            Thread.Sleep(3000);
                            Console.WriteLine("Your drink is ready!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You dont have enough money {0}, the price is{1}", sum, prices[5]);
                        }
                        break;
                }
            }
        }
        static void Swap()
        {
            Console.Write("y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X is {0}, Y is {1}", x, y);

            int rev = y;
            y = x;
            x = rev;

            Console.WriteLine("X is {0}, Y is {1}", x, y);

        }
        static void Sphere()
        {
            Console.Write("The diameter of the sphere: ");
            int diameter = Convert.ToInt32(Console.ReadLine());

            double v = (Math.PI * Math.Pow(diameter, 3)) / 6.00;
            double S = Math.PI * Math.Pow(diameter, 2);

            Console.WriteLine("The volume of the sphere with diameter {0} is {1}", diameter, v.ToString("N4"));
            Console.WriteLine("The surface area is {0}", S.ToString("N4"));
        }
        static void GuessNumber()
        {
            Console.Write("Your guess: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int guess1 = random.Next(0, 11);
            if (guess1 == guess)
            {
                Console.WriteLine("Congrats.You guessed right.");
            }
            else
            {
                Console.WriteLine("Your guess is false. It was{0}", guess1);
            }
        }
        static void PizzaMaker()
        {
            Console.Write("Pizza type: ");
            string pizzaType = Console.ReadLine();

            Console.WriteLine("Diameter: ");
            int diameter= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thickness: ");
            double thick= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Select topping #1: ");
            string topping1 = Console.ReadLine();
            Console.WriteLine("Select topping #2: ");
            string topping2 = Console.ReadLine();
            Console.WriteLine("How many slices: ");
            int slices = Convert.ToInt32(Console.ReadLine());

            double v = (Math.PI * Math.Pow(diameter, 3)) / 6.00;
            Console.WriteLine($"You have ordered {diameter}cm pizza, {thick.ToString("N1")}cm thick, which has {topping1} and {topping2}." +
                $"It will be cut in {slices}. The volume of the pizza with radius {diameter/2} and height {thick} is {v.ToString("N0")}cm3");
        }
        static void ConeVolume()
        {
            
            while (true)
            {
                Console.Write("Radius: ");
                int radius = Convert.ToInt32(Console.ReadLine());

                if (radius <= 0)
                {
                    Console.Write("Radius must be > 0");
                    break;
                }
                    
                Console.Write("Height: ");
                int height = Convert.ToInt32(Console.ReadLine());
                
                    if (height <= 0)
                    {
                        Console.Write("Height must be > 0");
                        break;
                    }

                    double v = (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * height;
                    Console.WriteLine($"The volume of the cone is {v.ToString("N2")}");
                break;
            }
        }
    }
}