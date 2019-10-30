using System;

namespace Domino
{
    //creacion de clase domino
    class domino
    {
        //declaracion de variables privadas
        private int arriva;
        private int abajo;

        //constructor de domino
        public domino(int up, int down)
        {
            arriva = up;
            abajo = down;
        }

        //sobrecargado de operador +
        public static int operator +(domino a, domino b)
        { 
            return a.arriva+b.arriva+a.abajo+b.abajo;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creacion de dominos
            domino a = new domino(2,0);
            domino b = new domino(4,1);
            
            //imprecion de sobrecargado de dominos
            Console.WriteLine(a+b);
        }
    }
}
