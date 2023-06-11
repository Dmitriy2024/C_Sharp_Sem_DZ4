/*
//Программа который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Число А в натуральной степене В =  " + Math.Pow(numberA, numberB));
*/


//Программа, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите  число: ");
var Number = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int i = 0;

for(i = 0; i < Number; i++)
{
sum = sum + Number % 10;
Number = Number /10;
}

  Console.WriteLine(sum );



/*
//Программа, которая задаёт массив из 8 элементов и выводит их на экран.
int size = 8;
int[] array = new int[size]; 
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0, 100);
    //Console.Write( + array[i] + " ");                                                              ]");
}
Console.Write($"Массив: [ {String.Join("; ", array)} ]");
*/