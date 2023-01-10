using System;

class Program
{
    static void Main(string[] args)
    {
        int x1, x2, ourx, y1, y2, oury;
        x1 = 6;
        x2 = -7;
        y1 = 5;
        y2 = -4;
        
        ourx = int.Parse(Console.ReadLine());
        oury = int.Parse(Console.ReadLine());

        if (ourx < x1 && ourx > x2)
        {
            if (oury < y1 && oury > y2)
            {
                Console.WriteLine("Ваша точка в прямокутнику");
            }
            else
            {
                Console.WriteLine("Ваша точка поза прямокутником або на границі");
            }
        }
        else
        {
            Console.WriteLine("Ваша точка поза прямокутником або на границі");
        }
    }
}