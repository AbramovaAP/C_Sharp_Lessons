//===============Задача 2=====================
//Создать ДМ, состоящий из целых чисел. 
//Вывести на экран эл-ты массива, у которых сумма цифр четная

//1. Функция для заполнения массива случ. целыми числами
int[,] CreateMatrix (int rowCount, int columsCount)
{
    int [,] matrix = new int [rowCount, columsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
                matrix[i,j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

//2. Функция для вывода массива
void ShowMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
                Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

//3. Цикл для перебора элементов массива на удовлетворенность условию
int[,] matrix = CreateMatrix (3,4);
foreach (int e in matrix){
    if (IsInteresting(e) == true){
        Console.WriteLine(e);}
}

//4. Функция для нахождения суммы цифр числа
int GetSumOfDigits(int value)
{
    int sum = 0;
    while (value > 0){
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}


//5. Проверка суммы на четность
bool IsInteresting (int value)
{
    int SumOfDigits = GetSumOfDigits(value);
    if (SumOfDigits % 2 == 0) {return true;}
    else {return false;}
}

//6. Вызов функций
Console.WriteLine();
ShowMatrix(matrix);
