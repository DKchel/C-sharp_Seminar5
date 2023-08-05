// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int[] array = new int [5];

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

bool ifFind = false;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 11);
    Console.Write(array[i]+ " ");  

    if (array[i] == num)
    {
        ifFind = true;
    }
}
    if (ifFind == true)
    {
        Console.Write($" Да, число {num} есть в массиве"); 
    }
    else
    {
        Console.Write($" Нет, числа {num} нет в массиве"); 
    }
