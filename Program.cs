using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter question number to run (1-28):");
        int q = int.Parse(Console.ReadLine());

        switch (q)
        {
            case 1: Q1(); break;
            case 2: Q2(); break;
            case 3: Q3(); break;
            case 4: Q4(); break;
            case 5: Q5(); break;
            case 6: Q6(); break;
            case 7: Q7(); break;
            case 8: Q8(); break;
            case 9: Q9(); break;
            case 10: Q10(); break;
            case 11: Q11(); break;
            case 12: Q12(); break;
            case 13: Q13(); break;
            case 14: Q14(); break;
            case 15: Q15(); break;
            case 16: Q16(); break;
            case 17: Q17(); break;
            case 18: Q18(); break;
            case 19: Q19(); break;
            case 20: Q20(); break;
            case 21: Q21(); break;
            case 22: Q22(); break;
            case 23: Q23(); break;
            case 24: Q24(); break;
            case 25: Q25(); break;
            case 26: Q26(); break;
            case 27: Q27(); break;
            case 28: Q28(); break;
            default: Console.WriteLine("Invalid number"); break;
        }
    }

    // 1- divisible by 3 and 4
    static void Q1()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n % 3 == 0 && n % 4 == 0 ? "Yes" : "No");
    }

    // 2- negative or positive
    static void Q2()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n < 0 ? "negative" : "positive");
    }

    // 3- max and min of 3 numbers
    static void Q3()
    {
        Console.Write("Enter 3 numbers separated by space: ");
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine("max element = " + nums.Max());
        Console.WriteLine("min element = " + nums.Min());
    }

    // 4- even or odd
    static void Q4()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n % 2 == 0 ? "even" : "odd");
    }

    // 5- vowel or consonant
    static void Q5()
    {
        Console.Write("Enter a character: ");
        char c = char.ToLower(Console.ReadLine()[0]);
        string vowels = "aeiou";
        Console.WriteLine(vowels.Contains(c) ? "vowel" : "Consonant");
    }

    // 6- print numbers 1 to n
    static void Q6()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
            Console.Write(i + (i < n ? ", " : "\n"));
    }

    // 7- multiplication table up to 12
    static void Q7()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 12; i++)
            Console.Write(n * i + " ");
        Console.WriteLine();
    }

    // 8- even numbers between 1 and n
    static void Q8()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 2; i <= n; i += 2)
            Console.Write(i + " ");
        Console.WriteLine();
    }

    // 9- power
    static void Q9()
    {
        Console.Write("Enter base and exponent separated by space: ");
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int result = 1;
        for (int i = 0; i < nums[1]; i++)
            result *= nums[0];
        Console.WriteLine(result);
    }

    // 10- total, average, percentage of 5 marks
    static void Q10()
    {
        Console.Write("Enter marks of five subjects: ");
        int[] marks = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int total = marks.Sum();
        double average = total / 5.0;
        double percentage = (total / 500.0) * 100;
        Console.WriteLine("Total marks = " + total);
        Console.WriteLine("Average Marks = " + average);
        Console.WriteLine("Percentage = " + percentage);
    }

    // 11- days in month
    static void Q11()
    {
        Console.Write("Month Number: ");
        int m = int.Parse(Console.ReadLine());
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        Console.WriteLine("Days in Month: " + days[m - 1]);
    }

    // 12- simple calculator
    static void Q12()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter operator (+ - * /): ");
        char op = Console.ReadLine()[0];
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        double result = op switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            '/' => a / b,
            _ => throw new Exception("Invalid operator")
        };
        Console.WriteLine("Result = " + result);
    }

    // 13- reverse a string
    static void Q13()
    {
        Console.Write("Enter a string: ");
        string s = Console.ReadLine();
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine(new string(arr));
    }

    // 14- reverse an int
    static void Q14()
    {
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());
        int reversed = 0;
        int temp = Math.Abs(n);
        while (temp > 0)
        {
            reversed = reversed * 10 + temp % 10;
            temp /= 10;
        }
        Console.WriteLine(n < 0 ? -reversed : reversed);
    }

    // 15- prime numbers in a range
    static void Q15()
    {
        Console.Write("Input starting number of range: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Input ending number of range: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine($"The prime number between {start} and {end} are :");
        for (int i = start; i <= end; i++)
        {
            if (i < 2) continue;
            bool isPrime = true;
            for (int j = 2; j * j <= i; j++)
                if (i % j == 0) { isPrime = false; break; }
            if (isPrime) Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    // 16- decimal to binary without array
    static void Q16()
    {
        Console.Write("Enter a number to convert: ");
        int n = int.Parse(Console.ReadLine());
        int original = n;
        string binary = "";
        if (n == 0) binary = "0";
        while (n > 0)
        {
            binary = (n % 2) + binary;
            n /= 2;
        }
        Console.WriteLine($"The Binary of {original} is {binary}.");
    }

    // 17- check if 3 points lie on a single straight line
    static void Q17()
    {
        Console.Write("Enter x1 y1: ");
        double[] p1 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        Console.Write("Enter x2 y2: ");
        double[] p2 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        Console.Write("Enter x3 y3: ");
        double[] p3 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        double slope1 = (p2[1] - p1[1]) * (p3[0] - p2[0]);
        double slope2 = (p3[1] - p2[1]) * (p2[0] - p1[0]);

        Console.WriteLine(slope1 == slope2 ? "The points lie on a single straight line" : "The points do not lie on a single straight line");
    }

    // 18- worker efficiency
    static void Q18()
    {
        Console.Write("Enter time taken (hours): ");
        double t = double.Parse(Console.ReadLine());

        if (t >= 2 && t <= 3) Console.WriteLine("Highly efficient");
        else if (t > 3 && t <= 4) Console.WriteLine("Increase your speed");
        else if (t > 4 && t <= 5) Console.WriteLine("Training required");
        else Console.WriteLine("Required to leave the company");
    }

    // 19- identity matrix
    static void Q19()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write((i == j ? 1 : 0) + " ");
            Console.WriteLine();
        }
    }

    // 20- sum of array elements
    static void Q20()
    {
        Console.Write("Enter array elements separated by space: ");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine("Sum = " + arr.Sum());
    }

    // 21- merge two sorted arrays
    static void Q21()
    {
        Console.Write("Enter first array elements: ");
        int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.Write("Enter second array elements: ");
        int[] b = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[] merged = a.Concat(b).OrderBy(x => x).ToArray();
        Console.WriteLine("Merged array: " + string.Join(" ", merged));
    }

    // 22- frequency of each element
    static void Q22()
    {
        Console.Write("Enter array elements separated by space: ");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var freq = arr.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        foreach (var pair in freq)
            Console.WriteLine($"{pair.Key} occurs {pair.Value} time(s)");
    }

    // 23- max and min in array
    static void Q23()
    {
        Console.Write("Enter array elements separated by space: ");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine("Max element = " + arr.Max());
        Console.WriteLine("Min element = " + arr.Min());
    }

    // 24- second largest element
    static void Q24()
    {
        Console.Write("Enter array elements separated by space: ");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int second = arr.Distinct().OrderByDescending(x => x).ElementAt(1);
        Console.WriteLine("Second largest element = " + second);
    }

    // 25- longest distance between two equal cells
    static void Q25()
    {
        Console.Write("Enter array elements separated by space: ");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int maxDist = 0;

        for (int i = 0; i < arr.Length; i++)
            for (int j = i + 1; j < arr.Length; j++)
                if (arr[i] == arr[j])
                    maxDist = Math.Max(maxDist, j - i - 1);

        Console.WriteLine("Longest distance = " + maxDist);
    }

    // 26- reverse order of words
    static void Q26()
    {
        Console.Write("Enter a sentence: ");
        string[] words = Console.ReadLine().Split(' ');
        Array.Reverse(words);
        Console.WriteLine(string.Join(" ", words));
    }

    // 27- copy multidimensional array
    static void Q27()
    {
        Console.Write("Enter rows and columns separated by space: ");
        int[] dim = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rows = dim[0], cols = dim[1];
        int[,] arr1 = new int[rows, cols];
        int[,] arr2 = new int[rows, cols];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Enter value [{i},{j}]: ");
                arr1[i, j] = int.Parse(Console.ReadLine());
                arr2[i, j] = arr1[i, j];
            }

        Console.WriteLine("Second array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(arr2[i, j] + " ");
            Console.WriteLine();
        }
    }

    // 28- print 1D array in reverse order
    static void Q28()
    {
        Console.Write("Enter array elements separated by space: ");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        for (int i = arr.Length - 1; i >= 0; i--)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}
