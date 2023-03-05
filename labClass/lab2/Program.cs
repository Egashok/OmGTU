using Class;
List<Student> stList = new List<Student>();
List<Teacher> teList = new List<Teacher>();
List<Support> suList = new List<Support>();
List<Managers> maList = new List<Managers>();
List<Order> orList = new List<Order>();
List<Student> debtList = new List<Student>();

Console.Clear();
while (true)
{
    Console.Clear();
    Console.WriteLine("1.Добавить личность");
    Console.WriteLine("2.Узнать информацию");
    Console.WriteLine("3.Добавить указ");
    Console.WriteLine("0.Выход");

    ConsoleKeyInfo key;
    key = Console.ReadKey();
    if (key.Key == ConsoleKey.D1)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1.Добавить студента");
            Console.WriteLine("2.Добавить преподавателя");
            Console.WriteLine("3.Добавить управляющих");
            Console.WriteLine("4.Добавить вспомогательный персонал");
            Console.WriteLine("0.В меню");
            ConsoleKeyInfo keyPeople;
            keyPeople = Console.ReadKey();
            if (keyPeople.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Student st = new Student();
                Console.WriteLine("Введите ФИО студента:");
                st.name = Console.ReadLine();
                Console.WriteLine("Введите дату рождения студента:");
                st.birth = Console.ReadLine();
                Console.WriteLine("Введите количество оценок:");
                st.marks = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < st.marks; i++)
                {
                    Console.WriteLine("Введите ФИО преподавателя:");
                    st.myTeachers.Add(Console.ReadLine());
                    Console.WriteLine("Введите названия предмета:");
                    st.mySubjects.Add(Console.ReadLine());
                    Console.WriteLine("Введите оценку по предмету:");
                    st.myMarks.Add(Convert.ToInt32(Console.ReadLine()));
                }
                stList.Add(st);

            }
            else if (keyPeople.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Teacher te = new Teacher();
                Console.WriteLine("Введите ФИО преподавателя:");
                te.name = Console.ReadLine();
                Console.WriteLine("Введите дату рождения преподавателя:");
                te.birth = Console.ReadLine();
                Console.WriteLine("Введите какие предметы он введет:");
                te.subjects.AddRange(Console.ReadLine().Split());
                Console.WriteLine("Введите прошлые места работы и стаж :");
                string placeAndStage = Console.ReadLine();
                for (int i = 0; i < placeAndStage.Split().Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        te.placeWorks.Add(placeAndStage.Split()[i]);
                    }
                    else
                    {
                        te.stage.Add(Convert.ToInt32(placeAndStage.Split()[i]));
                    }

                }

                teList.Add(te);
            }
            else if (keyPeople.Key == ConsoleKey.D3)
            {
                Console.Clear();
                Managers ma = new Managers();
                Console.WriteLine("Введите ФИО управляющего:");
                ma.name = Console.ReadLine();
                Console.WriteLine("Введите дату рождения управляющего:");
                ma.birth = Console.ReadLine();
                Console.WriteLine("Введите ФИО управляющего:");
                ma.job = Console.ReadLine();
                maList.Add(ma);
            }
            else if (keyPeople.Key == ConsoleKey.D4)
            {
                Console.Clear();
                Support su = new Support();
                Console.WriteLine("Введите ФИО управляющего:");
                su.name = Console.ReadLine();
                Console.WriteLine("Введите дату рождения управляющего:");
                su.birth = Console.ReadLine();
                suList.Add(su);

            }
            else if (keyPeople.Key == ConsoleKey.D0)
            {
                break;
            }

        }


    }
    if (key.Key == ConsoleKey.D2)
    {


        while (true)
        {
            Console.Clear();
            Console.WriteLine("1.Список студентов с долгами");
            Console.WriteLine("2.Преподаватель долги студентов ");
            Console.WriteLine("3.Приказы");
            Console.WriteLine("4.Список дисциплин для преподавателя");
            Console.WriteLine("5.Стаж преподавателя");
            Console.WriteLine("0.В меню");
            ConsoleKeyInfo choice;
            choice = Console.ReadKey();
            if (choice.Key == ConsoleKey.D1)
            {
                List<string> markDebt = new List<string>();
                string marksStr = "";
                Console.Clear();

                foreach (Student stud in stList)
                {


                    marksStr = "";
                    foreach (int mark in stud.myMarks)
                    {
                        if (mark == 2)
                        {
                            debtList.Add(stud);
                            marksStr = (Convert.ToString(stud.myMarks.IndexOf(mark)) + " ");

                        }

                    }
                    if (marksStr != "")
                    {
                        markDebt.Add(marksStr);
                    }
                }


                foreach (Student stud in debtList)
                {
                    Console.WriteLine(debtList.IndexOf(stud) + 1);
                    Console.WriteLine(stud.name);
                    foreach (string i in markDebt)
                    {
                        int score = 0;
                        int[] z = new int[i.Split().Length];
                        foreach (string k in i.Split())
                        {
                            if (k != null && k != " " && k != "")
                            {

                                z[score] = Convert.ToInt32(k);
                                score += 1;
                            }
                        }
                        foreach (int j in z)
                        {
                            Console.WriteLine(stud.mySubjects[j]);
                            Console.WriteLine(stud.myTeachers[j]);
                        }

                    }

                }
                Console.WriteLine("Нажмите для продолжения...");
                Console.ReadLine();

            }
            if (choice.Key == ConsoleKey.D2)
            {

                Console.Clear();
                string fioPrep = Console.ReadLine();
                foreach (Student st in stList)
                {
                    List<int> prepodSubj = new List<int>();
                    foreach (string i in st.myTeachers)
                    {
                        if (i == fioPrep)
                        {

                            if (st.myTeachers.IndexOf(i) == 2)
                            {
                                prepodSubj.Add(st.myTeachers.IndexOf(i));
                            }
                        }
                    }
                    Console.WriteLine(st.name);
                    foreach (int j in prepodSubj)
                    {
                        Console.WriteLine(st.mySubjects[j]);
                        Console.WriteLine(st.myMarks[j]);
                    }
                    Console.WriteLine("=====");
                }
                Console.WriteLine("Нажмите для продолжения...");
                Console.ReadLine();



                // hubabuba
            }
            if (choice.Key == ConsoleKey.D3)
            {

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("1.Приказы для студентов");
                    Console.WriteLine("2.Приказы для преподавателей");
                    Console.WriteLine("3.Приказы для спец.персонала");
                    Console.WriteLine("4.Приказы общие");
                    Console.WriteLine("0.Выход");

                    ConsoleKeyInfo orKey;
                    orKey = Console.ReadKey();
                    if (orKey.Key == ConsoleKey.D1)
                    {
                        Console.Clear();
                        int index = 1;
                        foreach (Order ord in orList)
                        {
                            if (ord.reciever == "Студенты")
                            {
                                Console.Write(index);
                                Console.Write(ord.sender);
                                Console.WriteLine(ord.job);
                                Console.WriteLine(ord.ordText);
                                index++;
                                Console.WriteLine("");
                            }
                        }
                        Console.WriteLine("Нажмите для продолжения...");
                        Console.ReadLine();
                    }
                    if (orKey.Key == ConsoleKey.D2)
                    {
                        Console.Clear();
                        int index = 1;
                        foreach (Order ord in orList)
                        {
                            if (ord.reciever == "Преподаватели")
                            {
                                Console.Write(index);
                                Console.Write(ord.sender);
                                Console.WriteLine(ord.job);
                                Console.WriteLine(ord.ordText);
                                index++;
                                Console.WriteLine("");
                            }
                        }
                        Console.WriteLine("Нажмите для продолжения...");
                        Console.ReadLine();
                    }
                    if (orKey.Key == ConsoleKey.D3)
                    {
                        Console.Clear();
                        int index = 1;
                        foreach (Order ord in orList)
                        {
                            if (ord.reciever == "Спец.персонал")
                            {
                                Console.Write(index);
                                Console.Write(ord.sender);
                                Console.WriteLine(ord.job);
                                Console.WriteLine(ord.ordText);
                                index++;
                                Console.WriteLine("");


                            }

                        }
                        Console.WriteLine("Нажмите для продолжения...");
                        Console.ReadLine();
                    }
                    if (orKey.Key == ConsoleKey.D4)
                    {
                        Console.Clear();
                        int index = 1;
                        foreach (Order ord in orList)
                        {
                            Console.Write(index);
                            Console.Write(ord.sender);
                            Console.WriteLine(ord.job);
                            Console.WriteLine(ord.ordText);
                            index++;
                            Console.WriteLine("");

                        }
                        Console.WriteLine("Нажмите для продолжения...");
                        Console.ReadLine();
                    }
                    if (orKey.Key == ConsoleKey.D0)
                    {
                        Console.Clear();
                        break;
                    }
                }

            }
            if (choice.Key == ConsoleKey.D4)
            {
                Console.Clear();
                string fio = Console.ReadLine();
                foreach (Teacher prepod in teList)
                {
                    if (fio == prepod.name)
                    {
                        foreach (string discip in prepod.subjects)
                        {
                            Console.WriteLine(discip);
                        }
                    }
                }
                Console.WriteLine("Нажмите для продолжения...");
                Console.ReadLine();


            }
            if (choice.Key == ConsoleKey.D5)
            {
                Console.Clear();
                string who = Console.ReadLine();
                int sumStage = 0;
                string place = "";
                foreach (Teacher tech in teList)
                {
                    if (who == tech.name)
                    {

                        foreach (int i in tech.stage)
                        {
                            sumStage += i;
                        }
                        Console.WriteLine($"Общий стаж:{sumStage}");
                        Console.WriteLine($"Прошлое место работы:{tech.placeWorks[tech.placeWorks.Count]} стаж:{tech.stage[tech.stage.Count]}");
                    }
                }

                Console.WriteLine("Нажмите для продолжения...");
                Console.ReadLine();
            }
            if (choice.Key == ConsoleKey.D0)
            {
                Console.Clear();
                break;
            }
        }
    }
    if (key.Key == ConsoleKey.D3)
    {
        Console.Clear();
        Order or = new Order();
        Console.WriteLine("Введите ФИО управляющего:");
        or.sender = Console.ReadLine();
        Console.WriteLine("Введите должность управляющего:");
        or.job = Console.ReadLine();
        Console.WriteLine("Введите кому направлен:");
        or.reciever = Console.ReadLine();
        Console.WriteLine("Введите текст указа:");
        or.ordText = Console.ReadLine();
        orList.Add(or);
    }
    if (key.Key == ConsoleKey.D0)
    {

        break;
    }
}