using System;

class Program
{
    static void Main(string[] args)
    {
        // a) 1, 3, 5, 7, ___
        for (int i = 1; i <= 9; i += 2)
        {
            Console.Write(i);
            if (i != 9)
            {
                Console.Write(", ");

            }
        }
            Console.WriteLine();

        // b) 2, 4, 8, 16, 32, 64, ____
        int num = 2;
        for (int i = 0; i <= 6; i++)
        {
            Console.Write(num);
            if(i != 6) { 
            Console.Write(", ");
            }
            num *= 2;
        }
        Console.WriteLine();
        // c) 0, 1, 4, 9, 16, 25, 36, ____
        for (int i = 0; i <= 7; i++)
        {
            Console.Write(i * i);
            if(i != 7)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();

        // d) 4, 16, 36, 64, ____
        for (int i = 2; i <= 10; i += 2)
        {
            Console.Write(i * i);
            if(i != 10)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();

        // e) 1, 1, 2, 3, 5, 8, ____
        int a = 1, b = 1;
        Console.Write(a + ", " + b + ", ");
        for (int i = 0; i <= 4; i++)
        {
            int next = a + b;
            Console.Write(next);
            if(i != 4)
            {
                Console.Write(", ");
            }
            a = b;
            b = next;
        }
        Console.WriteLine();

        // f) 2,10, 12, 16, 17, 18, 19, ____
        int[] sequenceF = { 2, 10, 12, 16, 17, 18, 19, 200 };
        foreach (int item in sequenceF)
        {
            Console.Write(item);
            if (item != 200)
            {
                Console.Write(", ");
            }

        }
        Console.WriteLine();
    }
}