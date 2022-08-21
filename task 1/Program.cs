System.Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
string pal = Convert.ToString(number);
if (pal[0] == pal[4])
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}
