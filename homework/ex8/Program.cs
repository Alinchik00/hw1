Console.WriteLine("Введите число: ");
int numberA = int.Parse(Console.ReadLine()!);
if (numberA>2)
{
    int numberB = 2;
    Console.WriteLine(numberB);
numberB = numberB + 2;
do
{
    Console.WriteLine(numberB);
    numberB = numberB + 2;
}
while (numberB<=numberA);
}
else
{
    Console.WriteLine("нет чисел, удовлетворяющих запросу");
}