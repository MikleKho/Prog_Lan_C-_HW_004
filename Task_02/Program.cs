// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int Prompt(string message)
{
    System.Console.Write(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}

int Sum_of_Digits(int Number)
{
    int result = 0;
    if (Number < 0)
    {
        Number = Number * (-1);
    }
    while (Number > 0)
    {
        result = result + (Number % 10);
        Number = Number / 10;
    }
    return result;
}

int Number = Prompt("Введите число --> ");
System.Console.WriteLine($"Сумма цифр -->  {Sum_of_Digits(Number)}");
