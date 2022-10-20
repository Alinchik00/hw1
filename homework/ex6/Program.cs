Console.WriteLine("Введите число: ");
int numberA = int.Parse(Console.ReadLine()!);
int numberB = numberA%2;
if (numberB<1)
{
    Console.WriteLine("число четное");
}
else
{
    Console.WriteLine("число нечетное");
}