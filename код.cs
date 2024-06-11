Console.WriteLine("Введите элементы массива строк через пробел:");
        string input = Console.ReadLine(); // Чтение строки, введенной пользователем
        string[] inputArray = input.Split(' '); // Разделение строки на подстроки по пробелам и сохранение их в массиве inputArray.

        // Подсчет количества строк длиной <= 3 символа
        int shortStringCount = CountShortStrings(inputArray); // Вызов функции для подсчета коротких строк
        
        // Создание нового массива нужного размера и заполнение его
        string[] resultArray = CreateShortStringsArray(inputArray, shortStringCount); // Вызов функции для создания массива коротких строк

        // Вывод результата
        PrintResultArray(resultArray); // Вызов функции для печати результата
    

    // Функция для подсчета строк длиной <= 3 символа
    static int CountShortStrings(string[] inputArray)
    {
        int count = 0; // Объявление переменной count для хранения количества строк, длина которых <= 3 символа.
        foreach (string str in inputArray) // Перебор всех строк в массиве inputArray.
        {
            if (str.Length <= 3) // Проверка, если длина текущей строки меньше или равна 3.
            {
                count++; // Увеличение счетчика count, если условие выполнено.
            }
        }
        return count; // Возврат количества строк длиной <= 3 символа.
    }

    // Функция для создания массива коротких строк
    static string[] CreateShortStringsArray(string[] inputArray, int count)
    {
        string[] resultArray = new string[count]; // Объявление и инициализация нового массива строк resultArray размером count.
        int index = 0; // Объявление переменной index для отслеживания текущей позиции в resultArray.
        foreach (string str in inputArray) // Снова перебор всех строк в массиве inputArray.
        {
            if (str.Length <= 3) // Проверка, если длина текущей строки меньше или равна 3.
            {
                resultArray[index] = str; // Заполнение resultArray текущей строкой.
                index++; // Увеличение индекса для следующей позиции в resultArray.
            }
        }
        return resultArray; // Возврат нового массива строк
    }

    // Функция для печати результата
    static void PrintResultArray(string[] resultArray)
    {
        Console.WriteLine("Новый массив строк (длина <= 3 символа):"); // Вывод заголовка для результата.
        foreach (string str in resultArray) // Перебор всех строк в resultArray.
        {
            Console.Write($"{str} "); // Вывод каждой строки в resultArray.
        }
    }
