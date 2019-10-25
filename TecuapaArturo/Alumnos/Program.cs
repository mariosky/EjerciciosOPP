using System;

namespace Alumnos
{
    class Alumnos{{
        protected string nombre;
        protected string no_control;
        //constructor
        public Alumnos(string n, string nocontrol){
            nombre=n;
            no_control=nocontrol;
        }
        public virtual string Datos_Alumno(){
            return string.Format("Su Nombres es: {0}, su No.Control es : {1}",nombre,no_control);
        }

    }
    //clase heredada
    class Licenciatura:Alumnos{
        private string Li;
        //cosntructor
        public Licenciatira(string nombre, string no_control):base(nombre,no_control){
            this.Li=Li;
        }
        public override string datos_alumno(){
            return base.datos_alumno()+", hago servicio social y recidencia ";
        }    
    }
    //clase heredada
    class Posgrado:Alumnos{
        private string pos;
        //costructor
        public Posgrado(string nombre, string no_control):base(nombre,no_control){
                this.pos=pos;
        }
        //override para agregar datos al metodo
        public override string datos_alumno(){
            return base.datos_alumno()+", tengo un tema de investigacion ";
        }  
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
