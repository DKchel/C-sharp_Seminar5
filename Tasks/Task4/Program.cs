// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int [] array= new int [123];

int count=0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,140);
    System.Console.Write(array[i]+ " "); 

    if (array[i]>9 && array[i] <100)
    {
        count++;
    }
}

System.Console.WriteLine();
System.Console.WriteLine("Кол-во элементов от 10 до 99 равно "+ count);   
