Console.Clear();
int[] mas = new int[10];
Random rnd = new Random();
Console.WriteLine($"Массив из положительных 3хзначных чисел:");
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = rnd.Next(100, 999);
    Console.Write(mas[i] + " ");
}
int count = FindCount(mas);
Console.WriteLine($"\nКоличество четных чисел: {count}");


int FindCount(int[] mas)
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}