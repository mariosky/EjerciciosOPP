using System;
using System.Collections.Generic;
namespace Musico_abstracto
{
    //Clase abstracta musico
    abstract class Musico
    {
        protected string nombre;

        //Constructor
        public Musico(string n)
        {
            nombre=n;
        }
        //Metodos abstractos
        public abstract void Afina();        
        public abstract void Saluda();
       
    }
    //Clase Bajista
    class Bajista: Musico
    {
        private string bajo;
        //Constructor y utilizamos "base" para llamar la variable
        public Bajista(string no, string bajo):base(no)
        {
            this.bajo=bajo;
        } 
       //override es para agregarle metodos a las clases abstractas 
        public override void Saluda()
        {
            Console.WriteLine("Hola soy {0} y soy bajista",nombre);
        }
        public override void Afina()
        {
            Console.WriteLine("{0} Afinando su bajo {1}",nombre,bajo);
        }
        
    }
    //Clase Baterista
    class Baterista: Musico
    {
        private string bateria;
        //Constructor y utilizamos "base" para llamar la variable
        public Baterista(string no,string bateria):base(no)
        {
            this.bateria=bateria;
        }
        //override es para agregarle metodos a las clases abstractas 
        public override void Saluda()
        {
          Console.WriteLine("Hola soy {0} y soy baterista",nombre);
        }
        public override void Afina()
        {
            Console.WriteLine("{0} afinando su bateria {1}",nombre,bateria);
        }
        
    }
    //Clase Guitarrista 
     class Guitarrista: Musico
     {         
         private string guitarra;
         //Constructor y utilizamos "base" para llamar la variable
         public Guitarrista(string no,string guitarra):base(no)
         {
             this.guitarra=guitarra;
         }
         //override es para agregarle metodos a las clases abstractas 
         public override void Saluda()
         {
             Console.WriteLine("Hola soy {0} y soy guitarrista",nombre);
         }
         public override void Afina()
         {
             Console.WriteLine("{0} Afinando su guitarra {1}",nombre,guitarra);
         }         
     }
    class Program
    {
        static void Main(string[] args)
        {
            //crear nuevos objetos en cada clase
            Bajista flea=new Bajista("Flea","Gibson");
            Guitarrista jose=new Guitarrista("Jose","Gibson");
            Baterista baker=new Baterista("Baker","Gretsch");

            /*flea.Saluda();
            flea.Afina();
            jose.Saluda();
            jose.Afina();
            baker.Saluda();
            baker.Afina();*/
            //Lista 
            List <Musico> grupo=new List<Musico>();
            grupo.Add(flea);
            grupo.Add(jose);
            grupo.Add(baker);
            foreach(Musico m in grupo)
            {
                m.Saluda();
                m.Afina();
            }
        }
    }
}