/*Задача 19
Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Enter the number: ");
string? number = Console.ReadLine();
void GetNumber(string number)
{
    if (number[0]==number[4] || number[1]==number[3])
    {
        Console.Write("The number is a palindrome ");
    }
    else
    {
        Console.WriteLine("Number is NOT a palindrome");
    }
}
if (number!.Length == 5)
{
  GetNumber(number);
}
else Console.WriteLine("Enter another number");