using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementDecrement
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            //Code was added in GitHub
            //Code was added in VS

            //Code to call Feature1

            //Code to call Feature 3
            
            int nn = 8;
            int ee = -3;
            int u;


            u = --ee + 2 * nn++;
            //Console.WriteLine($"u = {u}");

            //u = 12  ee = -4  nn = 9

            u += (++nn - ee++);

            //n = 10  ee = -3  u = 26


            

            /*
            int i = 0;
            i--;
            //i = i + ++i;
            Console.WriteLine($"i = {i} ");
            */

            /*
            int i = -9;
            int result = i;

            if (i <= -9 || i> -1)
            {
                result = 1;

            }
            if(i>3 && i<=7)
            {
                result = 2; 
            }
            Console.WriteLine($"res = {result} ");
            */

            /*
            string str = "\0";
            bool b = string.IsNullOrEmpty (str) ;
            Console.WriteLine($"b = {b} ");
            */

            /*
            int n = 3;
            int sum = 0;
            for (int i=n; i>=0; i--)
            {
                sum += 2 * i;

            }
            */

            /*
            int i = 0;
            i += ++i + i++; 
            Console.WriteLine($"b = {i} ");
            */

            /*
            bool x= true;
            bool y= false;
            Console.WriteLine($"b = {x | !y} ");
            */
            /*
            string str = "        ";
            bool b = string.IsNullOrWhiteSpace(str);
            Console.WriteLine(b);
            */

            //string str = @"-""\""\""-";
            string str = "\\Robot Joe!\\";
            Console.WriteLine(str);


        


            Console.ReadKey();  


        }
    }
}
