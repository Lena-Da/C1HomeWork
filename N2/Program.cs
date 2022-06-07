int a, b, c;
Console.WriteLine("Введи первое число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи третье число: ");
c = Convert.ToInt32(Console.ReadLine());

if(a > b) 
{
    if(a > c)
    Console.WriteLine($"Число {a} максимальное");
}
if(b > a) 
{
    if(b > c)
    Console.WriteLine($"Число {b} максимальное");
}
if(c > a) 
{
    if(c > b)
    Console.WriteLine($"Число {c} максимальное");
}