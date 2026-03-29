Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (IsPrime(n))
{
    Console.WriteLine($"{n} - простое число");
}
else
{
    Console.WriteLine($"{n} - не простое число");
}

bool IsPrime(int num)
{
    if (num < 2) return false;
    for (int i = 2; i * i <= num; i++)
    {
        if (num % i == 0) return false;
    }
    return true;
}