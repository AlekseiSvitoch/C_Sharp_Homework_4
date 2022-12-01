// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// НЕ ИСПОЛЬЗОВАТЬ MATH.POW
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int degree = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= degree; i++)
{
    result = result * number;
}
Console.WriteLine($"{number} в степени {degree} = {result}");
