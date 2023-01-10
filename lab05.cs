using System;

class lab05
{
    
    static void Main()
    {
        int [,] myarr = new int[,]
        {
            { 3, 2, 4, 5, 3 },
            { 7, 423, 3453, 2, 56 },
            {4,345,4,6,1},
            {76,4,8,23,3}
        };
        int maxindexi, maxindexj;
        int maxvalue = 0;
        int width = myarr.GetLength(0);
        int height = myarr.GetLength(1);
        
        for (int i=0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (myarr[i, j] > maxvalue)
                {
                    maxindexi = i;
                    maxindexj = j;
                }
            }
        }
    }
}
