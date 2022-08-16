// Напишите программу, которая на вход принимает три числа и выдаёт максимальное

{
    int a, b, c;

    Console.WriteLine("Введите первое число");

    a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число");

    b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите третье число");

    c = Convert.ToInt32(Console.ReadLine());

    int max = a;

    if (a > b)
    {
        a = max;
    }
    else
    {
        b = max;
    }
    if (c > b)
    {
        Console.WriteLine("{0} наибольшее число", c);
    }
    else
    {
        Console.WriteLine("{0} наибольшее число", b);
    }
    if (a > c)
    {
        Console.WriteLine("{0} наибольшее число", a);
    }
    else
    {
        Console.WriteLine("{0} наибольшее число", c);
    }
}

