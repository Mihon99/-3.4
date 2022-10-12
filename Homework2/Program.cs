Console.WriteLine("Введите рассматриваемое число");
int n = int.Parse(Console.ReadLine());

void GetSum(int n)
{
    int sum = 0;
    int length = 0;
    int f = 0;
    while (n > 0)
    {
        length = length + 1;
        f = n % 10;
        n = n / 10;
        sum =  sum + f;
    }
    Console.WriteLine("Сумма цифр в числе = " + sum);
}



GetSum(n);
