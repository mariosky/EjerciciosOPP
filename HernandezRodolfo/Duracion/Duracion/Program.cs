using System;
using System.Collections.Generic;

namespace Duracion
{
    class Duracion // declaramos la Clase
    {
        private int Horas;
        private int Minutos;
        private int segundos;

        public Duracion (int H,int M,int S) // constructor que utilizaremos
        {
            Horas = H;
            Minutos = M;
            segundos = S;

        }        
        

        public int Total() // el metodo para convertir de segundos  a horas minutos.
        {
            int conver = 0;

            int Ss = 0;
            int Hh = Horas;
            int Mm = Minutos;
            
            conver = Hh * 60;
            Ss = Ss + conver + Mm;
            return Ss;      
        }

        

        public void print()
        {
            Console.WriteLine(Horas + ":" + Minutos + ":" + segundos); // metodo para sumar los minutos horas segundos
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Duracion Horas = new Duracion(03, 10, 11); // 135 Asignamos los valores que tendra nuestras horas segunods y minutos
            Duracion Minutos = new Duracion(00, 20, 19); //60
            Duracion Segundos = new Duracion(0, 02, 30); // 120

            Horas.print();
            Minutos.print();
            Segundos.print();

            Console.WriteLine("Total horas a minutos es "+Horas.Total());
            Console.WriteLine("Total Minutos son " + Minutos.Total());
            Console.WriteLine("Total Minutos de los segundos  es " + Segundos.Total());

            Console.ReadLine();
        }
    }
}

