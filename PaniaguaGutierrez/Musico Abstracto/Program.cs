using System;
using System.Collections.Generic;

namespace MusicoAbstracto
{
    abstract class Musico 
    {

        protected string nombre;
        
        public Musico(string n)
        {
            nombre = n;
        }

        public abstract void Saluda();

        public abstract void Afina();

        public abstract void toca();
    }

    class Bajista:Musico
    {
        private string bajo;
        
        public Bajista(string no,string bajo):base(no)
        {
            this.bajo = bajo;
        } 

       public override void Afina()
        {
           Console.WriteLine($"{nombre} esta afinando su bajo {bajo}");
        }

       public override void Saluda()
        {
           Console.WriteLine($"hola soy {nombre} y soy bajista");
        }

       public override void toca()
        {
           Console.WriteLine($"toca {nombre} su bajo {bajo}\n");
        }
    }

    class Guitarrista:Musico
    {
       private string Guitarra;

        public Guitarrista(string no,string Guitarra):base(no)
        {
            this.Guitarra = Guitarra;
        } 

        public override void Afina()
        {
            Console.WriteLine($"{nombre} esta afinando su guitarra {Guitarra}");
        }

        public override void Saluda()
        {
            Console.WriteLine($"hola soy {nombre} y soy guitarrista");
        }

        public override void toca()
        {
            Console.WriteLine($"toca {nombre} su bajo {Guitarra}\n");
        }
    }

    class Baterista:Musico
    {
        private string bateria;
        public Baterista(string no, string bateria):base(no)
        {
            this.bateria = bateria;
        }

        public override void Afina()
        {
            Console.WriteLine($"{nombre} esta afinando su bateria {bateria}");
        }
        
        public override void Saluda()
        {
            Console.WriteLine($"hola soy {nombre} y soy baterista");
        }

        public override void toca()
        {
            Console.WriteLine($"toca {nombre} su bateria {bateria}");
        }
    }


    class Program
    { 

        static void Main()
        {   
            Bajista flea = new Bajista("flea", "Yamaha");
            Guitarrista Tom = new Guitarrista("Tom", "Gibson");
            Baterista Carlos = new Baterista("Carlos", "Yamaha");


            List<Musico> grupo = new List<Musico>();
            grupo.Add(flea);
            grupo.Add(Tom);
            grupo.Add(Carlos);
            foreach(Musico m in grupo)
            {
                m.Saluda();
                m.Afina();
                m.toca();
            }

        }
    }
}