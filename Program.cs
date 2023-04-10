// Задача 24
Console.Clear();
int SetNumber(string text = "")
{
    Console.Write($"Введите число {text}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int num = SetNumber();
int sum = 0;

for (int i = 1; i <= num; ++i)
{
sum +=i;
}
Console.WriteLine("sum = " + sum);