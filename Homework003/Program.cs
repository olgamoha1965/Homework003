//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

/*void Palindrome(int num)
{
    int num1 = num / 10000;
    int num2 = num / 1000 % 10;
    int num4 = num / 10 % 10;
    int num5 = num % 10;
    if(num1 == num5 && num2 == num4)
        Console.WriteLine($"Number {num} is palindrome number.");
    else Console.WriteLine($"Number {num} is not palindrome number.");
}

Console.WriteLine("Input your 5digit number:");
int user_num = Convert.ToInt32(Console.ReadLine());

if(user_num >= 1 && user_num < 100000)
{
    Palindrome(user_num);
}
else Console.WriteLine("Impossible number!");*/


//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/*double Line3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double lengthAB = Math.Sqrt((x2 -x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return lengthAB;
}

Console.WriteLine("Input X coordinat of A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coordinat of A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z coordinat of A: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input X coordinat of B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coordinat of B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z coordinat of B: ");
int zB = Convert.ToInt32(Console.ReadLine());

double dist = Line3D(xA, yA, zA, xB, yB, zB);

Console.WriteLine($"A ({xA},{yA},{zA}); B ({xB},{yB},{zB}) -> {dist:f2}");
*/

//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

/*void Cube(int num)
{
    int current = 1;
    while(current <= num)
    {
        int res = current * current * current;
        Console.Write($"{res}, ");
        current ++;
    }
    Console.WriteLine("\b\b ");
}

Console.WriteLine("Input number:  ");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 1)
{
    Console.Write($"{number} -> ");
    Cube(number);
}
else Console.WriteLine("Impossible number!");
*/