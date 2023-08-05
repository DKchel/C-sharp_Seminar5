


Console.WriteLine("Введите размер массива:");
int num = Convert.ToInt32(Console.ReadLine());

int [] array1 = new int [num];
int [] array2 = new int [array1.Length / 2 + array1.Length % 2];

for (int i = 0; i < array1.Length; i++)
{
    array1[i] = new Random().Next(0, 9);
    Console.Write(array1[i]+ " ");  
}

Console.WriteLine();

for (int i = 0; i < array2.Length; i++)
{
    array2[i] = array1[i] * array1[array1.Length - 1 - i]; // - i искуственно сдвигает на элемент дальше

    if (i == array1.Length - 1 - i)
    {
        array2[i] = array1[i];
    }
    Console.Write(array2[i]+ " "); 
}