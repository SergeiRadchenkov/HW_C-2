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
int firstNum = InterNum("Введите первое число: ");
int secondNum = InterNum("Введите второе число: ");