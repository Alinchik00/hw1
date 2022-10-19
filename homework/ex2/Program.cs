Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число число: ");
int numberB = int.Parse(Console.ReadLine()!);
if (numberA>numberB)
{
    Console.WriteLine(numberA + " наибольшее число");
}
else
{
    Console.WriteLine(numberB + " наибольшее число");
}