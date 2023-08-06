// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = new double [5];
double diff = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-99, 100);
    Console.Write($"{array[i]} ");
}

    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        int maxPosition = i;
                    
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
            else if(array[j] > array[maxPosition]) maxPosition = j;
            diff = array[maxPosition] - array[minPosition];   
        }    
    }

Console. WriteLine();
Console. WriteLine($"Разница между максимальным и минимальным элементами массива равна: {diff}");
