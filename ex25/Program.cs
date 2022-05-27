// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B. Задачу решить без использования Math.Pow.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("введите целое число A:");
int a1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите целое число B:");
int b1 = int.Parse(Console.ReadLine());


int exponentiation(int a, int b) //метод возведение числа a в степень b
{
    int answer = 0; //тут можно сделать переменную тип double, чтобы увеличить место под ответ
    if (b == 0)
    {
        answer = 1;
    }
    else answer = a;

    while (b > 1)
    {
        answer = answer * a;
        b = b - 1;
    }
    return answer;
}

int answer1 = exponentiation(a1, b1);

Console.WriteLine(answer1 + " - A в степени B");
