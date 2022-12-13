// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// ​
// 645 -> 5
// ​
// 78 -> третьей цифры нет
// ​
// 32679 -> 6

Console.WriteLine("Введите трехзнчное число:");
int number=Convert.ToInt32(Console.ReadLine());

if (number >= 100)
    {
        int result = -1;
        while (number > 999)
            {
                number = number / 10;
            }
            result = number % 10;
     
            Console.WriteLine($"{result}");
    }
else
{
    Console.WriteLine("Третьей цифры нет");
}

