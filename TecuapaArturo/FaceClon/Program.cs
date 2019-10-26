using System;

namespace FaceClon
{
    abstract class Publicacion{
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
    class foto:Publicacion{
        public foto(string fecha, string comentarios, string reacciones):base(fecha,comentarios,reacciones){

        }
        public override void imprime(){
            Console.WriteLine("La fecha es: {0} \nEl cometario es: {1} \nLa reaccion es: {2}",fecha,comentarios,reacciones);
        }        
    }
    class Program
    {
        static void Main(string[] args)
        {
            foto f= new foto("12/10/14","Que bueno que esten bien","Me asombra");
            f.imprime();
            
        }
    }
}
