//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
int result = -1;
if (num >= 100)

{
   while (num > 1000)
   {
    num = num / 10;
   }
   result = num % 10;

    System.Console.WriteLine("Третья цифра заданного числа:");
    System.Console.WriteLine(result);
    return;
}
else
{
    System.Console.WriteLine( "В заданном числе меньше трех цифр");
}