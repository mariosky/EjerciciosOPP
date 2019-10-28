  
using System;
using System.Collections.Generic;


namespace MusicosAbstractos
{
    //Clase abstract "Musicos"
    abstract class Musicos
    {
        //Variables protected de Muscicos
        protected string nombre;

        //Constructor Musicos
        public Musicos(string n)
        {
            nombre=n;
        }
        //Metodo abstract Afina
        public abstract void Afina();
        
        //Metodo abstract Saluda
        public abstract void Saluda();
       
    }
    //Bajista que herreda de la clase Musicos
    class Bajista: Musicos
    {
        //Variables privados de Bajista
        private string bajo;
        //Constructor Bajista que herreda el constructos de Musicos con la herramietna base
        public Bajista(string no, string bajo):base(no)
        {
            this.bajo=bajo;
        } 
        //Metodo override Afina
        public override void Afina()
        {
            Console.WriteLine("{0} Afinando su bajo {1}",nombre,bajo);
        }
        //Metodo override Saluda
        public override void Saluda()
        {
            Console.WriteLine("Soy {0} y soy bajista",nombre);
        }
    }
    //Baterista que hereda de la clase Musicos
    class Baterista: Musicos
    {
        //Variables privadas de Baterista
        private string bateria;
        //Constructor de Baterista que hereda el contructor de Musicos
        public Baterista(string no,string bateria):base(no)
        {
            this.bateria=bateria;
        }
        //Metodo override Afina
        public override void Afina()
        {
            Console.WriteLine("{0} Acomodando su bateria {1}",nombre,bateria);
        }
        //Metodo override Saluda
        public override void Saluda()
        {
          Console.WriteLine("Soy {0} y soy baterista",nombre);
        }
    }
    //Guitarrista que hereda de la clase Musicos
     class Guitarrista: Musicos
     {
         //Variables privadas de Guitarrista
         private string guitarra;
         //Constructor Guitarrista que hereda el constructor de Muscicos
         public Guitarrista(string no,string guitarra):base(no)
         {
             this.guitarra=guitarra;
         }
         //Metodo override Afina
         public override void Afina()
         {
             Console.WriteLine("{0} Afinando su guitarra {1}",nombre,guitarra);
         }
         //Metodo override Afina
         public override void Saluda()
         {
             Console.WriteLine("Soy {0} y soy guitarrista",nombre);
         }
     }
    class Program
    {
        static void Main(string[] args)
        {
            //Objetos a base de las clases "Bajista, Guitarrista y Baterista"
            Bajista flea=new Bajista("Flea","Gibson");
            Guitarrista felix=new Guitarrista("Felix","Yamaha");
            Baterista josh=new Baterista("Josh Dun","Gretsch");

            /*cesar.Saluda();
            cesar.Afina();
            Humberto.Saluda();
            Humberto.Afina();*/

            //Lista de musicos
            List <Musicos> grupo=new List<Musicos>();
            grupo.Add(flea);
            grupo.Add(felix);
            grupo.Add(josh);

             //Estructura repetitiva
            foreach(Musicos m in grupo)
            {
                m.Saluda();
                m.Afina();
            }
        }
    }
}