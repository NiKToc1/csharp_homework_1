Console.Clear(); 
Console.Write("Введите 1-ое число: "); 
int a = int.Parse(Console.ReadLine()!); 
Console.Write("Введите 2-ое число: "); 
int b = int.Parse(Console.ReadLine()!); 
if (a > b) 
    Console.WriteLine($"{a} больше, чем {b}"); 
else Console.WriteLine($"{b} больше, чем {a}");