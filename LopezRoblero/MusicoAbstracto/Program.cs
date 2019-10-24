using System;
using System.Collections.Generic;


namespace Musico
{
    //Clase abstracta musico
    //Abstract en clase: Define clases base, obligando a las clases derivadas a implementar 
    //los miembros marcados con abstract
    abstract class Musico
    {
        //Protected: Solo la clase y sus derivadas pueden usar la variable
        //definida con dicha propiedad
        protected string nombre;

        //Constructor
        public Musico(string n)
        {
            nombre=n;
        }
        //Metodo abstracto afina
        //Abstract en el metodo: Estoy indicando que el metodo no contiene implementacion
        //y obliga a sus clases derivadas a implementarlos
        public abstract void Afina();
        
        //Metodo abstracto  saluda
        //Abstract en el metodo: Estoy indicando que el metodo no contiene implementacion
        //y obliga a sus clases derivadas a implementarlos
        public abstract void Saluda();
       
    }
    //Clase bajita que hereda de musico
    class Bajista: Musico
    {
        //Private: Solo se puede usar en esta clase las variables
        //con dicha propiedad
        private string bajo;
        //Constructor
        //base: Manda llamar variable de la clase base(Musico) de la cual estamos heredando
        public Bajista(string no, string bajo):base(no)
        {
            this.bajo=bajo;
        } 
        //override: Es para implementar metodos de la clase base que marcamos con virtual en esta 
        //clase derivada
        public override void Afina()
        {
            Console.WriteLine("{0} Afinando su bajo {1}",nombre,bajo);
        }
        public override void Saluda()
        {
            Console.WriteLine("Soy {0} y soy bajista",nombre);
        }
    }
    //Clase baterista que hereda de musico
    class Baterista: Musico
    {
        //Private: Solo se puede usar en esta clase las variables
        //con dicha propiedad
        private string bateria;
        //Constructor
        //base: Manda llamar variable de la clase base(Musico) de la cual estamos heredando
        public Baterista(string no,string bateria):base(no)
        {
            this.bateria=bateria;
        }
        //override: Es para implementar metodos de la clase base que marcamos con virtual en esta 
        //clase derivada
        public override void Afina()
        {
            Console.WriteLine("{0} Acomodando su bateria {1}",nombre,bateria);
        }
        public override void Saluda()
        {
          Console.WriteLine("Soy {0} y soy baterista",nombre);
        }
    }
    //Clase guitarrista que hereda de musico
     class Guitarrista: Musico
     {
         //Private: Solo se puede usar en esta clase las variables
         //con dicha propiedad
         private string guitarra;
         //Constructor
        //base: Manda llamar variable de la clase base(Musico) de la cual estamos heredando
         public Guitarrista(string no,string guitarra):base(no)
         {
             this.guitarra=guitarra;
         }
         //override: Es para implementar metodos de la clase base que marcamos con virtual en esta 
        //clase derivada
         public override void Afina()
         {
             Console.WriteLine("{0} Afinando su guitarra {1}",nombre,guitarra);
         }
         public override void Saluda()
         {
             Console.WriteLine("Soy {0} y soy guitarrista",nombre);
         }
     }
    class Program
    {
        static void Main(string[] args)
        {
            //Crear objetos de clases
            Bajista Humberto=new Bajista("Humberto","Gibson");
            Guitarrista Lopez=new Guitarrista("Lopez","Fender");
            Baterista Roblero=new Baterista("Roblero","Pearl");

            /*cesar.Saluda();
            cesar.Afina();
            Humberto.Saluda();
            Humberto.Afina();*/

            //Lista de musicos
            List <Musico> grupo=new List<Musico>();
            grupo.Add(Humberto);
            grupo.Add(Lopez);
            grupo.Add(Roblero);

             //Estructura repetitiva
            foreach(Musico m in grupo)
            {
                m.Saluda();
                m.Afina();
            }
        }
    }
}
