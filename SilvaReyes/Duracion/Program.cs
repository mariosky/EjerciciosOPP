using System;

namespace Duracion
{
    
    class Duracion
    {
    //Atributos utilizados para la impresion de H:M:S
    private int horas;
    private int minutos;
    private int segundo;
    //Segund2 es usado para la converion de segundos a H:M:S
    private int segundo2;
   
    
    //Para poder mandar los atributos privados(horas)es  usado cuando se maneja atributos privados o protected
    public void SetHoras(int horas)
    {
        this.horas=horas;
    }
    public int GetHoras()
    {
        return this.horas;
    }
     //Para poder mandar los atributos privados(minutos)
    public void SetMinutos (int minutos)
    {
        
        this.minutos=minutos;
    }
    public int GetMinutos()
    {
        return this.minutos;
    }
     //Para poder mandar los atributos privados(segundo)
    public void SetSegundo (int segundo)
    {
        
        this.segundo=segundo;
    }
    public int GetSegundo()
    {
        return this.segundo;
    }
     //Para poder mandar los atributos privados(segundo2)
     public void SetSegundo2 (int segundo2)
    {
        
        this.segundo2=segundo2;
    }
    public int GetSegundo2()
    {
        return this.segundo2;
    }
    

    //Sobre carga de constructores(Duracion)
    public Duracion(int horas,int minutos,int segundo,int segundo2)
    {
        //En sobre carga de constructores se usa el this."var"="var"
       this.horas=horas;
       this.minutos=minutos;
       this.segundo=segundo;
       this.segundo2=segundo2;
    }
     //Sobre carga constructores(Duracion)
   public Duracion()
   {

   }
  //Sobre carga constructores(solo que aqui solo cargamos a segundo)
   public Duracion(int segundo)
   {
       this.segundo=segundo;
   }
 
  //Conversion de horas y minutos a segundos ,creando un metodo llamado conversion 
   public void Conversion()
   {
   //Los minutos son multiplicados por 60 como cada minuto contiene 60 segundos
    int ConvM=minutos*60;
    Console.WriteLine("La duracion en minutos es: " );
    Console.WriteLine("{0}",ConvM);
   //Las horas son multiplicados por 360 como cada hora contiene 3600 segundos
    int ConvS=horas*3600;
    Console.WriteLine("La duracion en segundos es: " );
    Console.WriteLine("{0}",ConvS);
   }
    
    //Metodo creado para convertir los segundos en H:M:S 
    //Con el metodo llamado ConversionHMS
   //conversion de segundos a H:M:S
   public void ConversionHMS()
   { 
     //atributos creados para poder realizar la conversion
       int tiempoh;//horas
       int tiempom;//minutos
       int tiempos;//segundos
       int resto;//sirve como una variable temporal
      
      //conversion segundos a horas
       tiempoh=segundo2/3600;
       //Se guarda valor en la variable temporal
       resto=segundo2 % 3600;
       //Conversion de segundos a minutos
       tiempom=resto/60;
       //segundos restantes 
       tiempos=resto%60;
       Console.WriteLine("La conversion de segundos a H:M:S es :");
        Console.WriteLine("{0}:{1}:{2}",tiempoh,tiempom,tiempos);
   }
   
     //Sobre carga de operador "+"
        public static int operator +(Duracion D3 ,Duracion D4){
            //es utilizado para poder realizar la suma de las dos duraciones
             return  ((D3.horas+D4.horas)*3600)+((D3.minutos+D4.minutos)*60)+(D3.segundo+D4.segundo);
            
        }
   

}

    class Program
    {
        static void Main()
        {
            //Objetos duracion D1 y D2
            Duracion D1 =new Duracion();
            Duracion D2 =new Duracion();



            //Duracion 1 
            //Llamado de Horas atraves del Set
            D1.SetHoras(2);
             //Llamado de Minuto atraves del Set
            D1.SetMinutos(15);
             //Llamado de Segundo atraves del Set
            D1.SetSegundo(23);
             //Llamado de Segundo2 atraves del Set
            D1.SetSegundo2(6564);
            Console.WriteLine("La duracion 1 es de: " );
            //Print de H:M:S de Duracion 1(D1)
            Console.WriteLine("{0}:{1}:{2}", D1.GetHoras(), D1.GetMinutos(),D1.GetSegundo());
            //Print Conversion de duracion 1(D1) a segundos
            D1.Conversion();
              //Print Conversion de duracion 1 (D1)a H:M:S
            D1.ConversionHMS();
            
            //Duracion 2
            //Llamado de Horas atraves del Set
            D2.SetHoras(3);
            //Llamado de Minuto atraves del Set
            D2.SetMinutos(12);
            //Llamado de Segundo atraves del Set
            D2.SetSegundo(43);
            //Llamado de Segundo2 atraves del Set
            D2.SetSegundo2(3264);
            Console.WriteLine("La duracion 2 es de: " );
              //Print de H:M:S de Duracion 2(D2)
            Console.WriteLine("{0}:{1}:{2}", D2.GetHoras(), D2.GetMinutos(),D2.GetSegundo());
            //Print Conversion de duracion 2(D2) a segundos
            D2.Conversion();
             //Print Conversion de duracion 2 (D2)a H:M:S
            D2.ConversionHMS();
           
           //Suma de duracion en segundos,atraves de la utilizacion de sobre carga de operadores "+"
            Console.WriteLine("La suma de las duraciones es:");
            Console.WriteLine(D1+D2);
            
            
            
        }
    }
}