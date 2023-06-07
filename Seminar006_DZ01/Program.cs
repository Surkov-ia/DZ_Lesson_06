// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int result = 0;
int Kol()
{
    Console.Write("Введите число = ");
    int sum = Convert.ToInt32(Console.ReadLine());
    if (sum>0)
    {
        result = result + 1;
        Console.WriteLine($"{result}");
    }
    else if (sum<=0)
    {
        Console.WriteLine($"{result}");
    }
    return Kol();
}
Kol();  
