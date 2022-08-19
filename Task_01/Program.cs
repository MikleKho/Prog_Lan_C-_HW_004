// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Prompt(string message)
{
    System.Console.Write(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}

int A_Power_B(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}

int A = Prompt("Введите основание степени -> ");
int B = Prompt("Введите натуральный показатель степени -> ");
if (B > 0)
{
    System.Console.WriteLine($"Число {A} в степени {B} ---> {A_Power_B(A, B)}");
}
else
{
    System.Console.WriteLine("Input error");
}