// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Enter(string text)
{
    System.Console.Write(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int VolidatingNum (int num)
{
    if (num <= 0)
    {
    System.Console.WriteLine("Ввод не коректен!");
    num = Enter("Укажите колличество вводимых элементов: ");
    VolidatingNum(num);
    }
        return num;
}

int[] myArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Enter($"Введите число № {i+1}: ");

    }
    return array;
}

int overZero(int[] array)
{
int Count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        Count++;
    }

}
return Count;
}

int Num = Enter("Укажите колличество вводимых элементов: ");

int CountOverZero=overZero(myArray( VolidatingNum(Num)));


System.Console.WriteLine($"Колличество чисел больше нуля = {CountOverZero}");