using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int primes = 0; int nonPrimes = 0; string cmd;
            while ((cmd = Console.ReadLine()) != "stop") {int n = int.Parse(cmd);
                if (n < 0) {Console.WriteLine("Number is negative."); continue;}
                else if (n == 0) {nonPrimes += n; continue;}
                bool prime = true;
                for (int i = 2; i < n; i++)
                {if (n % i == 0) {prime = false; break;}}
                if (prime) {primes += n;}
                else {nonPrimes += n;}}
            Console.WriteLine($"Sum of all prime numbers is: {primes}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimes}");
        }
    }
}
