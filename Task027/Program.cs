/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int number = ChoiceMethodEnter();
int sumNumber = GetSumFromNumber(number);
Console.WriteLine($"Sum numbers {number} = {sumNumber}");
//ввод взят из ДЗ_03 задачи 19
int InputIntNumberTryParse()
{
    Console.WriteLine("Enter number, please.");
    bool isParsed = int.TryParse(Console.ReadLine(), out int num);

    if (!isParsed)
    {
        Console.WriteLine("Sorry, but You entered bullshit. Please, number enter.");
        return -1;
    }
    else
    {
        Console.WriteLine($"{num} -- it's number user entered.");
        return num;
    }
}

int RandomIntNumber()
{
    Random random = new Random();
    int number = random.Next(10, 100000);
    Console.WriteLine($"{number} -- it's number from Random [10 - 99999]");
    return number;
}

int ChoiceMethodEnter()
{
    Console.WriteLine("Please, choosed method input number:");
    Console.WriteLine("1) Random number [10 - 99999]");
    Console.WriteLine("2) Usering enter");
    Console.WriteLine("Enter [1] or [2]");
    bool isParsed = int.TryParse(Console.ReadLine(), out int numChoice);
    if (!isParsed)
    {
        Console.WriteLine("Sorry, but You entered bullshit. Please, number enter.");
        return -1;
    }
    else
    {
        int num;
        if (numChoice == 1)
        {
            num = RandomIntNumber();
        }
        else
        {
            num = InputIntNumberTryParse();
        }
        return num;
    }
}
//перевод числа в массив (перевернутый) с  сумированием его элементов
int GetSumFromNumber(int enteredNumber)
{
    int count = 1;
    int numberDivided = enteredNumber;
    while (numberDivided > 10)
    {
        numberDivided = numberDivided / 10;
        count++;
    }

    numberDivided = enteredNumber;
    int[] arr = new int[count];
    int sum = 0;
    for (int i = 0; i < count; i++)
    {
        arr[i] = numberDivided % 10;
        numberDivided = numberDivided / 10;
        sum = sum + arr[i];
    }
    return sum;
}