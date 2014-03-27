using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] num = new int[5] { 3, 4, 1, 2, 5 };

            for (int n = 0; n < 5; n++)
            {
                Array.Sort(num);
                Console.Write(num[n] + " ");
                
            }
            for(int i = 0; i < 5; i++)
            {
             
                Array.Sort(num);
   
              Array.Reverse(num);
               Console.Write(num[i] + " ");
            }

            
            
        }
    }
}
