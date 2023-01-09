// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.


int n = Convert.ToInt32(Console.ReadLine());
if (n == 6 || n == 7)
Console.WriteLine("да");
else
Console.WriteLine("нет");

