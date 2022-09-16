/* Задача 1. Является ли первое число квадратом второго?

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32 (Console.ReadLine());

if (num1 == num2 * num2)
{
    Console.WriteLine($"{num1} is a quad if {num2}");
}
else
{
    Console.WriteLine($"{num1} is not a quad if {num2}");
}

*/
// Задача 2. ЦЕлое число N показывает от -N до N

/*
Console.Write("Input integer number: ");
int num = Convert.ToInt32 (Console.ReadLine());

int current = num * (-1);

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/

// Задача 3. трехзначное и в конце показывает последнюю цифру

Console.Write("Input three-digit integer number: ");
int num = Convert.ToInt32 (Console.ReadLine());

int result = num % 10;

Console.WriteLine(result);
