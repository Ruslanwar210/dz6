// Задача 1:
// Задайте двумерный массив символов (тип char [,]).Создать строку из символов этого массива.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Задаём размер массива
//         Console.Write("Введите количество строк: ");
//         int rows = int.Parse(Console.ReadLine());

//         Console.Write("Введите количество столбцов: ");
//         int cols = int.Parse(Console.ReadLine());

//         // Инициализируем двухмерный массив
//         char[,] charArray = new char[rows, cols];

//         // Ввод значений элементов
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 Console.Write($"Введите значение элемента массива ({i + 1}, {j + 1}): ");
//                 charArray[i, j] = char.Parse(Console.ReadLine());
//             }
//         }

//         // Создаём строку из массива
//         string resultString = GetStringFromCharArray(charArray);

//         // Выводим результат
//         Console.WriteLine("Result String: " + resultString);
//     }

//     // Функция для создания строки из двумерного массива символов
//     static string GetStringFromCharArray(char[,] charArray)
//     {
//         int rows = charArray.GetLength(0);
//         int cols = charArray.GetLength(1);

//         // Создаём массив char для хранения символов
//         char[] resultArray = new char[rows * cols];

//         // Копируем символы из двухмерного массива в массив результатов
//         int index = 0;
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 resultArray[index++] = charArray[i, j];
//             }
//         }

//         // Создание строки из массива символов
//         string resultString = new string(resultArray);

//         return resultString;
//     }
// }


// Задача 2:
// Задайте строку, содержащую латинские буквы в обоих регистрах.Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Запрос пользователю строки латинских букв
//         Console.Write("Введите строку латинских букв разных регистров: ");
//         string inputString = Console.ReadLine();

//         // Создание новой строки, в которой все прописные буквы заменены на строчные
//         string resultString = ConvertToUpperToLower(inputString);

//         // Вывод
//         Console.WriteLine("Результат: " + resultString);
//     }

//     // Функция замены прописных букв на строчные
//     static string ConvertToUpperToLower(string input)
//     {
//         char[] charArray = input.ToCharArray();

//         for (int i = 0; i < charArray.Length; i++)
//         {
//             if (char.IsUpper(charArray[i]))
//             {
//                 charArray[i] = char.ToLower(charArray[i]);
//             }
//         }

//         return new string(charArray);
//     }
// }


// Задача 3:
// Задайте произвольную строку. Выясните, является ли она палиндромом.



// using System;

// class Program
// {
//     static void Main()
//     {
//         // Запрос пользователю произвольной строки
//         Console.Write("Введите строку: ");
//         string inputString = Console.ReadLine();

//         // Проверяем, является ли входная строка палиндромом
//         bool isPalindrome = IsPalindrome(inputString);

//         // Вывод результата
//         if (isPalindrome)
//         {
//             Console.WriteLine("Введёная строка является палиндромом.");
//         }
//         else
//         {
//             Console.WriteLine("Введёная строка не является палиндромом.");
//         }
//     }

//     // Функция для проверки, является ли строка палиндромом
//     static bool IsPalindrome(string str)
//     {
//         // Удаление пробелов и преобразование в нижний регистр для сравнения без учета регистра
//         string cleanStr = str.Replace(" ", "").ToLower();

//         // Сопоставление исходной строки с обратной
//         return cleanStr == new string(cleanStr.ToCharArray().Reverse().ToArray());
//     }
// }