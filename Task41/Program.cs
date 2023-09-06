/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

System.Console.Write("Введите количество элементов в массиве: ");

int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [arrayLength];

GetArrayFromUser(arrayLength);
PrintArray(arr);

Console.WriteLine();
System.Console.WriteLine("Количество положительных чисел в массиве равно: " + FindQuantityEvenNumbers(arr));


int FindQuantityEvenNumbers(int[] array)
{   
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0)
        {
            count ++;
        }
    }
    return count;      
}

void GetArrayFromUser(int arrayLength)
{
    for(int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"Введите элемент массива под индексом {i}:\t");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    } 
}

void PrintArray(int[] arr)
{
    foreach (int iteam in arr)
    {
        Console.Write(iteam + " ");
    }
}


