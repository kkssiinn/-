Console.WriteLine("Введите элементы массива (слова) через пробел:");
        string input = Console.ReadLine(); 
        string[] inputArray = input.Split(' '); 

        int shortStringCount = CountShortStrings(inputArray); 
        
       
        string[] resultArray = CreateShortStringsArray(inputArray, shortStringCount); 

        PrintResultArray(resultArray); 
    

    static int CountShortStrings(string[] inputArray)
    {
        int count = 0; 
        foreach (string str in inputArray) 
        {
            if (str.Length <= 3) 
            {
                count++; 
            }
        }
        return count; 
    }

    
    static string[] CreateShortStringsArray(string[] inputArray, int count)
    {
        string[] resultArray = new string[count]; 
        int index = 0; 
        foreach (string str in inputArray) 
        {
            if (str.Length <= 3) 
            {
                resultArray[index] = str; 
                index++; 
            }
        }
        return resultArray; 
    }

    static void PrintResultArray(string[] resultArray)
    {
        Console.WriteLine("Новый массив слов (длина <= 3 символа):"); 
        foreach (string str in resultArray) 
        {
            Console.Write($"{str} "); 
        }
    }
