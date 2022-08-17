using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

/* Учусь ислоьзовать точки останова. */

namespace Ch07Ex01
{
    internal class Program
    {
        static int Maxima(int[] integers, out int[] indices)
        {
            indices = new int[1];
            int maxVal = integers[0];
            indices[0] = 0;
            int count = 1;            

            for (int i = 1; i < integers.Length; i++)
            {                
                if (integers[i] > maxVal)
                {
                    maxVal = integers[i];
                    count = 1;
                    indices = new int[1];
                    indices[0] = i;                    
                }
                else
                {
                    if (integers[i] == maxVal)
                    {
                        count++;
                        int[] oldIndices = indices;
                        indices = new int[count];
                        oldIndices.CopyTo(indices, 0);
                        indices[count - 1] = i;                        
                    }
                }
            }                     
            return maxVal;
        }
        static void Main(string[] args)
        {
            int[] testArray = { 4, 7, 4, 2, 7, 9, 7, 8, 3, 9, 1, 9 };
            int[] maxValIndices;
            int maxVal = Maxima(testArray, out maxValIndices);
            Console.WriteLine("Maximum value {0} found at element indices:", maxVal);
            foreach (int index in maxValIndices)
            {
                Console.WriteLine(index);
            }
            Console.ReadKey();
        }


    }
}
