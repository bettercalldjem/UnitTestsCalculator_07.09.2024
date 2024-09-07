Console.WriteLine("Введите ваши числа: ");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Выберите операцию: + - * /");
char c = char.Parse(Console.ReadLine());
switch (c)
{
    case '+':
        Console.WriteLine($"{a} + {b} = {a+b}");
        break;
    case '-':
        Console.WriteLine($"{a} - {b} = {a - b}");
        break;
    case '*':
        Console.WriteLine($"{a} * {b} = {a * b}");
        break;
    case '/':
        Console.WriteLine($"{a} / {b} = {a / b}");
        break;
}