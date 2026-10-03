using Domain.Models;
/* 1
try
{
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int c = a / b;
    System.Console.WriteLine(c);
}
catch (DivideByZeroException e)
{
    System.Console.WriteLine("Число a нельзя делить на 0");
}
catch(Exception e)
{
    System.Console.WriteLine("Введите только число");
}
*/

/* 2
DateTime date = DateTime.Now;
System.Console.WriteLine(date.ToString("yyyy-MM-dd HH:MM:ss"));
*/

/* 3
System.Console.WriteLine("Enter the date in this format yyyy-mm-dd:");
var d = Console.ReadLine()!;
var startDate = DateTime.Parse(d);
System.Console.WriteLine((DateTime.Today-startDate.Date).Days);
*/

/* 4
System.Console.Write("Введите номер месяца: ");
int numberOfMonth = Convert.ToInt32(Console.ReadLine());
Month month = (Month)numberOfMonth;
System.Console.WriteLine(month);
*/

/* 5
System.Console.Write("Введите цвет: ");
string color = Console.ReadLine()!;

Color selectedColor = Enum.Parse<Color>(color);

switch (selectedColor)
{
    case Color.Red:
        System.Console.WriteLine("rgb(255, 0, 0)");
        break;

    case Color.Green:
        System.Console.WriteLine("rgb(0, 255, 0)");
        break;

    case Color.Blue:
        System.Console.WriteLine("rgb(0, 0, 255)");
        break;
}
*/

// HomeTask 1;
DateTime date = new DateTime(2016,8,16,3,57,32,11);
System.Console.WriteLine($@"year = {date.Year},
month = {date.Month}
day = {date.Day} 
hour = {date.Hour}
minute = {date.Minute}
second = {date.Second}
millisecond = {date.Millisecond}");
// HomeTask 2;
int cnt = 0;
for (; ; )
{
    string input = Console.ReadLine()!;
    if(input == "end") break;
    else cnt++;
}
System.Console.WriteLine(cnt);