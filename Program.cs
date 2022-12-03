// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write("Введите несколько числ: ");
string M = Console.ReadLine()!;
int[] array = TransformationString(M);
Console.WriteLine($"массив [{String.Join(",", array)}]");
CountingNumber(array);

int[] TransformationString(string number)
{
    int size = 1;
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] == ',' || number[i] == ' ') size++;
    }

    int[] result = new int[size];
    string N = "";

    for (int j = 0, I = 0; j < number.Length; j++)
    {
        if (number[j] == ',' || number[j] == ' ')
        {
            if(N == "") continue;
            int num = Convert.ToInt32(N);
            result[I] = num;
            I++;
            N = "";
            continue;
        }

        N += number[j];
        if (j == number.Length - 1)
        {
            int num = Convert.ToInt32(N);
            result[I] = num;
        }
    }
    return result;
}

void CountingNumber(int[] arr)
{
    int Count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) Count++;
    }
    Console.WriteLine($" найдено {Count} положительных чисел");
}

Console.WriteLine();
// Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100,
// а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).

int[] nArray = GetArray(10);

Console.WriteLine($"массив [{String.Join(",", nArray)}]");
SortArray(nArray);
Console.WriteLine($"отсортированый массив [{String.Join(",", nArray)}]");

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int min = array[i];
        for(int j = i+1; j < array.Length; j++)
        {
            if(array[j]< array[i]) {
                int hub = array[i];
                array[i] = array[j];
                array[j]= hub;
            }
        }
    }
    
}

int[] GetArray(int num, int min = 0, int max = 100)
{
    int[] mas = new int[num];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(min, max + 1);
    }
    return mas;
}