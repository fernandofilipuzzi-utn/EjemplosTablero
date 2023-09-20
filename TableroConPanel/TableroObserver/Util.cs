using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TableroObserver
{
    class Util
    {
        static public Image SelectImage(GenericJugador gg)
        {
            if (gg is SpecializedOne)
            {
                return Properties.Resources.caballero;
            }
            else if (gg is SpecializedTwo)
            {
                return Properties.Resources.dragon;
            }
            return null;
        }
    }
}
