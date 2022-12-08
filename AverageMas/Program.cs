Console.Clear();
int[] mas = new int[10];
Random rnd = new Random();
Console.WriteLine($"Массив:");
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = rnd.Next(0, 100);
    Console.Write(mas[i] + " ");
}
List<int> chet = FindChetValues(mas);
List<int> nechet = FindNechetValues(mas);
double avgChet = FindAverage(chet);
double avgNechet = FindAverage(nechet);
Console.WriteLine("\nМассив из четных: ");
GetList(chet);
Console.WriteLine("\nМассив из нечетных: ");
GetList(nechet);
Console.WriteLine($"\nСреднее четных: {avgChet}\nСреднее нечетных: {avgNechet}");
if (avgChet < avgNechet)
{
    Console.WriteLine("Среднее арифметическое четных чисел < среднего арифметического нечетных чисел");
}
else
{
    Console.WriteLine("Среднее арифметическое четных чисел > среднего арифметического нечетных чисел");
}


List<int> FindChetValues(int[] mas)
{
    List<int> chetMas = new List<int>();
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] % 2 == 0)
        {
            chetMas.Add(mas[i]);
        }
    }
    return chetMas;
}

List<int> FindNechetValues(int[] mas)
{
    List<int> nechetMas = new List<int>();
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] % 2 == 1)
        {
            nechetMas.Add(mas[i]);
        }
    }
    return nechetMas;
}

void GetList(List<int> list)
{
    for (int i = 0; i < list.Count; i++)
    {
        Console.Write(list[i] + " ");
    }
}
double FindAverage(List<int> list)
{
    double average = list.Sum() / list.Count();
    return average;
}


