using System;
using System.Collections.Generic;

namespace Musicos
{   
    //Creacion de clase Musicos abstracta
    abstract class Musicos
    {   
        //Atributos de clase usando protected por que solo 
        //con protected y public se puede heredar
        protected string nombre;
         
         //Sobre carga de constructor 
        public Musicos(string nombre)
        {
            //se usa this. siempre en el constructor 
           this.nombre=nombre;
        }
        
        //Creacion de metodo con abstract
        //lo que hara que las demas clases tengan que heredar el metodo
        public abstract void Afina();
        
        //Creacion de metodo de saluda y igualmente usando el abstract
        //tambien tendran que tener la las demas clases
        public abstract void Saluda();
        //Creacion de metodo toca y usando abstract  
        //para igualmente tener que poner la en las demas clases
        public abstract void Toca();
    }
    
    //Creacion de clase Baterista que hereda clase Musicos abstracta 
    class Baterista:Musicos
    {   
        //Atributo de la clase Baterista
        protected string Bateria;
        
        //Sobre carga de constructor
        //heredando nombre atravez de base
        public Baterista(string nombre,string Bateria):base(nombre)
        {
            //this es solo utilizado con el atributo creado en clase Bateria
         this.Bateria=Bateria;
        }
          
          //creacion de metodo Afina usando override para volver utilizarlo 
          //Ya que se uso abstract en clase de Musicos
        public override void Afina()
        {
            Console.WriteLine("{0} afina su bateria {1}",nombre,Bateria);
        }
        //Metodo de saluda y utiliza el override por que
        //se utilizo el abstract en clase Musicos
        public override void Saluda()
        {
            Console.WriteLine("Hola soy {0} ",nombre);
        }
        //Creacion de metodo toca y utiliza override
        //para volver utilizar el metodo
        public override void Toca()
        {
        Console.WriteLine("{0} empezo tocar su bateria {1}",nombre,Bateria);
        }
    }

    //Creacion de clase  Bajista y hereda Musicos (abstract)
    class Bajista:Musicos
    {   
        //Atributos de Bajista
        protected string Bajo;
        
        //Sobre carga de contructor
        //y hereda nombre atravez de nombre
        public Bajista(string nombre,string Bajo):base(nombre)
        {   
            //this es solamente usado en atributo creado dentro de bajista
            this.Bajo=Bajo;
        }
           
        //Metodo afina con override 
        //ya que se esta usando nuevamente 
        //dentro de la clase Bajista y se ocupa usar por el abstract
        public override void Afina()
        {
            Console.WriteLine("{0} afina su bajo {1}",nombre,Bajo);
        }
        //Metodo de saluda
        //el cual permite que el bajista salude
        public override void Saluda()
        {
            Console.WriteLine("Hola soy {0} ",nombre);
        }
        //Metodo de toca
        //Permite que el bajista empieze a tocar bajo
        public override void Toca()
        {
        Console.WriteLine("{0} empezo tocar su bajo {1}",nombre,Bajo);
        }

    }
    
    //Creacion de clase Guitarrista heredando Musico(abstract)
    class Guitarrista:Musicos
    { 
        //Atributo de Guitarrista
        protected string Guitarra;
        //Sobre carga del constructor
        //Resibe nombre de musicos 
        //utilizando el base 
        public Guitarrista(string nombre,string Guitarra):base(nombre)
        { 
            //this solo contendra los atributos de la clase GUitarrista
             this.Guitarra=Guitarra;
        }
        

        //Creacion de metodo Afina
        //Permite que el guitarrista afine su guitarra
        //y lleva override por el abstract de clase MUsicos
         public override void Afina()
        {
            Console.WriteLine("{0} afina su guitarra {1}",nombre,Guitarra);
        }

        //Creacion de metodo Saluda
        //Permite que guitarrista salude
        //Y el override es por que ya se usado el metodo en otras clases
        //y obligatorio por que es abstract en clase Musicos
        public override void Saluda()
        {
            Console.WriteLine("Hola soy {0} ",nombre);
        }

        //Metodo de toca 
        //PErmite que guitarrista toque 
        //Y el override por el motivo de que otras clases la usan
        //y por que se utilizo el abstract en clase Musicos
        public override void Toca()
        {
        Console.WriteLine("{0} empezo tocar su guitarra {1}",nombre,Guitarra);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Impresion por medio de list:");
             //Creacion de lista de Musicos
             List<Musicos> Linkinpark =new List<Musicos>();
             //Agregacion de objetos a lista
             Linkinpark.Add(new Baterista("Rob","Pearl"));
             Linkinpark.Add(new Bajista("Brad","Ibanez"));
             Linkinpark.Add(new Guitarrista("Mike","Fender"));
             foreach(Musicos miembros in Linkinpark)
            {  
                //Permite realziar la impresion de cada miembro de la lista
                miembros .Afina();
                miembros .Saluda();
                miembros .Toca();
            }

        }
    }
}

