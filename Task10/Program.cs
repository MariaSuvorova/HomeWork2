/* Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

int GetNumber()
{
    Console.WriteLine("Введите трехзначное число");
    int threepositionnumber = Convert.ToInt32(Console.ReadLine());
    return threepositionnumber;
}

int WriteSecondNumber(int num)
{
    int secondfigure = ((num/10)%10);
    return secondfigure;
}

//int number = GetNumber();
//int secondnumber = WriteSecondNumber(number);
Console.WriteLine($"вторая цифра {WriteSecondNumber(GetNumber())}");
