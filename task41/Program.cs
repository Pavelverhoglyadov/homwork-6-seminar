// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int FillArray()
{
    Console.WriteLine("Введите числа, для запуска программы ведите 0");
    bool loop = true;
    int count = 0;
    while (loop)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
        {
            count++;
        }
        else if (num == 0)
        {
            loop = false;
        }
    }
    return count;
}

void PrintArray(int array)
{
    Console.WriteLine($"Вы ввели {(array)} положительных чисел");
}

int array = FillArray();
PrintArray(array);



