// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[5];
fillArrayRandomNumbers(array);
printArray(array);
int count = 0;
evenNumbers(array);


int evenNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}

Console.WriteLine(count);

void fillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = new Random().Next(100, 1000);
    }
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}