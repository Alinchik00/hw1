Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число число: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число число: ");
int number3 = int.Parse(Console.ReadLine()!);
if (number1>number2)
{
    if (number1>3)
    {
        Console.WriteLine("Наибольшее число " + number1);
    }
    else
    {
        Console.WriteLine("Наибольшее число " + number3);
    }
}
else
{
Console.WriteLine("Наибольшее число " + number2);
}