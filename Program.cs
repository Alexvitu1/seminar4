// Задача 24
// Console.Clear();
// int SetNumber(string text = "")
// {
//     Console.Write($"Введите число {text}:");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }
// int num = SetNumber();
// int sum = 0;

// for (int i = 1; i <= num; ++i)
// {
// sum +=i;
// }
// Console.WriteLine("sum = " + sum);



// Задача 26
// Console.Clear();
// int SetNumber(string text = "")
// {
//     Console.Write($"Введите число {text}:");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int number = SetNumber();
// int MetodNum(int num)
// {
//     int cont = 0;
//     for (; num != 0 ; num /=10 )
//     {
//             ++cont;
//     }
//     return cont;
// }



//  System.Console.WriteLine(MetodNum(number));


// Задача 25

// Console.Clear();
// int SetNumber(string text = "")
// {
//     Console.Write($"Введите число {text}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int num = SetNumber("A");
// int sqr = SetNumber("B");

// int Step(int numer, int sqrer)
// {
//     int result = 1;
//     for (int i=1; i<=sqrer; ++i)
//     {
//         result = result*numer;
//     }
//     return result;

// }

// Console.WriteLine(Step(num, sqr));

// Задача 30


void MetodArray(int[] array)
{
    int length = array.Length;
    Random rnd = new Random();
    for(int i=0; i<length; ++i)
    {
       array[i] = rnd.Next(2);
    }
}

void Print(int[] array)
{
    for(int i=0; i<array.Length; ++i )
    {
        Console.Write($" {array[i]}");
    }
}

int[] array = new int[8];
MetodArray(array);
Print(array);