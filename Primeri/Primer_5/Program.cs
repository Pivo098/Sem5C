// Задача 4: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int[] GenerateArray(int length, int minValue, int maxValue) // Метод создание массива со случайными числами. Длина будет Length, Минимальное значение minValue, максимальное значение maxValue

{
    int[] result = new int[length]; // создания массива 
    Random rnd = new Random(); //создание генератора случайных чисель 
    for (int i = 0; i < result.Length; i++) // Цикл элементого перебора массива
    {
        result[i] = rnd.Next(minValue, maxValue + 1); // перебор массива, со сохраниеним ячеки массива 

    }
    return result; //возвращаем массив 
}
int[] PairsArray(int[] array)
{
    int[] result = new int[array.Length / 2 + array.Length % 2];
    result [result.Length-1]=array[result.Length-1];
    for (int i = 0; i < array.Length / 2; i++)
    {
        int lastIndex = array.Length-1-i;
        result[i]=array[i]* array[lastIndex]; 
        }
        return result;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}
int [] array =GenerateArray(8,1,6);
PrintArray (array);
PrintArray (PairsArray(array));