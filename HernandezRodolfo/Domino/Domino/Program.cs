using System;

namespace Dominos
{

     class Domino //clase domino 
     {
         private  int  a;
         private  int  b;

     public Domino(int numerator, int dominator)// constructor ya que los valores son privados
     {
          a=numerator;
          b=dominator;
     }
     

     public static int operator +(Domino a,Domino b)  //metodo aqui hara la suma tambien 
     {
         return a.a  + a.b + b.a  + b.b;

     }


     }
    class Program
    {
        static void Main(string[] args)
        {
          Domino a= new Domino(6,6);
          Domino b= new Domino(0,2);
          Console.WriteLine(a+b);
        }
    }
}