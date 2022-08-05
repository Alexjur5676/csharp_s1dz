// Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число большее,
// а какое меньшее.
Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(numberA > numberB)
{
    max = numberA;
}
else if(numberA < numberB)
{
    max = numberB;
}

Console.Write("max = ");
Console.Write(max);
