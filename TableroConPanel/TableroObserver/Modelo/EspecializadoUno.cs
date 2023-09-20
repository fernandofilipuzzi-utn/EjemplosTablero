using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableroObserver.Modelo
{
    public class EspecializadoUno:GenericJugador
    {
        public EspecializadoUno(string nombre, int Ancho, int Alto)
            : base(nombre, Ancho, Alto)
        {
            X = rand.Next(0, XMax);
            Y = rand.Next(0, YMax);
        }

        /// <summary>
        /// movimiento horizontal en el rango de  2 hacia atras y 2 hacia adelante
        /// </summary>        
        public override void Mover()
        {
            X=rand.Next(X-2, X+3);
        }
    }
}
