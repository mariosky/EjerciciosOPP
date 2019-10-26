using System;
using System.Collections.Generic;

namespace Ilustrador
{   
    //Creacion de clase abstracta Ilustrador
    abstract class Ilustrador
    { 
        //Creacion de atributos protected
        //Para poder heredar
        protected int x;
        protected int y;
        protected string color;
   
    
    //Sobre carga de constructor
    public Ilustrador(int x,int y, string color)
    {
        //Se utiliza el this en cada uno de sus atributos
    this.x=x;
    this.y=y;
    this.color=color;
    }    

    //creacion de metodos abstractos
    //deberan ser usadas en todas las demas clases
        public abstract void dibuja();
        public abstract void printColor();

    }
     
     //Creacion de clase Circulo Heredando de Ilustrador
     class Circulo : Ilustrador
       {
           //Creacion de constructor 
        public Circulo(int x, int y, string color):base(x , y, color)
        {
            //No lleva this por que no creamos atributos en la clase
        }
        
        //Creacion de metodo dibuja
        //Y se debe crear como clase Ilustrador 
        //Tiene el metodo abstracto
        public override void dibuja(){
            Console.WriteLine("Se dibuja un circulo en la posicion ({0},{1})", x,y);
        } 

        //Creacion de metodo PrintColor
        //con override por lo que es abstracta el metodo 
         public override void printColor(){
            Console.WriteLine("EL circulo es color {0}", color);
        }
    }
    
    //Creacion de clase rectangulo
    //Hereda de Ilustrador
     class rectangulo : Ilustrador
      {

          //Creacion de constructor 
        public rectangulo(int x, int y, string color):base(x , y, color)
        {
            }
            
             //Creacion de metodo 
             //dibuja que es abstracto
             //Y se utiliza override para poder utilizarse
             public override void dibuja(){
            Console.WriteLine("Se dibuja un rectangulo en la posicion ({0},{1})", x,y);
        }
          

          //creacion de metodod printcolor
          //conteniendo override por tener metodo abstracto en clase Ilustrador
         public override void printColor(){
            Console.WriteLine("EL rectangulo es color {0}", color);
        }
        }
        

    class Program
    {
        static void Main()
        {   

            //Creacion de LIsta de clase Ilustrador
             List<Ilustrador> Figura =new List<Ilustrador>();
             //Creacion de objtos CIrculo y figura
             Figura.Add(new Circulo(11,12,"verde"));
             Figura.Add(new rectangulo(10,11,"azul"));
             foreach(Ilustrador a in Figura)
             { 
                 //IMpresion de metodo dibuja y printcolor
                 //De la clase circulo y rectangulo
             a.dibuja();
             a.printColor();
            
             }
        }
    }
}
