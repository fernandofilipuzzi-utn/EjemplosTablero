using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using TableroObserver.Modelo;

namespace TableroObserver.Utils
{
    class Util
    {
        static public Image SelectImage(GenericJugador personaje)
        {
            if (personaje is EspecializadoUno)
            {
                return Properties.Resources.caballero;
            }
            else if (personaje is EspecializadoDos)
            {
                return Properties.Resources.dragon;
            }
            return null;
        }
    }
}
