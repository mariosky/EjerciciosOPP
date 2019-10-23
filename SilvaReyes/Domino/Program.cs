using System;

namespace Domino
{
    class Domino
    {
        //Atributos utilizados para representar el Domino 1 y 2
        public int espacio1;
        public int espacio2;

        //Sobre carga de constructor
        public Domino(int  espacio1, int espacio2)
        {
            //El this es utilizado siempre en los constructores con los atributos de tu clase
            //Ejemplo this.var=var;
            this.espacio1=espacio1;
            this.espacio2=espacio2;
        }


        //Sobre carga de operador +
        public static int operator +(Domino espacio1, Domino espacio2){
            //Permite mandar la suma del Domino a y b al class main
            return (espacio1.espacio1+espacio1.espacio2+espacio2.espacio1+espacio2.espacio2);
        }
    }
    class Program
    {
        static void Main()
        {
            //objetos domino
            Domino a= new Domino(2,0);
            Domino b= new Domino(4,1);
            
            //print de suma de dominos y esto es posible atraves de la sobre carga del operador+
            
            Console.WriteLine(a+b);

            //Cuando quieras realizar una suma entre dos objetos de la misma clase
            //Se va requerir que se realize el sobre carga de operadores 
            //sobre cargando el operado + ,- ,/, *
            //dependieno ala operacion que quieras realizar
        }
    }
}