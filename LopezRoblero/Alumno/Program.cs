using System;

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
        public virtual string Presentacion()
        {
            return string.Format("Hola, soy {0} , mi numero de control es: {1} ",Nombre,NumControl);
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
        public override string Presentacion()
        {
        return base.Presentacion()+" y soy alumno de licenciatura";
        }
        /*public void serre()
        {
            Console.WriteLine("Hago mis residencias en {0} y mi servicio social en {1}",residencias,ServicioSocial);
        } */
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Alumno cesar=new Alumno("Cesar",19210519);
            Licenciatura humberto=new Licenciatura("Humberto",19210519,"hola","BEBE");

            Console.WriteLine(cesar.Presentacion());
            Console.WriteLine(humberto.Presentacion());
            humberto.SerYres();

        }
    }
}
