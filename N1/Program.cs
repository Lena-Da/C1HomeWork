int a, b;
Console.WriteLine("Введи первое число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число: ");
b = Convert.ToInt32(Console.ReadLine());
 
if(a > b)
{
    Console.WriteLine("Первое число больше второго");
}
else if (a < b)
{
    Console.WriteLine("Первое число меньше второго");
}
else
{
    Console.WriteLine("Оба числа равны");
}