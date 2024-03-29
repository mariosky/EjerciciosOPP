﻿using System;
using System.Collections.Generic;

namespace Icompara
{
    class Persona : IComparable
    {
        int id;
        string nombre;
        
        public Persona(int id, string n){
            this.id = id;
            nombre = n;
        }
        public override String ToString(){
            return String.Format("{0}, {1}", id, nombre);
        }

        public Int32 CompareTo(Object o){
            return this.id.CompareTo(((Persona) o).id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> pers = new List<Persona>();
            pers.Add(new Persona(2, "Pam"));
            pers.Add(new Persona(1, "Jim"));
            pers.Add(new Persona(3, "Mike"));

            pers.Sort();
            
            foreach(Persona p in pers){
                Console.WriteLine(p);  
            }
        }
    }
}
