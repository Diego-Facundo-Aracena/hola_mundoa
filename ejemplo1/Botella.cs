using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    { //metodo recarga: carga al 100 y devuelve el costo de recarga. 50 cada 100
        //intentar recordar el orden y variables claras,.
        public Botella(string materia, string color) { 
            
            this.material = materia;
            this.color = color;
            capacidad = 100;
            cantidadActual = 0;
        }
        //sobrecargar el constructor
        public Botella() { }

        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        public string Material
        {
            get { return material; }
        }

        public int Capacidad 
        {
            get { return capacidad; }
        }
         
        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        //PROPIEDAD una manera distinta de crear los sets y gets
        /* public int Capacidad
         {
             get { return capacidad; }
             set { capacidad = value; }
         }*/

        //metodos
         public float recargar()
        {
            cantidadActual = 100;
            return 50;
        }

    }
}
