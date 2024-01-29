//======================Задача 3======================
//Считать с консоли строку, состоящую из цифр и латинских букв.
// Сформировать новую строку, состоящую из букв исходной строки.

//1.Функция для извлечения
string GetLettersFromStr (string s)
{
    string letters = "";//подстроки извлеченное из строки
    foreach(char e in s){
        if (char.IsAsciiLetter(e) == true){ //Кодировка IsAsciiLetter - проверяет, 
                                            //входят ли символы в буквенную кодировку, 
                                            //для распознования и отличия цифр от букв
            //В строках знак "+" - это операция склеивания или конкатенация
            letters = letters + e;
        }
    }
    return letters;
}

//Запуск
string str = Console.ReadLine();
string letters = GetLettersFromStr(str);
Console.WriteLine(letters);