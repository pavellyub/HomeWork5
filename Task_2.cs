// Задайте массив. Напишите программу, которая определяет присутсвтует ли данное число в массиве

int[] array = new int[5];
fillArrayRandomNumbers(array);
Console.WriteLine("Сгенирированный массив: ");
printArray(array);
Console.WriteLine("Задайте число, которое хотите проверить: ");
int A = Convert.ToInt32(Console.ReadLine());

if(searchNember(array, A))
{
    Console.WriteLine("Это число есть в массиве");
}
else
{
    Console.WriteLine("Этого числа нет в массиве");
}

// Метод вывода массива на экран
void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// Метод заполнения массива случайными числами
void fillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = new Random().Next(-100, 101);
    }
}

// Метод поиска заданного числа среди элементов массива
bool searchNember(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] == number)
        return true;
    }
    return false;
}

// Метод задания массива пользователем, предварительно задавшим размер массива 
/*int size = InputInt("Введите размер массива: ");
int[] array = CreateArray(size);
PrintArray(array);*/

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = InputInt("Введите элемент " + i + ": ");
    }
    return array;
}

// Метод ввода какого-то значения пользователем
int InputInt(string outout)
{
    Console.Write(outout);
    return Convert.ToInt32(Console.ReadLine());
}