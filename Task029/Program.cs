/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int [] userArray = EnteredArray();
PrintedArray(userArray);


// метод для создания массива из введённых значений
int[] EnteredArray()
{
    Console.WriteLine("Enter array lenght, please.");
    int lngt = InputIntNumberTryParse();
    int [] arr = new int [lngt];
    int i = 0;
    while (i < lngt)
    {
        Console.WriteLine($"Enter {i}-element array's [{lngt}], please.");
        arr[i] = InputIntNumberTryParse();
        i++;
    }
    return arr;
} 
// метод для печати
void PrintedArray(int [] printArray)
{
    int index = 0;
    while (index < printArray.Length)
    {
        Console.Write($"[{printArray[index]}] ");
        index++;
    }
    Console.WriteLine();
}
// метода для ввода значений
int InputIntNumberTryParse()
{

    bool isParsed = int.TryParse(Console.ReadLine(), out int num);

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