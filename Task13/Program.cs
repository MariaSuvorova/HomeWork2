/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

string GetString()
{
    Console.WriteLine("Введите число");
    string setoffigure = Console.ReadLine();
    return setoffigure;
}

int SizeOfString(string str)
{
    int size = str.Length;
    return size;
}

int StringToNumber(string str)
{
    int num = Convert.ToInt32(str);
    return num;
}

int NumberToFigure(int n, int number)
{
    int[] figures = new int[n];
    
    for (int i=0; i<n-1; i++)
    {
        figures[n-1-i] = number % 10;
        number = number / 10;
    }   
    return figures[2];    
}

string line = GetString();
int length = SizeOfString(line);
int numbers = StringToNumber(line);

if (length < 3)
{
   Console.WriteLine("третьей цифры нет"); 
}
else
{
    Console.WriteLine($"третья цифра {NumberToFigure(length, numbers)}");
}

