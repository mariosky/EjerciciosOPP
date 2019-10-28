using System;
using System.Collections.Generic;

namespace Ilustarador
{
    //Clase abstracta de "Figura"
    abstract class Figura
    {
        //Variavles en protected de "Figura"
        protected int px,py;
        protected string color;

      //Constructor de "Figura
      public Figura(int x,int y, string c)
      {
            px=x;
            py=y;
            color=c;
      }
        //Metodo abstracto "Dibuja
        public abstract void Dibuja();
    }
    
    //Clase rectangulo que hereda de figura
     class Rectangulo:Figura
    {
        //Constructor Rectangulo que hereda constructor de Figura con la herramienta base
        public Rectangulo(int x, int y, string c):base(x,y,c)
        {
        }
        
        //Metodo override Dibujasss  
        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja rectangulo color {0}, en x:{1} y y:{2}", color,px,py);
        }
    }
    
    //Circulo que herada Figura
    class Circulo:Figura
    {
        //Constructor Circulo que hereda Contructor de Figura con la herramienta base
        public Circulo(int x, int y, string c):base(x,y,c)
        {
        }
        
        //Metodo overdrive "Dibuja"
        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja circulo color {0}, en x:{1} y y:{2}", color,px,py);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Objetos de las clases "Rectangulo y circulo"
            Rectangulo r=new Rectangulo(3,5,"Rojo");
            Rectangulo r2=new Rectangulo(4,7,"Azul");
            Circulo c2=new Circulo(12,17,"Verde");
            Circulo c=new Circulo(6,10,"Amarillo");

            //Lista de figuras
            List<Figura> Figura=new List<Figura>();
            Figura.Add(r);
            Figura.Add(r2);
            Figura.Add(c);
            Figura.Add(c2);

            //Salida de resultados utilizando un "foreach"
            foreach(Figura a in Figura)
            {
                a.Dibuja();
            }

        }
    }
}