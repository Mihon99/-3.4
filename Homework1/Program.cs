double pow = 1;
double a = ReadA("Введите  число, которое собираетесь возводить в степень");
double b = ReadB("Введите  степень, в которую собираетесь возводить число");

double ReadA(string message)
{
    Console.WriteLine(message);
    a = double.Parse(Console.ReadLine());
    return a;  
}

double ReadB(string message)
{
    Console.WriteLine(message);
    b = double.Parse(Console.ReadLine());
    return b;  
}

double Pow(double a)
{
    int i = 1;
    while (i<=b)
    {
        pow = pow * a;
        i++;
    }         
    return pow;
}

pow = Pow(a);
Console.WriteLine("Произведение = " + pow);