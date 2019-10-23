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
            Console.WriteLine("Hola, soy {0} y soy alumno de licenciatura , mi numero de control es: {1}",Nombre,NumControl);
        }
        public void imprimeResSer()
        {
             Console.WriteLine("Hago mis residencias en {0} y mi servicio social en {1}",residencias,ServicioSocial);
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
         Console.WriteLine("Hola, soy {0} y soy alumno de posgrado, mi numero de control es: {1}",Nombre,NumControl);
        }
        public void imprimeInv()
        {
            Console.WriteLine("Realizo una investigacion sobre {0}",investigacion);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Alumno cesar=new Alumno("Cesar",19210519);
            Licenciatura humberto=new Licenciatura("Humberto",19210519,"Prime","Palacio");
            Posgrado lopez=new Posgrado("Lopez",19210519,"Tecnologias");

          List<Alumno> estudiantes=new List<Alumno>();
          estudiantes.Add(cesar);
          estudiantes.Add(lopez);
          estudiantes.Add(humberto);
          foreach(Alumno A in estudiantes)
          {
              A.Presentacion();

          }
        }
    }
}
