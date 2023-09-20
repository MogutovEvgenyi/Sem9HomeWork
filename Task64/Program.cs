int InputNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}
void PrintNumbers(int n)
{
    if (n > 0)
    {
        Console.Write(n + " ");
        PrintNumbers(n - 1);

    }
}
//
int number = InputNum("Введите число: ");
PrintNumbers(number);