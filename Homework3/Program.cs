Console.WriteLine("Введите величину массива");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимум массива");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимум массива");
int max = int.Parse(Console.ReadLine());
int[] array = new int[n];

int[] Array(int[] array)
{
for (int i = 0; i < n; i++)
{
    int number = new Random().Next(min, max);
    array[i] = number;
}
return array;
}

Array(array);
string s = String.Join(", ", array);
Console.WriteLine("[" + s + "]");