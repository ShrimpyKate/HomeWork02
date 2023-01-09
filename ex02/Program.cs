// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

string n = Console.ReadLine();
char[] array = n.ToCharArray();

if (array.Length >= 3)
  Console.WriteLine(array[2]);
else
  Console.WriteLine("Третьего числа нет");