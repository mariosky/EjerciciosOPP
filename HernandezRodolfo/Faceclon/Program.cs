using System;
using System.Collections.Generic;

namespace Faceclon
{
    abstract class Publicacion
    {
        protected string Fecha;
        protected string Usuario;
        protected int Likes;
        protected string Url;

        public Publicacion(string Fecha, string Usuario, int Likes, string Url)
        {
            this.Fecha=Fecha;
            this.Usuario=Usuario;
            this.Likes=Likes;
            this.Url=Url;
        }

        public abstract void Imprime();
    }

    class Estado:Publicacion
    {
        public Estado(string Fecha, string Usuario, int Likes,string Url):base(Fecha,Usuario,Likes,Url){}

        public override void Imprime()
        {
            Console.WriteLine("Estado publicado: {0}, por el Usuario: {1}, Likes: {2}, {3}",Fecha,Usuario,Likes,Url);
        }
    }

    class Foto:Publicacion
    {   
        public Foto(string Fecha, string Usuario, int Likes, string Url):base(Fecha,Usuario,Likes,Url){}

        public override void Imprime()
        {
            Console.WriteLine("Fecha de la foto publicada: {0}, por el Usuario: {1}, Likes: {2},{3}",Fecha,Usuario,Likes,Url);
        }
    }

    class Link:Publicacion
    {
      
        
        public Link(string Fecha, string Usuario, int Likes, string Url):base(Fecha,Usuario,Likes,Url){}

        public override void Imprime()
        {
            Console.WriteLine("Fecha del link publicado: {0}, por el Usuario: {1}, Likes: {2} Url: {3}",Fecha,Usuario,Likes,Url);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Publicacion> muro = new List<Publicacion>();

            muro.Add(new Estado("23-10-2019","Rodolfo Hernandez",100,""));
            muro.Add(new Foto("23-10-2019","Rodolfo Hernandez",200,""));
            muro.Add(new Link("23-10-2019","Rodolfo Quiroz",25,"www.fb.com/RodolfoQuiroz/"));

            foreach(var Publi in muro)
            {
                Publi.Imprime();
        
            }
        }
    }
}