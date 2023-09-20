using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableroObserver
{
    public interface IObservador
    {
        void Notificar(int antX, int antY, GenericJugador actual);
    }
}
