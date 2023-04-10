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
Console.Clear();
int SetNumber(string text = "")
{
    Console.Write($"Введите число {text}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int number = SetNumber();
int MetodNum(int num)
{
    int cont = 0;
    for (; num > 0 ; num /=10 )
    {
            ++cont;
    }
    return cont;
}



 System.Console.WriteLine(MetodNum(number));