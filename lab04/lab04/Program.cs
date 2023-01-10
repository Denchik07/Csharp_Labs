using System;

class Program
{
    static void removeEl(ref int[] array, int index)
    {
        int[] newArray = new int[array.Length - 1];
        for (int i = 0; i < index; i++)
        {
            newArray[i] = array[i];
        }

        for (int i = index; i < array.Length; i++)
        {
            newArray[i - 1] = array[i];
        }
        array = newArray;
    }
    static void Main()
    {
        int[] myArray = { 2, 2, 2, 2, 0, 4, 4, 2, 1, 1 };
        int[] indexestodel = new int[myArray.Length];
        int indexes = 0;
        int lastindex;
        
        for (int i = 1; i < myArray.Length-1; i++)
        {
            if (myArray[i] == myArray[i - 1] && myArray[i] != myArray[i + 1])
            {
                indexestodel[indexes] = i;
                indexes++;
            }
        }

        for (int i = 0; i < indexes; i++)
        {
            removeEl(ref myArray, indexestodel[i]);
        }

        lastindex = myArray.Length - 1;
        
        if (myArray[lastindex]  == myArray[lastindex - 1])
        {
            removeEl(ref myArray, lastindex);
        }
            
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i]+" ");
        }
        
        Console.ReadKey();
    }
}