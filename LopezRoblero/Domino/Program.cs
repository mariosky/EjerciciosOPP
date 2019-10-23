using System;

namespace Domino
{
    //Clase Domino
    class Domino
    {
        //Espacio 1
        public  int A;
        //Espacio 2
        public  int B;
        //Constructor 
        public Domino(int a,int b)
        {
         A=a;
         B=b;
        }
        //Sobrecarga de operadores(Operador Suma)
        //Se estan sumando dos piezas de domino
        //d1(domino 1), d2(domino 2), A(Espacio 1) y B(Espacio 2)
        public static int operator +(Domino d1, Domino d2)
        {
        return  (d1.A+d2.A+d1.B+d2.B);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Crear objetos tipo Domino
            Domino a=new Domino (2,0);
            Domino b=new Domino(4,1);

            //Imprimir la suma de los objetos tipo Domino
            Console.WriteLine(a+b);
        }
    }
}
