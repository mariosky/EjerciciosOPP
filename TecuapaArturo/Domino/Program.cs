using System;

namespace Domino
{
    class Domino{
        public int a;
        public int b;
        //constructor
        public Domino(int a, int b){
            this.a=a;
            this.b=b;
        }
        //sobrecarga de operadores(suma)
        public static int operator+(Domino a,Domino b){
            return (a.a+a.b+b.a+b.b);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //creacion de objetos de tipo de domino
            Domino a= new Domino(2,0);
            Domino b= new Domino(4,1);
            //imprimir
            Console.WriteLine(a+b);
        }
    }
}
