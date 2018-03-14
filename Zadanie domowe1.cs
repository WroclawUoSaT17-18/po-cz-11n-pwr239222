using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace figury
{
    class kalkulator_figur
    {
        static void Main(string[] args)
        {
        Start:
            Console.WriteLine("Witaj w programie liczacym pola i objetosci figur przestrzennych \n");
            Console.WriteLine("1. Wybierz figure: \n 1) szescian \n 2) stozek \n");
            char caseSwitch = Char.Parse(Console.ReadLine());
            if (char.IsNumber(caseSwitch))
            {
                switch (caseSwitch)
                {
                    case '1':
                        Console.WriteLine("2. Podaj wymiary w cm:\n a =");
                        Console.SetCursorPosition(5, 8);
                        float a = float.Parse(Console.ReadLine());
                        
                        
                        szescian szescian1 = new szescian(a);
                        Console.WriteLine(" ");
                        Console.WriteLine("3. Parametry szescianu:");
                        Console.WriteLine("P = {0}", szescian1.Vol());
                        Console.WriteLine("V = {0}\n", szescian1.Area());
                        Console.ReadKey();
                        Console.Clear();
                        goto Start;
                    case '2':
                        Console.WriteLine("2. Podaj wymiary w cm:\n r =");
                        Console.SetCursorPosition(5, 8);
                        double r = double.Parse(Console.ReadLine());
                        Console.WriteLine(" h =");
                        Console.SetCursorPosition(5, 9);
                        double h = double.Parse(Console.ReadLine());


                        stozek stozek1 = new stozek(r, h);
                        Console.WriteLine(" ");
                        Console.WriteLine("3. Parametry Stozka:");
                        Console.WriteLine("P = {0}", stozek1.Vol());
                        Console.WriteLine("V = {0}\n", stozek1.Area());
                        Console.ReadKey();
                        Console.Clear();
                        goto Start;
                    default:
                        Console.WriteLine("Blad, wpisz ponownie 1 lub 2! \n");
                        Console.ReadKey();
                        Console.Clear();
                        goto Start;
                }
            }
            else
            {
                Console.WriteLine("Blad, wybierz cyfre! \n");
                Console.ReadKey();
                Console.Clear();
                goto Start;
            }
        }
    }
    public class szescian
    {
        float a = 0;

        public szescian(float a1) 
        {
            a = a1;
        }    
        public float Vol()
        { 
            return a * a * a;
        }
        public float Area()
        {
            return 6 * a * a; 
        }
    }
    public class stozek
    {
        double r = 0;
        double h = 0;
        double l = 0;

        public stozek(double r1, double h1)
        {
            r = r1;
            h = h1;
            l = Math.Sqrt(h * h + r * r);
        }
        public double Vol()
        {
            return r * r * h * Math.PI / 3;
        }
        public double Area()
        {
            return Math.PI * r * l + Math.PI * r * r;
        }
    }

}
