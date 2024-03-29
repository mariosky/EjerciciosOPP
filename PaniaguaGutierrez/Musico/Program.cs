﻿using System;
using System.Collections.Generic;

namespace Musico
{
    //se crea clase musico
    class Musico 
    {
        //variable protegida
        protected string nombre;
        
        //Constructor Musico
        public Musico(string n)
        {
            nombre = n;
        }

        //Metodo virtual para saludar
        public virtual void Saluda()
        {
            Console.WriteLine($"hola soy {nombre}");
        }

        //Metodo virtual que afina instrumento
        public virtual void Afina()
        {
            Console.WriteLine($"{nombre}, Afina su instrumento ");
        }

        //Metodo virtual que hace que toque el instrumento
        public virtual void toca()
        {
            Console.WriteLine($"toca {nombre}\n");
        }

    }

    //clase heredada de musico, llamada bajista
    class Bajista:Musico
    {
        //variable privada bajo
        private string bajo;
        
        //constructor para mandar llamar nombre y poder usarlo
        public Bajista(string no,string bajo):base(no)
        {
            this.bajo = bajo;
        } 

        //metodo sobre escrito afina para personalizarlo a la clase
       public override void Afina()
        {
           Console.WriteLine($"{nombre} esta afinando su bajo {bajo}");
        }

        //metodo sobre escrito saluda para personalizarlo a la clase
       public override void Saluda()
        {
           Console.WriteLine($"hola soy {nombre} y soy bajista");
        }

        //metodo sobre escrito toca para personalizarlo a la clase
       public override void toca()
        {
           Console.WriteLine($"toca {nombre} su bajo {bajo}\n");
        }
    }

    //clase heredada de musico, llamada Guitarrista
    class Guitarrista:Musico
    {
        //variable privada Guitarra
        private string Guitarra;

        //constructor para mandar llamar nombre y poder usarlo
        public Guitarrista(string no,string Guitarra):base(no)
        {
            this.Guitarra = Guitarra;
        } 

        //metodo sobre escrito afina para personalizarlo a la clase
        public override void Afina()
        {
            Console.WriteLine($"{nombre} esta afinando su guitarra {Guitarra}");
        }
        
        //metodo sobre escrito saluda para personalizarlo a la clase
        public override void Saluda()
        {
            Console.WriteLine($"hola soy {nombre} y soy guitarrista");
        }

        //metodo sobre escrito toca para personalizarlo a la clase
        public override void toca()
        {
            Console.WriteLine($"toca {nombre} su bajo {Guitarra}\n");
        }
    }

    //clase heredada de musico, llamada Baterista
    class Baterista:Musico
    {
        //variable privada bateria
        private string bateria;

        //constructor para mandar llamar nombre y poder usarlo
        public Baterista(string no, string bateria):base(no)
        {
            this.bateria = bateria;
        }

        //metodo sobre escrito afina para personalizarlo a la clase
        public override void Afina()
        {
            Console.WriteLine($"{nombre} esta afinando su bateria {bateria}");
        }
        
        //metodo sobre escrito saluda para personalizarlo a la clase
        public override void Saluda()
        {
            Console.WriteLine($"hola soy {nombre} y soy baterista");
        }

        //metodo sobre escrito toca para personalizarlo a la clase
        public override void toca()
        {
            Console.WriteLine($"toca {nombre} su bateria {bateria}");
        }
    }


    class Program
    { 

        static void Main()
        {   
            //lista de musicos
            List<Musico> grupo = new List<Musico>();
            grupo.Add(new Musico("Tom"));
            grupo.Add(new Bajista("Flea", "Gibson"));
            grupo.Add(new Guitarrista("Alfred", "Red Special"));
            grupo.Add(new Baterista("Charly", "Yamaha"));

            //ciclo para empezar tocada con los musicos
            foreach(Musico m in grupo)
            {
                m.Saluda();
                m.Afina();
                m.toca();
            }

        }
    }
}