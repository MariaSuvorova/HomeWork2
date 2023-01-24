/* Напишите программу, которая принимает на вход цифру, обозначающую день недели,\
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

int GetDayOfWeek()
{
    Console.WriteLine("Введите цифру дня недели");
    int daynumber = Convert.ToInt32(Console.ReadLine());
    return daynumber;
}

int day = GetDayOfWeek();

if (day == 6 || day == 7)
{
    Console.WriteLine("Сегодня выходной");
}
else 
{
    if (day > 0 && day < 6)
    {
      Console.WriteLine("Сегодня будний день");  
    }
    else
    {
    Console.WriteLine("Введено некорректное число");
    }
}