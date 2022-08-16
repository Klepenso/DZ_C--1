// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

{
    int a, b;

    Console.WriteLine("Введите первое число");

    a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число");

    b = Convert.ToInt32(Console.ReadLine());

    if (a > b)
    {
        Console.WriteLine("{0} наибольшее число", a);
        Console.WriteLine("{0} наименьшее число", b);
    }
    else
    {
        Console.WriteLine("{0} наибольшее число", b);
        Console.WriteLine("{0} наименьшее число", a);
    }
}


