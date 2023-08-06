// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = new double [5];
double diff = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-99, 99) + new Random().NextDouble();
    Console.Write($"{array[i]} ");
}

int minPosition = 0;
int maxPosition = 0;

    for (int i = 0; i < array.Length; i++)
    {
                            
        if(array[i] < array[minPosition])
        {
            minPosition = i;
        }
        else if(array[i] > array[maxPosition])
        {
            maxPosition = i;
        }
        diff = array[maxPosition] - array[minPosition];   
    }    


Console. WriteLine();
Console. WriteLine($"Разница между максимальным и минимальным элементами массива равна: {diff}");
