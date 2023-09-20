using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TableroObserver.Modelo;

namespace TableroObserver.Utils
{
    public interface IObservador
    {
        void Notificar(int antX, int antY, GenericJugador actual);
    }
}
