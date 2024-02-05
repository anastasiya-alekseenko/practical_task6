// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Определение двумерного массива символов
//         char[,] charArray = new char[,]
//         {
//             { 'H', 'e', 'l', 'l', 'o' },
//             { 'W', 'o', 'r', 'l', 'd' }
//         };

//         // Создание строки из массива
//         string resultString = ArrayToString(charArray);

//         // Отображение результата
//         Console.WriteLine(resultString);
//     }

//     static string ArrayToString(char[,] array)
//     {
//         int rows = array.GetLength(0);
//         int cols = array.GetLength(1);

//         // Создание символьного массива для хранения элементов
//         char[] charElements = new char[rows * cols];

//         // Сплющивание двумерного массива в одномерный
//         int index = 0;
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 charElements[index++] = array[i, j];
//             }
//         }

//         // Создание строки из массива символов
//         string resultString = new string(charElements);

//         return resultString;
//     }
// }

// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Определение строки, содержащей латинские буквы в обоих случаях
//         string originalString = "HeLLo WorLD";

//         // Создание новой строки, в которой все прописные буквы заменены на строчные
//         string resultString = ConvertToUpperToLower(originalString);

//         // Отображение результата
//         Console.WriteLine(resultString);
//     }

//     static string ConvertToUpperToLower(string inputString)
//     {
//         char[] charArray = inputString.ToCharArray();

//         // Итерация по каждому символу и преобразование прописных букв в строчные
//         for (int i = 0; i < charArray.Length; i++)
//         {
//             if (char.IsUpper(charArray[i]))
//             {
//                 charArray[i] = char.ToLower(charArray[i]);
//             }
//         }

//         // Создание новой строки из измененного массива символов
//         string resultString = new string(charArray);

//         return resultString;
//     }
// }

// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Задайте произвольную строку
//         string inputString = "radar";

//         // Проверка, является ли строка палиндромом
//         bool isPalindrome = IsPalindrome(inputString);

//         // Отображение результата
//         Console.WriteLine($"The string '{inputString}' is {(isPalindrome ? "a palindrome" : "not a palindrome")}");
//     }

//     static bool IsPalindrome(string input)
//     {
//         // Удаление неалфавитно-цифровых символов и преобразование в нижний регистр
//         string cleanedString = new string(input.ToLower().ToCharArray().Where(c => Char.IsLetterOrDigit(c)).ToArray());

//         // Сопоставление оригинальных и перевернутых строк
//         string reversedString = new string(cleanedString.Reverse().ToArray());

//         return cleanedString == reversedString;
//     }
// }

// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Задайте строку, состоящую из слов, разделенных пробелами
//         string inputString = "Hello World C# Developer";

//         // Изменение порядка слов
//         string reversedString = ReverseWords(inputString);

//         // Отображение результата
//         Console.WriteLine($"Оригинальная строка: {inputString}");
//         Console.WriteLine($"Перевернутая строка: {reversedString}");
//     }

//     static string ReverseWords(string input)
//     {
//         // Разбивка входной строки на массив слов
//         string[] words = input.Split(' ');

//         // Изменение порядка слов
//         Array.Reverse(words);

//         // Объединение перевернутых слов в новую строку
//         string reversedString = string.Join(" ", words);

//         return reversedString;
//     }
// }