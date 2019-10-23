using System;

namespace Domino
{
    class Domino 
    {
        private int numerador;
        private int denominador;
        
        public Domino (int num, int den)
        {
            numerador = num;
            denominador = den;
        }  

        public static int operator +(Domino a, Domino b)
        {
             return (a.numerador+b.numerador+a.denominador+b.denominador);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Domino a = new Domino(2,0);
            Domino b = new Domino(4,1);
        
            Console.WriteLine(a+b);
        }
    }
}
