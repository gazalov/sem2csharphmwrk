Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int x = int.Parse(Console.ReadLine());
x = (x/10) % 10;
Console.WriteLine($"Вторая цифра введенного числа: {x}.");
