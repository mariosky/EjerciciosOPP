using System;
using System.Collections.Generic;

namespace Figuras
{
    //Clase abstracta Figuta
    //Abstract en clase: Define clases base, obligando a las clases derivadas a implementar 
    //los miembros marcados con abstract
    abstract class Figura
    {
     //Protected: Solo la clase y sus derivadas pueden usar la variable
     //definida con dicha propiedad
      protected int px,py;
      protected string color;

      //Constructor
      public Figura(int x,int y, string c)
      {
           px=x;
           py=y;
           color=c;
      }
       //Metodo abstracto dibuja
        //Abstract en el metodo: Estoy indicando que el metodo no contiene implementacion
        //y obliga a sus clases derivadas a implementarlos
      public abstract void dibuja();
    }
    //Clase rectangulo que hereda de figura
     class Rectangulo:Figura
    {
        //Constructor
        //base: Manda llamar variables de la clase base(Figura) de la cual estamos heredando
        public Rectangulo(int x, int y, string c):base(x,y,c)
        {
        }
        //Metodo dibuja
        //override: Es para implementar metodos de la clase base que marcamos con abstract en esta 
        //clase derivada
        public override void dibuja()
        {
            Console.WriteLine("Se dibuja rectangulo color {0}, en x:{1} y y:{2}", color,px,py);
        }
    }
    //Clase rectanculo que hereda de figura
    class Circulo:Figura
    {
        //Constructor
        //base: Manda llamar variables de la clase base(Figura) de la cual estamos heredando
        public Circulo(int x, int y, string c):base(x,y,c)
        {
        }
        //Metodo dibuja
        //override: Es para implementar metodos de la clase base que marcamos con abstract en esta 
        //clase derivada
        public override void dibuja()
        {
            Console.WriteLine("Se dibuja circulo color {0}, en x:{1} y y:{2}", color,px,py);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Crear objetos de clases
            Rectangulo r=new Rectangulo(3,5,"Rojo");
            Circulo c=new Circulo(6,10,"Negro");

            //Lista de figuras
            List<Figura> Fig=new List<Figura>();
            Fig.Add(r);
            Fig.Add(c);

            //Estructura repetitiva
            foreach(Figura F in Fig)
            {
                F.dibuja();
            }

        }
    }
}