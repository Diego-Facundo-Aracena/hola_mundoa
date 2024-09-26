using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona p1= new Persona("PEPE");
            p1.setEdad(20);
            Console.WriteLine(p1.saludar());
            Console.WriteLine(p1.saludar("diegoooo"));

            Console.WriteLine("la edad de la persona es: " + p1.getEdad());
            

            Botella b1 = new Botella("plastico","rojo");
            //b1.Capacidad = 2001;

            //int loquesea=b1.Capacidad;
            //Console.WriteLine("la capacidad de la botella es de: "+loquesea);
            //Console.ReadKey();
            //Console.WriteLine("___capacidad  botella: "+ b1.Capacidad);
            //Console.WriteLine("-la cantidax de la botella es: " + b1.CantidadActual);

            //b1.recargar();
            //Console.WriteLine("luego de la recarga la cantidad de la botella es: " + b1.CantidadActual);

            Console.ReadKey();
        }

    }
} 
