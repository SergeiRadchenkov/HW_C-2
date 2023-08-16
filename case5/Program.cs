/* Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine()!); */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

bool Square(int num1, int num2)
{
    if(num2 == num1 * num1)
        return true;
    else
        return false;
}
void PrintResult(bool res)
{
    if (res == true)
    {
        Console.WriteLine("Первое число является квадратом второго");
    }
    else
    {
        Console.WriteLine("Первое число не является квадратом второго");
    }
}