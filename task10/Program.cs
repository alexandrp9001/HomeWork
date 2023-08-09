//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int randomNumber = new Random().Next(100, 1000);
System.Console.WriteLine("Выбрвно число:");
System.Console.WriteLine(randomNumber);
int ost = randomNumber%100;
int center = ost/10;
System.Console.WriteLine("Второе число трехзначного числа:");
System.Console.WriteLine(center);