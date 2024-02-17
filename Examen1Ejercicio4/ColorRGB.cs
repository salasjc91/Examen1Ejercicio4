using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Ejercicio4
{
     class ColorRGB
    {
         int rojo;
         int verde;
         int azul;


        //constructores
        public int Rojo
        {
            get { return rojo; }
            set { rojo = value; }
        }

        public int Verde
        {
            get { return verde; }
            set { verde = value; }
        }

        public int Azul
        {
            get { return azul; }
            set { azul = value; }
        }

        //este metodo calcula la escala de grises con la formula NTSC
        public double CalcularEscalaGrises()
        {
            return 0.299 * Rojo + 0.587 * Verde + 0.114 * Azul;
        }
    }
}
