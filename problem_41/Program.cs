/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
 0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Write("Введите количество элементов массива - ");
int Length = Convert.ToInt32(Console.ReadLine());
int [] array = new int [Length];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите число ");
    array[i] = int.Parse(Console.ReadLine());                    
}

int positiveNumbers (int [] array)
{
int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine();
int countNumber = positiveNumbers(array);
Console.WriteLine ($"Из введенных пользователем числел, положительных {countNumber}");

