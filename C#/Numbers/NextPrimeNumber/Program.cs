System.Console.WriteLine("Begin finding prime numbers:");
List<ulong> primes = new();
primes.Add(2);
primes.Add(3);
bool isPrime(ulong num)
{
    foreach (var p in primes)
    {
        if (num % p == 0) return false;
    }
    return true;
}
// bool findNext = true;
System.Console.Write("2  is prime. continue finding next prime number? (Y / n)");
// var doStop = Console.ReadKey();

if (ConsoleKey.N != Console.ReadKey(true).Key)
{
    System.Console.WriteLine();
    System.Console.Write("3  is prime. continue finding next prime number? (Y / n)");
}
while (ConsoleKey.N != Console.ReadKey(true).Key)
{
    System.Console.WriteLine();
    ulong i = primes[^1];
    while (true)
    {
        i++;
        if (isPrime(i))
        {
            primes.Add(i);
            break;
        }
    }

    System.Console.Write($"{primes[^1]} is prime. continue finding next prime number? (Y / n)");
    // doStop = Console.ReadLine();
    // if ("N" == doStop?.ToUpper()) findNext = false;

}

