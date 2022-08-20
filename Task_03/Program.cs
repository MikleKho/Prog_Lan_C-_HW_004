// Задача 3: Напишите программу, которая задаёт массив из 8 элементов случайными числами 
// и выводит их на экран. Также ищет второй максимум (число меньше максимального элемента, но больше всех остальных)
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

int[] Mass_rnd_inject(int[] Mass)
{
    int Len = Mass.Length;
    Random rnd = new Random();
    System.Console.Write("Массив -->  ");
    
    for (int i = 0; i < Len; i++)
    {
        Mass[i] = rnd.Next(0, 100);
        System.Console.Write($"  {Mass[i]}");
    }
    System.Console.WriteLine("");

    return Mass;
}


int[] Mass_Max_Two(int[] Mass)
{
    int Len = Mass.Length;
    int[] Mass_Max = new int[2];
    Mass_Max[0] = Mass[0];
    Mass_Max[1] = Mass[0];
    
    for (int i = 1; i < Len; i++)
    {
        if (Mass[i] > Mass_Max[0])
        {
            Mass_Max[1] = Mass_Max[0];
            Mass_Max[0] = Mass[i];
        }
        else
        {
            if (Mass[i] > Mass_Max[1])
            {
                Mass_Max[1] = Mass[i];
            }
        }
    }
    
    return (Mass_Max);
}


int[] Mass = new int[8];
Mass = Mass_rnd_inject(Mass);

int[] Mass_Max = new int[2];
Mass_Max = Mass_Max_Two(Mass);

System.Console.WriteLine($"Максимальное значение --> {Mass_Max[0]} Второе значение --> {Mass_Max[1]}");
