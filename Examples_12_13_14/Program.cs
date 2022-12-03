// задача 12. Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к» заменить большими «К», а большие «С» заменить на маленькие «с».
/*string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля."
+ "Вы так красноречивы. Вы дадите мне чаю?";
// string s = “q w e r t y”
// индекс      0 1 2 3 4 5
// s[3] // r

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty; // Реализация пустой строки
    int length = text.Length; // Определение длины пустой строки
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replase(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

string newText_1 = Replase(newText, 'к', 'К');
Console.WriteLine(newText_1);
Console.WriteLine();

string newText_2 = Replase(newText_1, 'с', 'С');
Console.WriteLine(newText_2);
Console.WriteLine();
*/

// Задача 13. Упорядочить данные внутри массива от меньшего значения к большему (алгоритм сортировки методом минимакса)
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PtintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void selectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] <= array[minPosition]) minPosition = j;
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
Console.WriteLine("Исходный массив:");
PtintArray(arr);
selectionSort(arr); // Запуск метода сортировки
Console.WriteLine("Отсортированный массив от меньшего к большему значению:");
PtintArray(arr);

