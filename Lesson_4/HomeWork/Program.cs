//======================Задача======================
//Считать с консоли строку, состоящую из цифр и латинских букв.
// Сформировать массив, состоящий из цифр исходной строки.
//Н-р, abc123def06g -> [1, 2, 3, 0, 6]

//1.Функция для извлечения
string GetLettersFromStr (string s)
{
    string letters = "";//подстроки извлеченное из строки
    foreach(char e in s){
        if (char.IsAsciiLetter(e) == false){ //Кодировка IsAsciiLetter - проверяет, 
                                            //входят ли символы в буквенную кодировку, 
                                            //для распознования и отличия цифр от букв
            //В строках знак "+" - это операция склеивания или конкатенация
            letters = letters + e;
        }
    }
    return letters;
}

//2. Запуск функции
string str = Console.ReadLine();
string letters = GetLettersFromStr(str);
Console.WriteLine(letters);

//3. Преобразование строки в одномерный массив
char[] Mass = letters.ToCharArray();
foreach(char MassOne in Mass){
    Console.Write($"{MassOne}, ");
}


