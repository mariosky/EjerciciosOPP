using System;

namespace Duracion
{
    //Clase Duracion 
    class Duracion
    {
        //Declaramos la variables horas, minutos, segundos con el identificador int en public
        public int horas;
        public int minutos;
        public int segundos;

        //Constructor Duracion
        public Duracion(int h, int m, int s)
        {
            horas = h;
            minutos = m;
            segundos = s;
        }

        //Constructor Duracion predeterminado
        public Duracion()
        {

        }

        //Sobre carga constructor Duracion, convierte segundos a horas y minutos
        public Duracion(int s)
        {
             horas = (int) s/3600;
             minutos = (int) (s-(horas*3600))/60;
             segundos = (int) (s-(horas*3600))-(minutos*60);
        }

        //Metodo para imprimir
        public void print()
        {
            Console.WriteLine("{0}:{1}:{2}", horas, minutos, segundos);
        }

        //Metodo segundos para convertir horas y minutos a segundos y sumar todos los segundos
        public void Segundos()
        {
            int totalsegundos;
            totalsegundos = (horas * 3600) + (minutos * 60) + segundos;
            Console.WriteLine("Segundos totales:{0}", totalsegundos);
        }

        //Metodo para convertir todo a minutos 
        public void Minutos()
        {
            int totalminutos;
            totalminutos = (horas * 60) + minutos;
            Console.WriteLine("Minutos totales:{0}\r\n", totalminutos);
        }

        //Operador suma para duracion "a" y duracion "b" 
        public static Duracion operator +(Duracion a, Duracion b)
        {
            int suma=0;

            suma += (a.horas+b.horas)*3600;
            suma += (a.minutos+b.minutos)*60;
            suma += a.segundos+b.segundos;

            return new Duracion(suma);        
        }
        
        /*public override string ToString()
        {
            return String.Format("{0}:{1}:{2}", horas, minutos, segundos);
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de objetos tipo duracion 
            Duracion a = new Duracion(2,15,12);
            Duracion b = new Duracion(0,2,15);
            Duracion c = new Duracion(2,0,10);
            Duracion d = new Duracion(7210);
            Duracion e;
            
            //Imprimir objeto "a"
            a.print();
            
            //Convertir el objeto "a" a segundos y minutos
            a.Segundos();
            a.Minutos();

            //Imprimir el objeto "b" y convertir a segundos y minutos
            b.print();
            b.Segundos();
            b.Minutos();

            //Imprimir el objeto "c" y convertir a segundos y minutos
            c.print();
            c.Segundos();
            c.Minutos();
            
            //Imprimir objeto "d"
            d.print();

            //Utilizarel operador suma parael objeto "a" y "b" e imprimirlo
            e = a+b;
            e.print();
            
            /*Console.WriteLine(a+b);*/
        }
    }
}