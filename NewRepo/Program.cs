using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NewRepo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CallConvThiscall is important for debugging .do NotFiniteNumberException remove
            /* thi is 
             important for debugging */


            //Data types in c sharp
            //1 integer - int ayan 4byte
            //long == 8 byte
            //2floating point number = float that; 4byte
            //Double = 8 byte
            //3character = char isGreat = 'A'; 2byte
            //Boolean = bool is great = true; 1bit
            //string = string inp = "ayan"; 2byte per character

            //int ayan = 34;
            //string inp = Console.ReadLine();
            //Console.WriteLine(inp+inp);
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello Ayan!");
            //Console.WriteLine("I love C Sharp " + ayan);


            //data type
            //int a = 34;
            //float b = 34.4f;
            //double c = 34.411d;
            //bool isGreat = true;
            //char isAlpa = 'a';
            //string isWord = "This is a string";

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(isGreat);
            //Console.WriteLine(isAlpa);
            //Console.WriteLine(isWord);

            //Type Casting
            //there are two types of typeCasting
            //1, implicite casting
            //char to int to long to float to double
            int x = 3;
            double y = x;
            int z = 'y';
            Console.WriteLine(x);
            Console.WriteLine(z);


            //2. explicit casting
            int a = (int) 4.5;
            Console.WriteLine(a);
            float b = 'y';
            float var = Convert.ToInt32(4.55);
            Console.WriteLine(var);





            Console.ReadLine();
        }
    }
}
