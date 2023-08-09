//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Random rnd = new Random();
int num1 = rnd.Next();
int num2 = rnd.Next();
int num3 = rnd.Next();
int max = num1;
System.Console.WriteLine($"Число 1 = {num1}");
System.Console.WriteLine($"Число 2 = {num2}");
System.Console.WriteLine($"Число 3 = {num3}");
if (max < num2) max = num2;
if (max < num3) max = num3;
System.Console.WriteLine($"Максимальное число = {max}");
