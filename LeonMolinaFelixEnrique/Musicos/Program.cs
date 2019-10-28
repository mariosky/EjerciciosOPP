using System;
using System.Collections.Generic;

namespace Musicos
{
    //Clase Muscio
	class Musico
	{
        //Variables en protected de clase Musico
		protected string nombre;

        //Constructor de Muscio
		public Musico(string n)
		{
			nombre = n;						             
		}

		//Virtual permite remplazar su propio metodo por medio de herencia, Metodo imprime "Afina"
		public virtual void Afina()
		{
			Console.WriteLine("{0} afina su instrumento", nombre);
		}

        //Metodo imrpime "Saluda"
		public virtual string Saluda()
		{
			return String.Format("Hola soy {0}", nombre);
		}
	}

    //Bajista que hereda de la clase Musico
	class Bajista:Musico
	{
        //Variables de clase Bajista
		private string bajo;
		
        //Metodo de Bajista
		public Bajista(string no, string b):base(no)
		{
			bajo = b;

		}

		//Override es para remplezar el metodo		
		public override void Afina()
		{
			Console.WriteLine("{0} afina su {1}", nombre, bajo);
		}
        
		//Override Metodo Saluda
		public override string Saluda()
		{
			return base.Saluda() + " y soy bajista";
		}
	}

    //Guitarrista que hereda de clase Musico
	class Guitarrista:Musico
	{
        //Variables de guitarrista
		private string guitarra;

        //Constructor de Guitarrista
		public Guitarrista(string no, string g):base(no)
		{
			guitarra = g;
		}
        
        //Override Metodo Afina
		public override void Afina()
		{
			Console.WriteLine("{0} afiando su {1}", nombre, guitarra);
		}

        //Override Metodo Saluda
        	public override string Saluda()
		{
			return base.Saluda() + " y soy gitarrista";
		}
	}

    //Baterista que hereda de la clase Musico
    class Baterista:Musico
    {
        //Variables de Batersita
        private string bateria;

        //Constructor de baterista
		public Baterista(string no, string b):base(no)
		{
			bateria = b;
		}

        //Override Metodo Afina
		public override void Afina()
		{
			Console.WriteLine("{0} afiando su {1}", nombre, bateria);
		}

        //Override Metodo Saluda
        	public override string Saluda()
		{
			return base.Saluda() + " y soy baterista";
		}
    }

	class Program
	{
		static void Main(string[] args)
		{
            //Creacion de objeto de las clases "Musico, Bajista, Guitarrista y Baterista"
			Musico tom = new Musico("Tom");
			Bajista flea = new Bajista("Flea", "Gibson");
			//Console.WriteLine(tom.Saluda());
			Guitarrista felix = new Guitarrista("Felix","Yamaha");
            Baterista josh = new Baterista("Josh Dun", "Gretsch");
			/*tom.Saluda();
			tom.Afina();
			flea.Saluda();
			flea.Afina();*/

            //Lista para guardar los musico
			List<Musico> grupo = new List<Musico>();
			grupo.Add(tom);
			grupo.Add(flea);
			grupo.Add(felix);
            grupo.Add(josh);

            //Salida de resultados utilizando un foreach que para hasta que se impriman todosss
			foreach(Musico m in grupo)
			{
				Console.WriteLine(m.Saluda());
				m.Afina();
			}
 		}
	}
}