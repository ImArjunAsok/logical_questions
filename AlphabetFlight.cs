Console.WriteLine("Enter Flight Number Alphabet: ");
char Alphabet = char.Parse(Console.ReadLine());
Console.WriteLine("Enter the Range Limit: ");
int Limit = int.Parse(Console.ReadLine());

Console.WriteLine("Printing Odd Range:");
for (int i = 100; i <= Limit; i++)
{
    if(i%2 == 1)
    Console.Write("{0}{1}  ", Alphabet, i);
}

Console.WriteLine("\nPrinting Even Range:");
for (int i = 100; i <= Limit; i++)
{
    if (i % 2 == 0)
        Console.Write("{0}{1}  ", Alphabet, i);
}
Console.WriteLine();

Console.WriteLine("First 10 Prime Numbers: ");
int Counter = 0;
int s = 2;
while (Counter < 10)
{
    bool isPrime = true;
    for (int j = 2; j < s; j++)
    {
        if (s % j == 0)
        {
            isPrime = false;
        }
    }
    if (isPrime)
    {
        Counter++;
        Console.Write("Q{0}  ",s);
    }
    s++;
}

int val1 = 0, val2 = 1, val3;
Console.WriteLine("\nFirst 10 Fibonacci numbers:");
Console.Write("N{0}  N{1}  ", val1, val2);
for (int i = 2; i < 10; i++)
{
    val3 = val1 + val2;
    Console.Write("N{0}  ",val3);
    val1 = val2;
    val2 = val3;
}

int n = 1, a, b,  z = 1, r;
Console.WriteLine("\nFirst 10 Armstrong numbers:");
while (z <= 10)
{
    a = 0;
    b = n;
    do
    {
        r = b % 10;
        a = a + r * r * r;
        b = b / 10;
    } while (b > 0);
    if (a == n)
    {
        Console.Write("A{0}  ",n);
        z++;
        n++;
    }
    else
        n++;
}