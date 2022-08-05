// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
while(count < N)
{
    count += 2;
    Console.Write(count);
    Console.Write(", ");
}
