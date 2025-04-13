using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
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

            //int x = 3;
            //double y = x;
            //int z = 'y';
            //Console.WriteLine(x);
            //Console.WriteLine(z);


            //2. explicit casting
            //int a = (int) 4.5;
            //Console.WriteLine(a);
            //float b = 'y';
            //float var = Convert.ToInt32(4.55);
            //string sx = "Random String";
            //Console.WriteLine(var);
            //Console.WriteLine(b);
            //Console.WriteLine(sx);

            //Console.WriteLine("Enter your Name");
            //string name =  Console.ReadLine();
            //Console.WriteLine("Hey Hello " + name); 

            //Console.WriteLine("How many candies do you want");
            //int can = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("You will get 4 more candies " + (can+4));

            // Operators in c#
            // 1. Arithemetic Operator
            // 2. assignment operator
            // 3.Logical operator
            // 4. comarison operator


            //Arithmetic operator
            //int a = 4;
            //int b = 2;
            //Console.WriteLine("The value of a + b is : " + (a + b));
            //Console.WriteLine("The value of a + b is : " + (a - b));
            //Console.WriteLine("The value of a + b is : " + (a / b));
            //Console.WriteLine("The value of a + b is : " + (a * b));

            //Assignment operator
            //int a = 4;
            //int b = a;
            //b -= 4;
            //b += 4;
            //b *= 4;
            //b /= 4;
            //Console.WriteLine(b);

            //Logical Operator
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //Console.WriteLine(true || false);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);


            //Console.WriteLine(!false);
            //Console.WriteLine(!true);

            //Comparison operator
            //Console.WriteLine(324>555);
            //Console.WriteLine(324>=555);
            //Console.WriteLine(324<=555);
            //Console.WriteLine(324!=555);
            //Console.WriteLine(324==555);

            //Math
            //int a = Convert.ToInt16( Math.Sqrt(4));//min,sqrt,abs
            //Console.WriteLine(a);

            //String method
            //string hello = "Hello world this is Ayan";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(string.Concat(hello," You are nice"));

            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();
            //console.writeline($"your name is {name}. you will get {candies} candies");

            string hello = "Hello world this is Ayan";
            Console.WriteLine(hello[1]);
            Console.WriteLine(hello.IndexOf("is"));
            Console.WriteLine(hello.Substring(1));


            Console.ReadLine();
        }
    }
}
