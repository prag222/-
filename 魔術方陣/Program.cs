using System;

namespace 魔術方陣
{
    class Program
    {
        public static int n = 5;
        public static int[,] matrix= new int[n,n];
        static void Main(string[] args)
        {
            Magic();
            for(int i=0;i<n;i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]+" ");
                }
                Console.WriteLine("");
            }
        }
        public static void Magic()
        {
            int i, j, p, q, key;
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    matrix[i,j] = 0;

            matrix[0,(n - 1) / 2] = 1;

            key = 2;
            i = 0;
            j = (n - 1) / 2;
            while(key<=n*n)
            {
                p = (i - 1) % n;
                q = (j - 1) % n;
                if (p < 0) p = n - 1;
                if (q < 0) q = n - 1;
                if (matrix[p, q] != 0)
                    i = (i + 1) % n;
                else
                {
                    i = p;
                    j = q;
                }
                matrix[i, j] = key;
                key++;
            }

        }
    }
}
