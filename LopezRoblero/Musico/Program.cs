using System;
using System.Collections.Generic;


namespace Musico
{
    //Clase musico
    class Musico
    {
        //Protected: Solo la clase y sus derivadas pueden usar la variable
        //definida con dicha propiedad
        protected string nombre;

        //Constructor
        public Musico(string n)
        {
            nombre=n;
        }
        //Metodo Afina
        //Virtual: permite que este metodo se pueda sobreescribir en una clase derivada
        public virtual void Afina()
        {
           Console.WriteLine("{0}, Afina su instrumento",nombre);
        }
        //Metodo Saluda
        //Virtual: permite que este metodo se pueda sobreescribir en una clase derivada
        public virtual string Saluda()
        {
           return string.Format("Hola, soy {0}",nombre);
        }
    }
    //Clase bajita que hereda de musico
    class Bajista: Musico
    {
        //Private: Solo se puede usar en esta clase
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
        public override string Saluda()
        {
            return base.Saluda()+" y soy bajista";
        }
    }
    //Clase baterista que hereda de musico
    class Baterista: Musico
    {
        //Private: Solo se puede usar en esta clase
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
        public override string Saluda()
        {
          return base.Saluda()+" y soy baterista";
        }
    }
    //Clase guitarrista que hereda de musico
     class Guitarrista: Musico
     {
         //Private: Solo se puede usar en esta clase
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
         public override string Saluda()
         {
             return base.Saluda()+" y soy guitarrista";
         }
     }
    class Program
    {
        static void Main(string[] args)
        {
            //Crear objetos
            Musico cesar=new Musico("Cesar");
            Bajista Humberto=new Bajista("Humberto","Gibson");
            Guitarrista Lopez=new Guitarrista("Lopez","Fender");
            Baterista Roblero=new Baterista("Roblero","Pearl");

            /*cesar.Saluda();
            cesar.Afina();
            Humberto.Saluda();
            Humberto.Afina();*/

            //Lista de musicos
            List <Musico> grupo=new List<Musico>();
            grupo.Add(cesar);
            grupo.Add(Humberto);
            grupo.Add(Lopez);
            grupo.Add(Roblero);

             //Estructura repetitiva
            foreach(Musico m in grupo)
            {
                Console.WriteLine(m.Saluda());
                m.Afina();
            }
        }
    }
}