double CalculateFormula (int a, int b, int c, int d)
{
    double numenator = a * b;
    int denumenator = c + d;
    double result = numenator / denumenator;
    return result;
}
 //запуск функции и запись значения в новую переменную answer
double answer = CalculateFormula (1, 2, 3, 4);
Console.WriteLine(answer);