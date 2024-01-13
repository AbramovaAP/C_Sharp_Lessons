void ZeroEvenElements(int[] arr) //ф-ия для обнуления четного элемента массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }

}
//Создадим функцию для вывода элементов массива на экран
void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}
//Создадим целочисленный массив на несколько элементов
int[] array = {1, 2, 3, 4, 5, 6, 7};
//Вызываем функции с параметром array
ZeroEvenElements(array);
PrintArray(array);