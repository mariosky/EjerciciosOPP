using System;
using System.Collections.Generic;
namespace Alumnos
{

    class Alumnos
    {
        protected string nombre;

     public Alumnos(string nombre)
    {
        this.nombre=nombre;
    }

    public virtual void Presentate()
    {
        Console.WriteLine("Hola soy {0}", nombre);
    }

    class Licenciatura:Alumnos
    {
        private string ServicioSocial;
        private string Residencias;


        public Licenciatura(string nombre,string ServicioSocial, string Residencias):base(no)
        {
            ServicioSocial=s;
            Residencias=r;

        }

        public override void Presentate()
        {
            Console.WriteLine(" {0} es alumno de Licenciatura y hago Servicio Social en {1} y mi Residencia en {2}",nombre,ServicioSocial,Residencias);
        }


    }
 class Posgrado:Alumnos
    {
        private string Investigacion;


        public Posgrado(string nombre,string Investigacion):base(no)
        {
          Investigacion=P;


        }

        public override void Presentate()
        {
            Console.WriteLine("{0} alumno de Posgrado y estoy realizando una investigacion sobre {1}",nombre,Investigacion);
        }


    }

        

    }

   
    class Program
    {
        static void Main(string[] args)
        {
            Alumnos Rodo= new Alumnos("Rodolfo Hernandez");
            Licenciatura Rodolfo= new Licenciatura("Rodolfo", "Cruz Roja ","Eco Comercializadora");
            Posgrado Ivan = new Posgrado("Ivan Hernandez","Inteligencia Artificial");


            List <Alumnos> alumn = new List <Alumnos>();
            alumn.Add(Rodo);
            alumn.Add(Rodolfo);
            alumn.Add(Ivan);

            foreach(Alumnos a in alumn)
            {
                a.Presentate();
            }
        }
    }
}
