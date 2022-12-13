// Напишите цикл, который принимает на входе два числа (A и B) и возводит число A в натуральною степень B.
Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());
int degree = a;

for (int i = 1; i < b; i++)
{
    degree = degree * a;
}
Console.WriteLine("А в степени В равно: " + degree);
