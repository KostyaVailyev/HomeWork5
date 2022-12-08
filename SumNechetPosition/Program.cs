Console.Clear();
int[] mas = new int[10];
Random rnd = new Random();
Console.WriteLine($"Массив:");
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = rnd.Next(-15, 15);
    Console.Write(mas[i] + " ");
}
int sum = FindSum(mas);
Console.WriteLine($"\nСумма чисел на нечетных позициях (начиная отсчет с 0): {sum} ");


int FindSum(int[] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += mas[i];
        }
    }
    return sum;
}
