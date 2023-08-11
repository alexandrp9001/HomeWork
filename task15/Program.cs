//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int Prompt(string msg)
{
System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число:");
string day = "Неделя состоит из 7 дней. Введите число от 1 до 7.";
string check(int number)
{
if (number >= 6 && number < 8) day = "Это выходной день";
if (number >= 1 && number < 7) day = "Это будний день";
return day;
}
System.Console.WriteLine(check(number));