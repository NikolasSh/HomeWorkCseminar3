/*
Напишите программу, которая принимает на вход пятизначное число
 и проверяет, является ли оно палиндромом.
*/

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);
        
        if(int.TryParse(Console.ReadLine(), out result) && result < 99999 && result > 9999)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не верное число или 0. Повторите ввод!");
        }
    }

    return result;
}

int number = GetNumber("Введите пятизначное число: ");
int a = number % 10;
Console.WriteLine(a);
int a1 = number / 10000;
Console.WriteLine(a1);
int b = number / 10;
Console.WriteLine(b);
int b1 = b % 10;
Console.WriteLine(b1);
int c = number / 1000;
Console.WriteLine(c);
int c1 = c % 10;
Console.WriteLine(c1);



if (a == a1 && b1 == c1)
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else 
{
    Console.WriteLine($"Число {number} не является палиндромом");
}
