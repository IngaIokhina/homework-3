/*Напишите программу, которая принимает на вход координаты двух точек \
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

d=sqrt(x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2);
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);


        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("You didn't enter a number. Enter the number");
        }
    }

    return result;
}

double GetDistanse (int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow (x2 - x1,2)+ Math.Pow (y2 - y1,2) + Math.Pow(z2 - z1,2));
}

int x1 = GetNumber ("Enter the x coordinate for the first point");
int y1 = GetNumber ("Enter the y coordinate for the first point");
int z1 = GetNumber ("Enter the z coordinate for the first point");
int x2 = GetNumber ("Enter the x coordinate for the second point");
int y2 = GetNumber ("Enter the y coordinate for the second point");
int z2 = GetNumber ("Enter the z coordinate for the second point");

double distanse = GetDistanse (x1, x2, y1, y2, z1, z2);

Console.WriteLine (distanse);