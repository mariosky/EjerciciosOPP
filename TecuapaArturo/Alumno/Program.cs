using System;

namespace Alumnos
{
    class Alumno{
        protected string nombre;
        protected string no_control;
        //constructor
        public Alumno(string n, string nocontrol){
            nombre=n;
            no_control=nocontrol;
        }
        public virtual string Datos_Alumno(){
            return string.Format("Su Nombres es: {0}, su No.Control es : {1}",nombre,no_control);
        }

    }
    //clase heredada
    class Licenciatura:Alumno{
        private string Li;
        //cosntructor
        public Licenciatura(string nombre, string no_control):base(nombre,no_control){
            this.Li=Li;
        }
        //override para agregar datos al metodo
        public override string Datos_Alumno(){
            return base.Datos_Alumno()+", hago servicio social y recidencia ";
        }    
    }
    //clase heredada
    class Posgrado:Alumno{
        private string pos;
        //costructor
        public Posgrado(string nombre, string no_control):base(nombre,no_control){
                this.pos=pos;
        }
        //override para agregar datos al metodo
        public override string Datos_Alumno(){
            return base.Datos_Alumno()+", tengo un tema de investigación ";
        }  
    }
    class Program
    {
        static void Main(string[] args)
        {
            //crear nuevos objetos en cada clase
            Licenciatura p= new Licenciatura("Jose","12345");
            Posgrado l= new Posgrado ("Javier","01231");
            //imprimir
            Console.WriteLine(p.Datos_Alumno());
            Console.WriteLine(l.Datos_Alumno());
          
        }
    }
}
