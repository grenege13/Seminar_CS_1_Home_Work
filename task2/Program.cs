// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число :");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число :");
double num2 = Convert.ToDouble(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Первое число " + num1 + " больше");
}
if (num1 < num2)
{
    Console.WriteLine("Второе число " + num2 + " больше");
}
if (num1 == num2)
{
    Console.WriteLine(" Числа равны ");
}