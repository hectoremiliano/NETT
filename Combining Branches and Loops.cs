using System;

class Program
{
    static void Main(string[] args)
    {
        ExploreLoops();
    }

    static void ExploreIf()
    {
        int a = 5;
        int b = 3;
        if (a + b > 10)
        {
            Console.WriteLine("The answer is greater than 10");
        }
        else
        {
            Console.WriteLine("The answer is not greater than 10");
        }

        int c = 4;
        if ((a + b + c > 10) && (a > b))
        {
            Console.WriteLine("The answer is greater than 10");
            Console.WriteLine("And the first number is greater than the second");
        }
        else
        {
            Console.WriteLine("The answer is not greater than 10");
            Console.WriteLine("Or the first number is not greater than the second");
        }

        if ((a + b + c > 10) || (a > b))
        {
            Console.WriteLine("The answer is greater than 10");
            Console.WriteLine("Or the first number is greater than the second");
        }
        else
        {
            Console.WriteLine("The answer is not greater than 10");
            Console.WriteLine("And the first number is not greater than the second");
        }
    }

    static void ExploreLoops()
    {
        // Uso de while
        int counter = 0;
        while (counter < 10)
        {
            Console.WriteLine($"Hello World! The counter is {counter}");
            counter++;
        }

        // Uso de do...while
        int counterDoWhile = 0;
        do
        {
            Console.WriteLine($"Hello World! The counter is {counterDoWhile}");
            counterDoWhile++;
        } while (counterDoWhile < 10);

        // Uso de for
        for (int index = 0; index < 10; index++)
        {
            Console.WriteLine($"Hello World! The index is {index}");
        }

        // Bucles anidados
        for (int row = 1; row < 11; row++)
        {
            for (char column = 'a'; column < 'k'; column++)
            {
                Console.WriteLine($"The cell is ({row}, {column})");
            }
        }

        // Combinación de ramas y bucles
        int sum = 0;
        for (int i = 1; i <= 20; i++)
        {
            if (i % 3 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine($"The sum of numbers between 1 and 20 divisible by 3 is {sum}");
    }
}
