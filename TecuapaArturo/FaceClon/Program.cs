using System;

namespace FaceClon
{
    abstract class Publicacion{
        protected string fecha;
        protected string comentarios;
        protected string reacciones;
        //cosntructor
        public Publicacion(string fecha, string comentarios, string reacciones){
            this.fecha=fecha;
            this.comentarios=comentarios;
            this.reacciones=reacciones;
        }
        //metodo abstracto que se utilizaran posteriormente en las clases siguientes
        public abstract void imprime();
    }
    //clase heredada
    class foto:Publicacion{
        public foto(string fecha, string comentarios, string reacciones):base(fecha,comentarios,reacciones){

        }
        //aqui se utiliza el metodo abstracto
        public override void imprime(){
            Console.WriteLine("La fecha es: {0} \nEl cometario es: {1} \nLa reaccion es: {2}",fecha,comentarios,reacciones);
        }        
    }
    //clase heredada
    class Estado:Publicacion{
        public Estado(string fecha, string comentarios, string reacciones):base(fecha,comentarios,reacciones){
            
        }
        //aqui se utiliza el metodo abstracto
        public override void imprime(){
            Console.WriteLine("La fecha de publicacion: {0} \nEl cometario es: {1} \nLa reaccion es: {2}",fecha,comentarios,reacciones);
        }
    }
    //clase heredada
    class Link:Publicacion{
        public Link(string fecha, string comentarios, string reacciones):base(fecha,comentarios,reacciones){
            
        }
        //aqui se utiliza el metodo abstracto
        public override void imprime(){
            Console.WriteLine("La fecha de publicacion: {0} \nEl cometario es: {1} \nLa reaccion es: {2}",fecha,comentarios,reacciones);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            foto f= new foto("12/10/14","Que bueno que esten bien","Me asombra");
            Estado e=new Estado("21/03/19","Que cool foto","Me divierte");
            Link l=new Link("31/10/19","Que buen disfraz de hallowin!!!!","Me encanta");
            f.imprime();
            e.imprime();
            l.imprime();
            
        }
    }
}
