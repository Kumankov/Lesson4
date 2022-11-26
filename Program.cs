// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
double Task25 (int number, int power)
{
double Pow =1;
if (power==0) return 1;
    else 
        {   
            for (int i=1; i<=Math.Abs(power); i++)
            Pow =Pow*number;
        }
if (power > 0) return Pow;
else return 1/Pow;
}
Console.WriteLine("Введите число A для задачи 25:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B для задачи 25:");
int B = int.Parse(Console.ReadLine());
Console.WriteLine(Task25 (A,B));

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Task27 (string num)
{
int sum = 0;
    for (int i = 0 ; i<num.Length; i++)
    {
        sum = sum + Convert.ToInt32(num[i].ToString());
    }
return sum;
}
Console.WriteLine("Введите многозначное число для задачи 27:");
string numTusk27 = Console.ReadLine();
Console.WriteLine(Task27(numTusk27));

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Условие задачи не однозначное. Программа будет принимать на вход строку из элементов через запятую и вывод получивщийся массив.

Console.WriteLine("Введите элементы массива через запятую для задачи 27:");
string massTask29 = Console.ReadLine();
string[] splitMassTask29 = massTask29.Split(",");
Console.Write($"[{splitMassTask29[0]},");
for (int i=1;i<splitMassTask29.Length;i++)
if (i==splitMassTask29.Length-1) Console.Write($"{splitMassTask29[i]}]");
    else Console.Write($"{splitMassTask29[i]},");
