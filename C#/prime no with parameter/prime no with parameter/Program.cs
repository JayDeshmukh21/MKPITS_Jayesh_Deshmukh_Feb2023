using System;
public class prime
{

    public static void Main()
    {
        int n;
        Console.Write("Input a number : ");
        n = Convert.ToInt32(Console.ReadLine());
        chkprime(n);
        Console.ReadKey();

    }
        static void chkprime(int num)
        {
        int counter = 0;
        int isprime = 0;
        for (counter = 2; counter < num; counter++)
        {
            if (num % counter == 0)
            {
                isprime = 1;
                break;
            }

        }
        if (isprime == 0)
        {
            Console.WriteLine(num + "is prime no ");
        }
        else
        {
         Console.WriteLine(num + " is not prime no ");
        }



        }
    
}
