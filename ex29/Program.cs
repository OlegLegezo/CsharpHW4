// Задача 29: Напишите программу, которая задаёт массив целых чисел и выводит их на экран.
// Размер массива определяется пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



Console.WriteLine("введите размер массива");
int num = int.Parse(Console.ReadLine());//сразу перевели число в инт

Random rnd = new Random();

//метод создания массива
int[] initArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-9, 10);
        Console.Write(array[i] + " "); //если нужно отобразить
    }
    return array;
}
//метод создания массива

int[] arr = initArray(num);
