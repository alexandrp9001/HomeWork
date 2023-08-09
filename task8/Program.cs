//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
int idx = 1;
while(idx < num)
{
    if((idx % 2) == 0)
    {
        System.Console.WriteLine(idx);
    }
idx++;
}
