// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int result = 0;
// int Kol()
// {
//     Console.Write("Введите число = ");
//     int sum = Convert.ToInt32(Console.ReadLine());
//     if (sum>0)
//     {
//         result = result + 1;
//         Console.WriteLine($"{result}");
//     }
//     else if (sum<=0)
//     {
//         Console.WriteLine($"{result}");
//     }
//     return Kol();
// }
// Kol();  


// Console.Write("Введите длину массива = ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];

// RandonNumbers(numbers);
// Power(numbers);
// Console.Write("Массив = ");
// PrintArray(numbers);
// void RandonNumbers(int[] numbers)
// {
//     for(int i = 0; i < size; i++)
//     {
//         Console.Write("Введите число = ");
//         numbers[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }
// void Power(int[] numbers)
// {
//     int result = 0;

//     for (int i = 0; i < numbers.Length; i++)
//     {
//     if (numbers[i]>0)
//     {
//         result = result + 1;
        
//     }
//     else if (numbers[i]<=0)
//     {
        
//     }
//     // return Kol();
//     }
//     Console.WriteLine($"Количество положительных чисел = {result}");
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

Console.Write("Введите числа через пробел = ");
int[] numbers = Kol(Console.ReadLine());
Console.Write("Массив = ");
PrintArray(numbers);
Sum();
void Sum()
{
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество положительных чисел = [ {sum} ]");
}
int[] Kol(string arr)
{
    int size = 1;                                   
    for (int i = 0; i < arr.Length; i++)            
    {                                               
        if (arr[i] == ' ')                          
        {                                           
            size++;                                 
        }                                           
    }                                               
    int[] numbers = new int [size];                 

    int index = 0;                                  
    for (int i = 0; i < arr.Length; i++)            
    {                                               
        string temp = "";                           
        while (arr[i] != ' ')                        
        {                                           
            if(i != arr.Length - 1)                  
            {                                       
                temp += arr [i].ToString();         
                i++;                                
            }                                       
            else                                    
            {                                       
                temp += arr [i].ToString();         
                break;                              
            }                                       
        }                                           
        numbers[index] = Convert.ToInt32(temp);      
        index++;                                    
    }                                               
    return numbers;                                 
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}