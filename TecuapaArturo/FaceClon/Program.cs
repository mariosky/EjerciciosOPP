using System;

namespace FaceClon
{
    class Publicacion{
        protected string fecha;
        protected string comentarios;
        protected string reacciones;

        public Publicacion(string fecha, string comentarios, string reacciones){
            this.fecha=fecha;
            this.comentarios=comentarios;
            this.reacciones=reacciones;
        }
        public abstract void imprime();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
