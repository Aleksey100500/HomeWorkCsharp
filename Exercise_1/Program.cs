Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a == b)

{
    Console.WriteLine("Они равны");
}

else if(a > b)

{
    Console.Write("Большее число - ");
    Console.WriteLine(a);
    Console.Write("Меньшее число - ");
    Console.WriteLine(b);
}

else

{
    Console.Write("Большее число - ");
    Console.WriteLine(b);
    Console.Write("Меньшее число - ");
    Console.WriteLine(a);
}