// //Задача 1
// // Вычислить факториал из натурального числа N!

// int Fact(int n)
// {
//     int result = 1;
//     for (int i = 2; i <= n; i++)
//     {
//         result = result * i;
//     }
//     Console.WriteLine(result);
//     return result;
// }
// int n = 5;
// Fact (n);

//==========================================================================

//Работа с рекурсией
// Вычислить факториал из натурального числа N!

int Fact(int n)
{
    if(n == 1)
    {
        Console.WriteLine($"Stop requrson: n = {n}");
        return n;
    }
    else {Console.WriteLine(n);}

    int result =  n * Fact(n-1);

    Console.WriteLine($"Возврат: n = {n}, fact = {result/n}");
    return result ;
    
}
int n = 5;
Console.WriteLine(Fact (n));
