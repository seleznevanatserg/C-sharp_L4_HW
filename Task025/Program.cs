/* Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и метод который возводит число A в натуральную степень B. 
Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. 
Не использовать Math.Pow() */
Console.WriteLine("Enter first number.");
Double number1 = InputDoubleNumberTryParse();

Console.WriteLine("Enter second number.");
Double number2 = InputDoubleNumberTryParse();

if (number2 % 1 == 0)
{
    Double result = ProductedNumberFirstExtentSecond(number1, number2);
    Console.WriteLine($"{result} -- it's number {number1} in extent {number2}");
}
else
{
    Console.WriteLine("Sorry, It's very difficult. T_T");
}



Double InputDoubleNumberTryParse()
{

    bool isParsed = Double.TryParse(Console.ReadLine(), out Double num);

    if (!isParsed)
    {
        Console.WriteLine("Sorry, but You entered bullshit. Please, number enter.");
        return 0;
    }
    else
    {
        Console.WriteLine($"{num} -- it's number user's entered.");
        return num;
    }
}

Double ProductedNumberFirstExtentSecond(Double number, Double extent)
{
    double res = number;
    if (extent != 0)
    {
         if (extent > 0)
        {
            for (int i = 1; i < extent; i++)
            {
                res = res * number;
            }
        }
        else
        {
            for (int i = -1; i > extent; i--)
            {
                res = res * number;
            }
            res = 1 / res;
        }
    }
    else
    {
        res = 1;
    }

    return res;
}