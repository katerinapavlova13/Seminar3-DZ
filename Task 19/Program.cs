// Напишите программу, которая 
//принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.WriteLine("Введите пятизначное число:");
string N = Console.ReadLine();
int flipN = 0;
for (int i = 0; i < N.Length / 2; i++)
{ 
    if (N.Substring(i, 1) != (N.Substring(N.Length - 1 - i, 1)))
    {
        Console.WriteLine("Число не является палиндромом");
        return;
    }
    else
        flipN = 1;
}
if (flipN == 1) 
{
    Console.WriteLine("Число является палиндромом");
}