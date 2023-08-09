//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Random rnd = new Random();
int num1 = rnd.Next();
int num2 = rnd.Next();
System.Console.WriteLine($"Число 1 {num1}");
System.Console.WriteLine($"Число 2 {num2}");
System.Console.WriteLine(num1 > num2 ? "Число 1 больше числа 2" : "Число 2 больше числа 1");