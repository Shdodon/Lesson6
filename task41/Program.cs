// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int M = UserInput("Введите M: ");
int[] arrays = CollectArray(M);
PrintArray(arrays);
PrintCountWholeNumber(CollectWholeNumbers(arrays));

int UserInput(string text)
{
    Console.Write(text);
    int numbers = int.Parse(Console.ReadLine());
    int temp = Convert.ToInt32(numbers);
    return numbers;
}

int[] CollectArray(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] acceptArray)
{
    for (int i = 0; i < acceptArray.Length; i++)
    {
        Console.Write($"{acceptArray[i]} ");
    }
}
int CollectWholeNumbers(int[] checkArray)
{
    int counter = 0;
    for (int i = 0; i < checkArray.Length; i++)
    {
        if (checkArray[i] >= 0)
        {
            counter++;
        }
    }
    return counter;
}
void PrintCountWholeNumber(int number)
{
    Console.WriteLine($"->Пользователь ввел чисел больше 0: {number}");
}