internal class Program
{
    private static void Main(string[] args)
    {
        bool run = true;
        List<Books> archive = new List<Books>();

        while (run)
        {
            Console.Clear();
            Console.WriteLine("1.Заполнение");
            Console.WriteLine("2.Выбор по издательству");
            Console.WriteLine("3.Выбор по автору");
            Console.WriteLine("4.Выбор по жанру");
            Console.WriteLine("5.Книги на руках");
            Console.WriteLine("6.Книги на руках в интервале");
            Console.WriteLine("7.Выход");

            int key = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (key)
            {
                case 1:
                    archive = zapolnenie();
                    break;

                case 2:

                    parseIzdatel(archive);
                    break;
                case 3:
                    parseAuthor(archive);
                    break;
                case 4:
                    parseZhanr(archive);
                    break;
                case 5:
                    busyBook(archive);
                    break;
                case 6:
                    busyBookInterval(archive);
                    break;
                case 7:
                    run = false;
                    break;
            }
        }

        void parseIzdatel(List<Books> arch)
        {
            if (arch.Count != 0)
            {
                Console.WriteLine("Введите название издательства:");
                string? izdatel = Console.ReadLine();
                foreach (Books obj in arch)
                {

                    if (obj.izdatel == izdatel)
                    {
                        Console.Write($"{obj.author};");
                        Console.Write($"{obj.name};");
                        Console.Write($"{obj.year};");
                        Console.Write($"{obj.id};");
                        Console.Write($"{obj.izdatel};");
                        Console.WriteLine();
                    }

                }
                Console.WriteLine("Нажмите чтобы продолжить...");
                string? s = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Заполните сначала архив");
                Console.WriteLine("Нажмите чтобы продолжить...");
                string? s = Console.ReadLine();
            }
        }
        void parseAuthor(List<Books> arch)
        {
            if (arch.Count != 0)
            {
                Console.WriteLine("Введите имена автора:");
                string? author = Console.ReadLine();
                foreach (Books obj in arch)
                {

                    if (obj.author == author)
                    {
                        Console.Write($"{obj.author};");
                        Console.Write($"{obj.name};");
                        Console.Write($"{obj.year};");
                        Console.Write($"{obj.id};");
                        Console.Write($"{obj.izdatel};");
                        Console.WriteLine();

                    }

                }
                Console.WriteLine("Нажмите чтобы продолжить...");
                string? s = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Заполните сначала архив");
                Console.WriteLine("Нажмите чтобы продолжить...");
                string? s = Console.ReadLine();
            }
        }
        void parseZhanr(List<Books> arch)
        {
            if (arch.Count != 0)
            {
                Console.WriteLine("Введите название жанра:");
                string? zhanr = Console.ReadLine();
                foreach (Books obj in arch)
                {

                    if (obj.zhanr == zhanr)
                    {
                        Console.Write($"{obj.author};");
                        Console.Write($"{obj.name};");
                        Console.Write($"{obj.year};");
                        Console.Write($"{obj.id};");
                        Console.Write($"{obj.izdatel};");
                        Console.WriteLine();

                    }

                }
                Console.WriteLine("Нажмите чтобы продолжить...");
                string? s = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Заполните сначала архив");
                Console.WriteLine("Нажмите чтобы продолжить...");
                string? s = Console.ReadLine();
            }
        }
        void busyBook(List<Books> arch)
        {
            if (arch.Count != 0)
            {
                foreach (Books obj in arch)
                {


                    if ((obj.setVidacha.Count != 0 && obj.setOtprav.Count != 0) || (obj.setVidacha.Count > obj.setOtprav.Count))
                    {
                        Console.Write($"{obj.author};");
                        Console.Write($"{obj.name};");
                        Console.Write($"{obj.year};");
                        Console.Write($"{obj.id};");
                        Console.Write($"{obj.izdatel};");
                        Console.WriteLine();

                    }
                }
                Console.WriteLine("Нажмите чтобы продолжить...");
                string? s = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Заполните сначала архив");
                Console.WriteLine("Нажмите чтобы продолжить...");
                string? s = Console.ReadLine();
            }
        }
        void busyBookInterval(List<Books> arch)
        {
            if (arch.Count != 0)
            {
                var firstInterval = DateTime.Parse(Console.ReadLine());
                var lastInterval = DateTime.Parse(Console.ReadLine());

                foreach (Books obj in arch)
                {


                    foreach (string v in obj.setVidacha)
                    {
                        var DaVidal = DateTime.Parse(v);
                        foreach (string o in obj.setOtprav)
                        {
                            var DaOtprav = DateTime.Parse(o);
                            if (firstInterval > DaVidal && lastInterval < DaOtprav)
                            {
                                Console.Write($"{obj.author};");
                                Console.Write($"{obj.name};");
                                Console.Write($"{obj.year};");
                                Console.Write($"{obj.id};");
                                Console.Write($"{obj.izdatel};");
                                break;
                            }

                        }
                    }


                }
                Console.WriteLine("Нажмите чтобы продолжить...");
                string? s = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Заполните сначала архив");
                Console.WriteLine("Нажмите чтобы продолжить...");
                string? s = Console.ReadLine();
            }
        }
        List<Books> zapolnenie()
        {
            Console.WriteLine("Введите количество книг");
            int n = Convert.ToInt32(Console.ReadLine());
            List<Books> archive = new List<Books>();

            for (int i = 0; i < n; i++)
            {
                Books book = new Books();

                Console.Write("Введите автора:");
                book.author = Console.ReadLine();
                Console.Write("Введите название произведения:");
                book.name = Console.ReadLine();
                Console.Write("Введите id книги:");
                book.id = Console.ReadLine();
                Console.Write("Введите год издания:");
                book.year = Console.ReadLine();
                Console.Write("Введите названия издательства:");
                book.izdatel = Console.ReadLine();
                Console.Write("Введите жанр:");
                book.zhanr = Console.ReadLine();
                Console.Write("Введите дату выдачи:");
                string vid = Console.ReadLine();
                for (int j = 0; j < vid.Split().Length; j++)
                {
                    book.setVidacha.Add(vid.Split()[j]);
                }
                Console.Write("Введите дату сдачи:");
                string otp = Console.ReadLine();
                for (int j = 0; j < otp.Split().Length; j++)
                {
                    book.setOtprav.Add(otp.Split()[j]);
                }
                archive.Add(book);
            }
            return archive;
        }
    }
}

public class Books
{
    public string? author, name, year, id, izdatel, zhanr;
    public List<string> setVidacha = new List<string>();
    public List<string> setOtprav = new List<string>();
}
