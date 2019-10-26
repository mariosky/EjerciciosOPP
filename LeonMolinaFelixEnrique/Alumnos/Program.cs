using System;
using System.Collections.Generic;

namespace Alumnos
{
    //Clase Alumno
    class Alumno
    {
        //Variables del la clase Alumno
        protected string Nombre;
        protected int Control;

        //Constructor Alumno
        public Alumno(string n, int c)
        {
            Nombre=n;
            Control=c;
        }
        //Metodo Saludo que imprime las variables "Nombre" y "Control"
        public void Saludo()
        {
            Console.WriteLine("1.{0} su numero de control es {1} ",Nombre,Control);
        }
    }
    //Licencatura que herada la clase Alumno
    class Licenciatura:Alumno
    {
        //Variables de la clase Licenciatura
        private string Residencias;
        private string Servicio;

        //Constructor de la clase Licenciatura con la funcion de base que hereda la variables de la clase Alumno
        public Licenciatura(string no, int c, string r,string s):base(no,c)
        {
            Residencias=r;
            Servicio=s;
        }
        
        //Se redefine el metodo Saludo de la clase Alumno
        public new void Saludo()
        {
            Console.WriteLine("2.{0} es de licenciatura y su numero de control es {1}, practica sus recidencias en {2} y hace su servicio social en {3}",Nombre,Control,Residencias,Servicio);
        }
    }
    
    //Posgrado que herada la clase Alumno
    class Posgrado:Alumno
    {
        //Variables de la clase Posgrado    
        private string Investigacion;

        //Constructor de posgrado con la funcion base que hereda las variables de clase Alumno
        public Posgrado(string no, int nc, string i):base(no,nc)
        {
            Investigacion=i;
        }
        //Se redefine el metodo Saludo
         public new void Saludo()
        {
         Console.WriteLine("3.{0} es de posgrado y su numero de control es {1}, tiene una investigaicon acerca de {2}",Nombre,Control,Investigacion);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Se crean objetos "Javier" "Felix" "Enrique" con Alumno, Licenciatura y Posgrado
            Alumno Javier = new Alumno("Javier Rodriguez", 192105162);
            Licenciatura Felix = new Licenciatura("Felix Molina", 1921056 ,"Google","Comex");
            Posgrado Enrique = new Posgrado("Enrique Leon", 19210516 , "La teoria del Big bang");

            //Salida de resultados
            Javier.Saludo();
            Felix.Saludo();
            Enrique.Saludo();

            

        }
    }
}
