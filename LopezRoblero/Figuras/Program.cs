using System;
using System.Collections.Generic;

namespace Figuras
{
    abstract class Figura
    {
      protected int px,py;
      protected string color;

      public Figura(int x,int y, string c)
      {
           px=x;
           py=y;
           color=c;
      }
      public abstract void dibuja();
    }
    class Rectangulo:Figura
    {
        public Rectangulo(int x, int y, string c):base(x,y,c)
        {
        }
        public override void dibuja()
        {
            Console.WriteLine("Se dibuja rectangulo color {0}, en x:{1} y y:{2}", color,px,py);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo r=new Rectangulo(3,5,"Rojo");
            r.dibuja();


        }
    }
}