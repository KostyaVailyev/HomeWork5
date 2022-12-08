Console.Clear();
int[] mas = new int[10];
Random rnd = new Random();
Console.WriteLine($"Массив:");
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = rnd.Next(0, 100);
    Console.Write(mas[i] + " ");
}
int min = FindMin(mas);
int max = FindMax(mas);
int diff = FindDiff(min, max);
Console.WriteLine($"\nМинимальное число = {min} \nМаксимальное число = {max} \nРазность между Min и Max = {diff}");


int FindMin(int[] mas)
{
    int min = mas[0];
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] < min) min = mas[i];
    }
    return min;
}
int FindMax(int[] mas)
{
    int max = mas[0];
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] > max) max = mas[i];
    }
    return max;
}
int FindDiff(int min, int max)
{
    return max - min;
}