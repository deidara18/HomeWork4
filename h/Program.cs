//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

/*Console.WriteLine("Введите A");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите B");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"степень числа {A} в степени {B} = {Pow(A)}");
int Pow (int size)
{
    int n = 1;
    for(int i = 0; i < B;i++)
    {
        n*=A;
    }
    return n;
}*/


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

/*Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {n} = {SumNumber(n)}");

int SumNumber (int size){
    int number = 0;
    while (n > 0)
    {
        number = number + n % 10;
        n/= 10 ;
    }
    return number;
}*/



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

/*int [] array = GetArray(8);
Console.WriteLine($"[{String.Join(",", array)}]");

int [] GetArray (int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(10) ;
    } 
    return result;
}*/



