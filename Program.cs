// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// //  Напишите программу, которая покажет количество чётных чисел в массиве.

// // [345, 897, 568, 234] -> 2

// // Задача 30

// int SetNumber(string text = "")
// {
//      Console.Write($"Введите размер массива {text}:");
//      int num = Convert.ToInt32(Console.ReadLine());
//      return num;
// }


// void MetodArray(int[] array)
// {
//     int length = array.Length;
//     Random rnd = new Random();
//     for(int i=0; i<length; ++i)
//     {
//        array[i] = rnd.Next(100, 999);
//     }
// }

// void Print(int[] array)
// {
//     for(int i=0; i<array.Length; ++i )
//     {
//         Console.Write($" {array[i]}");
//     }
// }

// int MethodChislo(int[] arrray)
// {
//     int summa = 0;
//     for(int i=0; i<arrray.Length; ++i )
//     {
//                 if (arrray[i] % 2 == 0)
//         {
//             summa +=1;
//         }
//     }
    
//     return summa;
// }

// int length = SetNumber();
// int[] array = new int[length];
// MetodArray(array);
// Print(array);
// int sum = MethodChislo(array);
// System.Console.WriteLine();
// System.Console.WriteLine($"Количество четных чисел в массиве: {sum}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// System.Console.Clear();
// int SetNumber(string text = "")
// {
//      Console.Write($"Введите размер массива {text}:");
//      int num = Convert.ToInt32(Console.ReadLine());
//      return num;
// }


// void MetodArray(int[] array)
// {
//     int length = array.Length;
//     Random rnd = new Random();
//     for(int i=0; i<length; ++i)
//     {
//        array[i] = rnd.Next(0, 10);
//     }
// }

// void Print(int[] array)
// {
//     for(int i=0; i<array.Length; ++i )
//     {
//         Console.Write($" {array[i]}");
//     }
// }

// int MethodSum(int[] arrray)
// {
//     int summa = 0;
//     for(int i=0; i<arrray.Length; ++i )
//     {
//         if (arrray[i] % 2 != 0)
//          {
//              summa +=arrray[i];
//          }
//     }
    
//      return summa;
//  }

// int length = SetNumber();
// int[] array = new int[length];
// MetodArray(array);
// Print(array);
// int sum = MethodSum(array);
// System.Console.WriteLine();
// System.Console.WriteLine($"Сумма нечетных элементов массива: {sum}");


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

System.Console.Clear();
int SetNumber(string text = "")
{
     Console.Write($"Введите размер массива {text}:");
     int num = Convert.ToInt32(Console.ReadLine());
     return num;
}


void MetodArray(int[] array)
{
    int length = array.Length;
    Random rnd = new Random();
    for(int i=0; i<length; ++i)
    {
       array[i] = rnd.Next(1, 10);
    }
}

void Print(int[] array)
{
    for(int i=0; i<array.Length; ++i )
    {
        Console.Write($" {array[i]}");
    }
}


(int max, int min) MethodMaxMin(int[] array)
{  
    int max = array[0];
    int min = array[0];
    for(int i=0; i<array.Length; ++i )
    {
        
        if (array[i] > max)
          {
              max = array[i];
          }
        if(array[i]< min)
        {
            min = array[i];
        }
    }
    
    return (max, min);
}

int length = SetNumber();
int[] array = new int[length];
MetodArray(array);
Print(array);

(int max, int min) = MethodMaxMin(array);
System.Console.WriteLine();
System.Console.WriteLine($"Разница между максимальным и минимальным значениями: {max-min}");