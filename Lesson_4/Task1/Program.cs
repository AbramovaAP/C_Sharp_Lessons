//================Задача 1======================
//Создать двумерный массив размерностьбю (3, 5),
// состоящий из целых чисел. 
//Вывести его на экран

//Решение задачи без функции
// int [,] matrix = new int [3,5];

// Random rnd = new Random();
// //Заполнение ДМ случайными числами
// for (int i = 0; i < matrix.GetLength(0); i++){
//     for (int j = 0; j < matrix.GetLength(1); j++){
//             matrix[i,j] = rnd.Next(1, 11);
//     }
// }
// //Вывод массива
// for (int i = 0; i < matrix.GetLength(0); i++){
//     for (int j = 0; j < matrix.GetLength(1); j++){
//             Console.Write($"{matrix[i,j]}\t");
//     }
//     Console.WriteLine();
// }

//Решение задачи с использованием функций
//1. Функция для заполнения массива случ. целыми числами
int[,] CreateMatrix (int columsCount, int rowCount)
{
    int [,] matrix = new int [columsCount,rowCount];

    Random rnd = new Random();
    //Заполнение ДМ случайными числами
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
                matrix[i,j] = rnd.Next(1, 11);
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

//3. Вызов функций
int[,] NewMatrix = CreateMatrix(3,4);
ShowMatrix (NewMatrix);