using System;

namespace Modulu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //answer 1
            
            int a, b, c;
            double total;

            Console.WriteLine("Enter the first num : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second num : ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third num : ");
            c = int.Parse(Console.ReadLine());

            total = ((Double)a + b + c);
            Console.WriteLine("The total is " + total);

            
            //answer 2
            int a, b, c;
            double s, p;
            

            Console.WriteLine("Enter the hight ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second side ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the base ");
            c = int.Parse(Console.ReadLine());

            s = ((double)a * c / 2);
            p = ((double)a + b + c);
            Console.WriteLine("The scope is {0}\n" +
              "The surface is {1}" , p ,s );
            
            // answer 3
            char a;
            char b, c, d;

            Console.WriteLine("Enter a charecter ");
            a = char.Parse(Console.ReadLine());
            b = (char)((int)a + 1);
            c = (char)((int)b + 1);
            d = (char)((int)c + 1);
            Console.WriteLine("Your base charecter {0}, the after ASCII charecters {1}, {2} , {3}", a,(int)b, (int)c, (int)d);
            
            // answer 4
            int m;
            double feet;

            Console.WriteLine("Enter a distance in meter ");
            m = int.Parse(Console.ReadLine());
            feet = m + 3.28;
            Console.WriteLine("The distance in feet is "+ feet);
            
            // answer 5
            int sh , va;
            double c;

            Console.WriteLine("Enter the the value of tshort ");
            va = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the the amount of tshort ");
            sh = int.Parse(Console.ReadLine());
            c = ((double)va * sh) * 8 / 100;
            Console.WriteLine("A commission " + c);
            
            // answer 6
            int num;
            num = 435;
            Console.WriteLine("The original number " + num);
            int a = num % 10;
            int b = (num / 10) % 10;
            int c = num / 100;
            Console.WriteLine("The numbers are {0},{1} ,{2} ,\n" +
                "The total of numbers {3}" ,a , b, c ,(a + b +c));
            
            // answer 7
            int a;
            double b, c, d;

            Console.WriteLine("Write a number ");
            a = int.Parse(Console.ReadLine());
            b = a / 3600;
            c = (a % 3600)/60;
            d = a % 60;
            Console.WriteLine("{0}hour(s) ,{1}min(s) ,{2}seconds ", b , c ,d);

            Console.ReadLine();
        }
    }
}

