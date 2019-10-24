using System;

namespace Domino
{
    class Domino{
        //Declaracion side(lado 1)
        private int side1;
         //Declaracion side(lado 2)
        private int side2;
    
      //constructor
        public Domino (int s1, int s2)
        {
         this.side1=s1;
         this.side2=s2;
        }
            //sobrecarga de operador
         public static int operator +(Domino l1, Domino l2)
        {
             return (l1.side1+l2.side1+l1.side2+l2.side2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Domino");
            Console.WriteLine("");
            //objects
            Domino l1= new Domino(5,4);
            Domino l2= new Domino(3,0);
           
            //imprime el resultado de la suma de los dos objetos
            Console.WriteLine("The result of the sum is: "+ (l1+l2));
        }

        
    }
}
