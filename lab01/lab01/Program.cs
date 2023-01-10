using System;

class Program
{
    static void Main(string[] args)
    {
        double height, quick_fall;
        quick_fall = 9.81;
        
        Console.Write("Введіть висоту в метрах з якої падає тіло:");
        
        height = double.Parse(Console.ReadLine());
        double timefall = Math.Sqrt(2 * height / quick_fall);
        
        Console.WriteLine($"Тіло впаде через {timefall} секунди");
        
        Console.ReadLine();
    }
}
