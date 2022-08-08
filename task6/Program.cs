// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет


Console.WriteLine("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());

double div = num % 2;

if (div == 0)
{
    Console.WriteLine("Число " + num + " - чётное.");
}
else
{
    Console.WriteLine("Число " + num + " -  НЕ чётное.");
    Console.WriteLine("Остаток при делении на 2: " + div);
}