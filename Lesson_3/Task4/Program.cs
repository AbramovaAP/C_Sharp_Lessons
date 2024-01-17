// Код для рандомного ввода числа (рабочий)
// Random rnd = new Random();
// int n = 10;
// int[] arr = new int[n];
// int i = 0;
// while (i < n)
// {
//     arr[i] = rnd.Next(1, 10);
//     i = i + 1;
// }
// i = 0;
// while (i < n)
// {
//     Console.Write($"{arr[i]} ");
//     i = i + 1;
// }



// //Исходный код (рабочий)
// int n = 10;
// int[] arr = new int[n];
// int i = 0;
// int sum = 0;
// int product = 1;
// while (i < n){
//     arr[i] = i + 1;
//     Console.Write($"{arr[i]} ");
//     sum = sum + arr[i];
//     product = product * arr[i];
//     i = i + 1;
// }
// Console.WriteLine();
// Console.WriteLine(sum);
// Console.WriteLine(product);


//Переписать исходный код с использованием функции:
int n = 10;
int[] number = new int[n];

// Заполняем массив
void FillArray(int[] arr)
{
    int i = 0;
    while (i < n){
        arr[i] = i + 1;
        Console.Write($"{arr[i]} ");
        i++;
    }
}
FillArray(number);
Console.WriteLine();

//Находим сумму всех элементов массива
int GetSumofElements(int[] arr)
{
    int i = 0;
    int sum = 0;
    while (i < n){
        sum = sum + arr[i];
        i++;
    }
    return sum;
}

//Находим произведение всех элементов массива
int GetProductofElements(int[] arr)
{
    int i = 0;
    int product = 1;
    while (i < n){
        product = product * arr[i];
        i++;
    }
    return product;
}

//Вывод результатов
void PrintResult(int[] arr)
{
        Console.WriteLine(GetSumofElements(arr));
        Console.WriteLine(GetProductofElements(arr));
}
PrintResult(number);