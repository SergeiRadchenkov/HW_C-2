int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

bool Multiplicity(int number)
{
    return number % 7 == 0 && number % 23 == 0;
}

int num = InputNum("Введите число: ");
bool result = Multiplicity(num);

if(result)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}