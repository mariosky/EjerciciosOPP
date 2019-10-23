using System;
using System.Collections.Generic;

namespace Alumno
{
    //Clase alumno
    class Alumno
    {
        //Protected: Solo la clase y sus derivadas pueden usar la variable
         //definida con dicha propiedad
        protected string Nombre;
        protected int NumControl;

        //Constructor
        public Alumno(string n, int NC)
        {
            Nombre=n;
            NumControl=NC;
        }
        //Metodo presentacion
        public void Presentacion()
        {
            Console.WriteLine("Hola, soy {0} , mi numero de control es: {1} ",Nombre,NumControl);
        }
    }
    //Clase licenciatura que hereda de alumno
    class Licenciatura:Alumno
    {
        //Private: Solo se pueden usar en esta clase las variables 
        private string residencias;
        private string ServicioSocial;
        //Constructor
        //base: Manda llamar variables de la clase base(Alumno) de la cual estamos heredando
        public Licenciatura(string no, int nc, string r,string sc):base(no,nc)
        {
            residencias=r;
            ServicioSocial=sc;
        }
        //New: Redefinimos el metodo de la clase base 
        public new void Presentacion()
        {
            Console.WriteLine("Hola, soy {0} y soy alumno de licenciatura , mi numero de control es: {1} \n Hago mis residencias en {2} y mi servicio social en {3}",Nombre,NumControl,residencias,ServicioSocial);
        }
    }
    //Clase Posgrado que hereda de alumno
    class Posgrado:Alumno
    {
        //Private: Solo se pueden usar en esta clase las variables 
        private string investigacion;
        //Constructor
        //base: Manda llamar variables de la clase base(Alumno) de la cual estamos heredando
        public Posgrado(string no, int nc, string i):base(no,nc)
        {
            investigacion=i;
        }
        //New: Redefinimos el metodo de la clase base 
         public new void Presentacion()
        {
         Console.WriteLine("Hola, soy {0} y soy alumno de posgrado, mi numero de control es: {1} \n Realizo una investigacion sobre {2}",Nombre,NumControl,investigacion);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Alumno cesar=new Alumno("Cesar",19210519);

            //Crear objetos tipo licenciatura y posgrado
            Licenciatura Cesar=new Licenciatura("Cesar Lopez",19210519,"Empresa Prime","Scotiabank");
            Posgrado Luis=new Posgrado("Luis Rodriguez",19210620,"Tecnologias");

            //Mandar llamar el metodo presentacion
            Cesar.Presentacion();
            Luis.Presentacion();

            

        }
    }
}
