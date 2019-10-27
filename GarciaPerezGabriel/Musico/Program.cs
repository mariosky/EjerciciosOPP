using System;
using System.Collections.Generic;

namespace Musico
{  //clase principal
    class Musico 
    {       
            //protected sirve para que otras clases la hereden y la puedan usar
            protected string nombre;
            //constructor
            public Musico (string n)
            {
                nombre=n;
            }
            //metodo saluda
            //virtual sirve para crear otro metodo con el mismo nombre pero con contenido distinto
            public virtual string saluda()
            {
                //saludo
            return string.Format ("Hola soy {0}",nombre);

            }
        //public void afina(){
            //metodo afina
        public virtual void afina ()
        {
            // nombre e instrumento
        Console.WriteLine("{0}, afina su instrumento ",nombre);
        }
    }           //Clase que hereda de Musico        
            class Bajista:Musico
    {
        private string bajo;
        //constructor 
        //base: Su funcion es mandar a llamar las variables de la clase que estamos heredando
        public Bajista (string nom,string b):base(nom)
        {

            this.bajo=b;
        }
    
        //public new void afina(){
             public override void  afina()
             {
              Console.WriteLine("{0} afina su bajo {1}",nombre,bajo);
             }
         
              public override string saluda()
               {
                return base.saluda()+" y soy bajista";
              }
    }
    //Clase que hereda de Musico  
    class Guitarrista:Musico
    {
         private string guitarra;
            //constructor
         public Guitarrista(string n,string g):base(n)
         {
            this.guitarra=g;
         }
            //metodo afina
        public override void afina ()
        {
            //instrumento y nombre
            Console.WriteLine("{0} ,afina su guitarra {1}",nombre,guitarra);
        }
        //metodo saluda
        public override string saluda()
        {
            
            return base.saluda()+" y soy guitarrista";
        }
        
     }
            
   
    class Program
    {   //main
        static void Main(string[] args)
        {   //objetos
            Musico Gabriel = new Musico("Gabriel");
            Bajista Garcia = new Bajista("Garcia","Gibson");
            Guitarrista Angel= new Guitarrista("Angel","Paracho");
            
            //Lista (grupo de musicos)
            List < Musico > grupo = new List <Musico>();
            grupo.Add(Gabriel);
            grupo.Add(Garcia);
            grupo.Add (Angel);
            //estructura repetitiva
            foreach (Musico m in grupo)
            {
                Console.WriteLine(m.saluda());
                m.afina();
            }
            
                
            
        }
    }   
}   

