/*
Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними в 3D пространстве.
*/
/*
Корень((x1-x2)^2 + (y1-y2)^2 + (z1-z2)^2)
Math.Sqrt()
Math.Pow(выражение, степень)
*/

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);
        
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или 0. Повторите ввод");
        }
    }

    return result;
}

int x1 = GetNumber("Введите координату Х первой точки");
int y1 = GetNumber("Введите координату Y первой точки");
int z1 = GetNumber("Введите координату Z первой точки");
int x2 = GetNumber("Введите координату Х второй точки");
int y2 = GetNumber("Введите координату Y второй точки");
int Z2 = GetNumber("Введите координату Z второй точки");

double GetDistance (int x1, int x2, int y1, int y2, int z1, int z2)
{
    double result = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));
    return result;
} 

Console.WriteLine(GetDistance(x1,x2,y1,y2,z1,Z2));
