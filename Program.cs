
class UserInputToCompile
{

    /**
        Возвращаем массив строк из 3х символов

        string[] array - исходный массив строк
        maxLenSymbol - маскимальная длина строки для записи в новый массив

        return string[] arrNew - массив с длиной строки меньше 4х
    */
    public static string[] arrayToString3size(string[] array, int maxLenSymbol)
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
 
}
