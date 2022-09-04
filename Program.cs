// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.WriteLine ($" Введите числа через пробел: ");
// string [] Numbers = Console.ReadLine().Split(' ');
// int[] array = new int [Numbers.Length];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Convert.ToInt32(Numbers[i]);
//     if (array[i]>0)
//     {
//         count++;
//     }
// }
// Console.WriteLine ($" Количество чисел больше 0 = {count}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1,
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write (" Введите значение b1:  ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write (" Введите значение k1:  ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write (" Введите значение b2:  ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.Write (" Введите значение k2:  ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double x=(b2-b1)/(k1-k2);
// double y=k1*x+b1;

// Console.WriteLine ($"Точка пересечения двух прямых:{x},{y}");

// Доп. задачка:
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write (" Введите число:  ");
int Number = Convert.ToInt32(Console.ReadLine());
int div = 0;
string result="";
while (Number>=1)
{
    div = Number%2;
    result = div+result;
    Number = Number/2;
}
Console.WriteLine (result);