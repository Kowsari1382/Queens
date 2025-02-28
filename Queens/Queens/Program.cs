using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queens
{
    class Program
    {
        static int n;
        static int[] col;
        static int[] column;
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, input number of queens:");
            n = Convert.ToInt32(Console.ReadLine());
            col = new int[n];
            column = new int[n];
            Console.WriteLine("input column of first queen:");
            col[0] = Convert.ToInt32(Console.ReadLine()) - 1;
            queens(0);
            /*for(int counter = 0; counter < n; counter++)
            {
                int counter2 = counter + 1;
                int col2 = column[counter] + 1;
                Console.WriteLine("line:" + counter2 + " " + "column:" + col2);
            }*/
            Console.WriteLine("good luck!");
            Console.ReadKey();
        }
        public static void queens(int i)
        {
            if(promising(i))
            {
                if(n==i+1)
                {
                    /*for (int c = 0; c < n; c++)
                    {
                        column[c] = col[c];
                    }*/
                    for(int counter = 0; counter < n; counter++)
                    {
                        int counter2 = counter + 1;
                        int col2 = col[counter] + 1;
                        Console.WriteLine("line:" + counter2 + " " + "column:" + col2);
                    }
                    Console.WriteLine();
                }
                else
                {
                    for(int j=0;j<n;j++)
                    {
                        col[i + 1] = j;
                        queens(i + 1);
                    }
                }
            }
        }
        public static bool promising(int i)
        {
            int k = 0;
            bool sw = true;
            while (k < i && sw)
            {
                if(col[i]==col[k] || Math.Abs(col[i]-col[k])==i-k)
                {
                    sw = false;
                }
                k++;
            }
            return sw;
        }
    }
}
