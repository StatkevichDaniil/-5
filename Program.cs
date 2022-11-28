// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] mas = GetArray(10,100,999);
Console.WriteLine($"массив [{String.Join(",",mas)}]");
Console.WriteLine($"в масиве {Counter(mas)} четных чисел");

int[] GetArray(int num, int min= 0 , int max = 9)
{
    int[] mas = new int[num];
    for (int i = 0; i < mas.Length; i++){
        mas[i] = new Random().Next(min, max+1);
    }
    return mas;
}

int Counter(int[] mas){
    int result=0;
    foreach ( int i in mas){
        if (i%2 == 0) result ++;
    }
    return result;
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях(индексы элементов должны быть нечетными(1,3,5 и тд)).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] massiv = GetArray(10);  // метод из первой задачи
Console.WriteLine($"массив [{String.Join(",",massiv)}]");
Console.WriteLine($"в масиве сумма чисел с нечетными индексами равна {OddNumberSum(massiv)}");

int OddNumberSum(int[] array){
    int sum = 0;
    for( int i = 0; i < array.Length;i++){
        if (i%2 == 1) sum+= array[i];
    }
    return sum;

}

// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int [] arrey = GetArray(9); // метод из первой задачи
Console.WriteLine($"массив [{String.Join(",",arrey)}]");
Console.WriteLine($"массив произведения пар [{String.Join(",",SumPairsNumbers(arrey))}]");

int [] SumPairsNumbers(int[] mas){
    int proizvedenie = 0;
    int[] ar;
    if (mas.Length%2 == 0) {
        ar = new int[mas.Length/2];
    }
    else {
        ar = new int[mas.Length/2+1];
        ar[mas.Length/2] = mas[mas.Length/2];
    }
    for (int i= 0, j = mas.Length-1; i < mas.Length/2;i++, j--){
        proizvedenie = mas[i]*mas[j];
        ar[i] = proizvedenie;
    }
    return ar;
}


//Задача 38: Задайте массив целых чисел от -10 до 10. Найдите разницу между максимальным и минимальным элементов массива.


int [] a = GetArray(10, -10 , 10); // метод из первой задачи
Console.WriteLine($"массив [{String.Join(",",a)}]");
Console.WriteLine($"разность макс и мин числа масива равна: {DifferenceMaxMin(a)}");

int DifferenceMaxMin(int [] array){
    int max = array[0];
    int min = array[0];
    for(int i = 0 ; i < array.Length; i++)
    {
        if ( max < array[i]) max = array[i];
        if ( min > array[i]) min = array[i];
    }
    int sum = max - min;
    return sum;
}