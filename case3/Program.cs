/*Console.Write("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int secondNum = int.Parse(Console.ReadLine()!); */

int InputNum(string message)
{
    Console.Write(message);
    // int num = int.Parse(Console.ReadLine()!);
    // return = int num;
    return int.Parse(Console.ReadLine()!);
}

bool Multiplicity(int num1, int num2)
{
    /* if(num1 % num2 == 0)
        return true;
    return false; */

    return num1 % num2 == 0;
}

int firstNum = InputNum("Введите первое число: ");
int secondNum = InputNum("Введите второе число: ");

bool result = Multiplicity(firstNum, secondNum);
if(result == true)
    Console.WriteLine("Второе число кратно первому");
else
Console.WriteLine($"Второе число не кратно первому, остаток от деления: {firstNum % secondNum}");