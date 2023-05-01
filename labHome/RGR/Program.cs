

Dictionary<string, Calendar> calendarDict = new Dictionary<string, Calendar>();

while (true)
{
    Console.Clear();
    Console.WriteLine("1.Добавить календарь");
    Console.WriteLine("2.Определить день недели по дате");
    Console.WriteLine("3.Числа по дню недели");
    Console.WriteLine("4.Выход");

    ConsoleKeyInfo key = Console.ReadKey();
    Console.Clear();
    if (key.Key == ConsoleKey.D1)
    {
        Console.WriteLine("Введите название календаря");
        string calendarName = Console.ReadLine();
        Console.WriteLine("Введите год:");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите месяц:");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите день:");
        int day = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите час:");
        int hour = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите минуту:");
        int minute = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите секунду:");
        int second = Convert.ToInt32(Console.ReadLine());
        DateTime firstPoint = new DateTime(year, month, day, hour, minute, second);
        Console.Clear();
        Console.WriteLine("Введем вторую дату.");
        Console.WriteLine("Введите год:");
        year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите месяц:");
        month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите день:");
        day = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите час:");
        hour = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите минуту:");
        minute = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите секунду:");
        second = Convert.ToInt32(Console.ReadLine());
        DateTime secondPoint = new DateTime(year, month, day, hour, minute, second);
        var calend = new Calendar(firstPoint, secondPoint);
        calendarDict[calendarName] = calend;
    }
    if (key.Key == ConsoleKey.D2)
    {

        Console.WriteLine("Введем дату:");
        Console.WriteLine("Введите год:");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите месяц:");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите день:");
        int day = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите час:");
        int hour = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите минуту:");
        int minute = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите секунду:");
        int second = Convert.ToInt32(Console.ReadLine());
        DateTime selectDate = new DateTime(year, month, day, hour, minute, second);
        Console.WriteLine($"День недели:{selectDate.DayOfWeek}");
        Console.WriteLine("Нажмите чтобы продолжить...");
        Console.ReadLine();
    }
    if (key.Key == ConsoleKey.D3)
    {
        Console.WriteLine("Введите название календаря");
        string selectCalendar = Console.ReadLine();
        if (calendarDict.ContainsKey(selectCalendar))
        {
            Console.WriteLine("Введите день недели на английском:");
            string selectDayWeek = Console.ReadLine();
            DateTime usDate = calendarDict[selectCalendar].firstPoint;
            while (usDate <= calendarDict[selectCalendar].secondPoint)
            {
                usDate = usDate.AddDays(1);
                if (Convert.ToString(usDate.DayOfWeek) == selectDayWeek)
                {

                    Console.WriteLine($"{usDate.Day} {usDate.Month} {usDate.Year} ");
                }


            }
            Console.WriteLine("Нажмите для продолжения...");
            Console.ReadLine();
        }

        else
        {
            Console.WriteLine("Календарь не найден...");
            Console.ReadLine();
        }

    }
    if (key.Key == ConsoleKey.D4)
    {
        break;
    }

}

public class Calendar
{
    public DateTime firstPoint;

    public DateTime secondPoint;

    public Calendar(DateTime firstPoint, DateTime secondPoint)
    {
        this.firstPoint = firstPoint;
        this.secondPoint = secondPoint;
    }
}
