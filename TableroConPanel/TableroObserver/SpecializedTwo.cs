using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableroObserver
{
    public class SpecializedTwo : GenericJugador
    {
        public SpecializedTwo(string nombre, int Ancho, int Alto)
            : base(nombre, Ancho, Alto)
        {
            X = rand.Next(0, XMax);
            Y = rand.Next(0, YMax);
        }

        /*movimiento horizontal en el rango de
         * 2 hacia atras y 2 hacia adelante*/
        public override void Mover()
        {
            Y = rand.Next(Y - 1, Y + 2);
        }
    }
}
