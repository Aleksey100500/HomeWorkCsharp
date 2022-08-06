Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if ((numberA % 2) == 0)
{
    Console.Write($"Число {numberA} чётное");
}
else
{
    Console.WriteLine($"Число {numberA} нечётное");
}