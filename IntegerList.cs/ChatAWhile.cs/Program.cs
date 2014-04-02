using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatAWhile.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zip = new int[6] { 262, 414, 608, 715, 815, 920};
            double[] price = new double[6] { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };
            double sum = 0;

            for (int i = 0; i < zip.Length; i++)
            {
                Console.WriteLine(zip[i]);
            }

            Console.Write("Enter youyr zipcode if listed: ");
            String input = Console.ReadLine();
            int n = Convert.ToInt32(input);
            
            

            for (int x = 0; x < zip.Length; x++)
            {
                
                if (n == zip[x])
                {
                    Console.Write("Enter the amount of minutes: ");
                    input = Console.ReadLine();
                    int t = Convert.ToInt32(input);
                    sum = price[x] * t;

                    Console.WriteLine("The cost would be {0}", sum.ToString("C"));
                }

                
            }

           

            
            
        }
    }
}
