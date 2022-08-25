// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

    
Console.Write("Введите число а: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine());

if (a > b && a > c)
        {
            Console.Write("max = ");
            Console.WriteLine(a);
            
        }
        else if (b > a && b > c)
        {
            Console.Write("max = ");
            Console.WriteLine(b);
        }
else 
        {   Console.Write("max = ");
            Console.WriteLine(c);}  
              