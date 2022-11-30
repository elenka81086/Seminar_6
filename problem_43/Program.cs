/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

int setTheVaiues(string number)
{
    int result = 0;
    Console.Write(number);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}
double pointOfIntersecnion (double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения имеет координаты ({x};{y})");
    return x;
}

Console.WriteLine("Введите значения четырех переменных ");
int b1 = setTheVaiues ("Введите b1: ");
int k1 = setTheVaiues ("Введите k1: ");
int b2 = setTheVaiues ("Введите b2: ");
int k2 = setTheVaiues ("Введите k2: ");
double result = pointOfIntersecnion (b1, k1, b2, k2);