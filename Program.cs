
class UserInputToCompile
{
    static string ERROR = "Ни одного значениия нет меньше 4х символов!";
    static string END_TEXT = "Завершение программы!";

    /**
        Возвращаем массив строк из 3х символов

        string[] array - исходный массив строк
        maxLenSymbol - маскимальная длина строки для записи в новый массив

        return string[] arrNew - массив с длиной строки меньше 4х
    */
    public static string[] ArrayToString3size(string[] array, int maxLenSymbol)
    {
        Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
        int sizeNewArr = 0;
        // заполняем null если значение больше 3 или пустое
        // увеличиваем инкремент размера нового массива если знаение строки меньше 4х
        for (int i = 0; i < array.Length; i++)
        {
            // удаляем лишние пробелы
            array[i] = array[i].Trim();
            if (array[i].Length > maxLenSymbol || array[i] == "")
                array[i] = null;
            else
                sizeNewArr++;
        }
        string[] arrNew = new string[sizeNewArr];
        int indx = 0;
        // заполняем в новый массив не null значения массива
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != null)
                arrNew[indx++] = array[i];
        }
        return arrNew;
    }

    public static void PrintResult(string[] array, int size)
    {
        if (array.Length != 0)
        {
            // вывод ответа
            Console.WriteLine($"Результат: [{string.Join(", ", arrayToString3size(array, size))}]");
            Console.WriteLine(END_TEXT);
            return;
        }

        string r = "";
        while (r != "q" || r != "x")
        {
            Console.Write("Введите символы через запятую (выход - x/q): ");
            r = Console.ReadLine();
            Console.Clear();
            if (r == "q" || r == "x")
            {
                Console.WriteLine(END_TEXT);
                return;
            }
            if (r == ",")
            {
                Console.WriteLine(ERROR);
                continue;
            }
            array = r.Split(",");
            string[] arrNew = arrayToString3size(array, size);
            if (arrNew.Length == 0)
            {
                Console.WriteLine(ERROR);
                continue;
            }
            Console.WriteLine($"Результат: [{string.Join(", ", arrNew)}]");
        }
        Console.WriteLine(END_TEXT);
        return;

    }

}
