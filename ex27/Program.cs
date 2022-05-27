// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе. Задачу решить без использования строк (string).
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("введите целое число");
int a1 = int.Parse(Console.ReadLine());
int answer = 0;
int a2 = 0;
while (a1 > 0)
{
    a2 = a1 % 10;
    a1 = a1 / 10;
    answer = answer + a2;
}
Console.WriteLine(answer + " - сумма цифр введенного числа");

