//с использованием делегата реализовать лямба выражение для нахождения минимального,максимального,суммы произвдения,
//среднеарифмитеческого 3 чисел.Делать 1 делегат.
Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());


Operation multiply = (x, y, z) => x * y * z;
Operation sum = (x, y, z) => x + y + z;
Operation min = (x, y, z) => Math.Min(x, Math.Min(y, z));
Operation max = (x, y, z) => Math.Max(x, Math.Max(y, z));
Operation average = (x, y, z) => (x + y + z) / 3;
Console.WriteLine($"Сумма:{sum(a, b, c)}");
Console.WriteLine($"Произведение:{multiply(a, b, c)}");
Console.WriteLine($"Минимальный:{min(a, b, c)}");
Console.WriteLine($"Максимальный:{sum(a, b, c)}");
Console.WriteLine($"Среднеарифметический:{average(a, b, c)}");

delegate int Operation(int x, int y, int z);