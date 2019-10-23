using System;
using System.Collections.Generic;

namespace Alumno
{
    class Alumno
    {
        protected string Nombre;
        protected int NumControl;

        public Alumno(string n, int NC)
        {
            Nombre=n;
            NumControl=NC;
        }
        public void Presentacion()
        {
            Console.WriteLine("Hola, soy {0} , mi numero de control es: {1} ",Nombre,NumControl);
        }
    }
    class Licenciatura:Alumno
    {
        private string residencias;
        private string ServicioSocial;
        public Licenciatura(string no, int nc, string r,string sc):base(no,nc)
        {
            residencias=r;
            ServicioSocial=sc;
        }
        public new void Presentacion()
        {
            Console.WriteLine("Hola, soy {0} y soy alumno de licenciatura , mi numero de control es: {1} \n Hago mis residencias en {2} y mi servicio social en {3}",Nombre,NumControl,residencias,ServicioSocial);
        }
    }
    class Posgrado:Alumno
    {
        private string investigacion;
        public Posgrado(string no, int nc, string i):base(no,nc)
        {
            investigacion=i;
        }
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

            Licenciatura Cesar=new Licenciatura("Cesar Lopez",19210519,"Empresa Prime","Scotiabank");
            Posgrado Luis=new Posgrado("Luis Rodriguez",19210620,"Tecnologias");

            Cesar.Presentacion();
            
            Luis.Presentacion();

            

        }
    }
}
