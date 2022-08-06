int a = 2, b = 3,
    c = 7;

if (b > a && b > c)

{
    Console.WriteLine(b);
}

else if (a > b | a > c)

{
    Console.WriteLine(a);
}

else if (c > a | c > b)

{
    Console.WriteLine(c);
}

else

{
    Console.WriteLine("Они равны");
}
