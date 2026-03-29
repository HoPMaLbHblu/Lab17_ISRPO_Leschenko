int[] arr = { 10, 45, 23, 78, 34, 89, 12 };
int max = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
}

Console.WriteLine($"Максимальный элемент: {max}");