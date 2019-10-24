using System;

namespace Domino
{
    //Clase Domino
    class Domino 
    {
        //Variables numerador y denominador con un identificador int y en privado
        private int numerador;
        private int denominador;

        //Constructor Domino
        public Domino (int num, int den)
        {
            numerador = num;
            denominador = den;
        }  

        //Operador + Para que sume domino "a" y domino "b"
        public static int operator +(Domino a, Domino b)
        {
             return (a.numerador+b.numerador+a.denominador+b.denominador);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Creamos 2 objetos tipo domino 
            Domino a = new Domino(2,0);
            Domino b = new Domino(4,1);
        
            //Imprimimos el operador suma de "a+b"
            Console.WriteLine(a+b);
        }
    }
}
