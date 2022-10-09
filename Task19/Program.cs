// Задача 19: 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
 
Console.WriteLine("Задача 19. Введите пятизначное число: ");
int Number5 = int.Parse(Console.ReadLine());
if (Number5 < 10000 || Number5 > 99999)
    Console.WriteLine($"Ошибка! Вы ввели не пятизначное число {Number5}!");
else
{
    if (Number5.ToString()[0].ToString() == Number5.ToString()[4].ToString() && Number5.ToString()[1].ToString() == Number5.ToString()[3].ToString())
        Console.WriteLine($"{Number5} -> Да");
    else
        Console.WriteLine($"{Number5} -> Нет");
}
