using System;

namespace lab_06
{
    class Program
    {
        static char [] ArrRev(ref char [] arr)
        {
            int lenght = arr.Length-1;
            char[] newarr = new char[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newarr[i] = arr[lenght - i];
            }
            return arr = newarr;
        }
        static char[] ReverseStr(string arr)
        {
            char[] arrev = arr.ToCharArray();
            arrev = ArrRev(ref arrev);
            return arrev;
        }

        static char[] ReverseInt(int arr)
        {
            string arrr = arr.ToString();
            char[] arrev = arrr.ToCharArray();
            arrev = ArrRev(ref arrev);
            return arrev;
        }

        static void ReverseDec(string arr)
        {
            string[] splitted = arr.Split(new char[] {'.'});
            
            for(int i = 0; i < splitted.Length; i++)
            {
                string str = splitted[i];
                char[] arrev = str.ToCharArray();
                arrev = ArrRev(ref arrev);
                Console.Write(arrev);
                if (i != splitted.Length-1)
                {
                    Console.Write(".");
                }

            }
        }
        
        static void RevAndSplit(string arr)
        {
            string[] splitted = arr.Split(new char[] {','});
            
            for(int i = 0; i < splitted.Length; i++)
            {
                string str = splitted[i];
                char[] arrev = str.ToCharArray();
                arrev = ArrRev(ref arrev);
                Console.Write(arrev);
                if (i != splitted.Length-1)
                {
                    Console.Write(",");
                }

            }

        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Введіть ціле число:\t");
            char[] ar = ReverseStr (Console.ReadLine());
            Console.WriteLine(ar);

            Console.WriteLine("Введіть букви:\t");
            char[] str = ReverseStr (Console.ReadLine());
            Console.WriteLine(str);
            
            Console.WriteLine("Введіть дробове число розділяючи дріб знаком '.':\t");
            ReverseDec (Console.ReadLine());

            Console.WriteLine("Введіть букви розділяючи їх знаком ',':\t");
            RevAndSplit(Console.ReadLine());

            Console.ReadLine();
        }
    }
}