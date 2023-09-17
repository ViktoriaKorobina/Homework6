// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


string[] array = WorkWithUser("Введите числа через запятую: ");
int[] collection = DigitOfString(array);
Console.WriteLine(CountPositive(collection));


string[] WorkWithUser(string message)
{
    Console.Write(message);
    string str = Console.ReadLine();
    string[] symb = str.Split(", ");
    return symb;
}
int[] DigitOfString(string[] symbs)// Преобразует строковый массив в целочисленный
{
    int[] digits = new int[symbs.Length];
    for (int i = 0; i < digits.Length; i++)
    {
        digits[i] = int.Parse(symbs[i]);
    }
    return digits;
}
int CountPositive(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) res++;
    }
    return res;
}
