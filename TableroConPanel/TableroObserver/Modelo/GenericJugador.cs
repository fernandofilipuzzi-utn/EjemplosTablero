using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TableroObserver.Utils;

namespace TableroObserver.Modelo
{
    public abstract class GenericJugador
    {
        public static Random rand = new Random();
                public string Nombre {get; protected set;}

        private int x;
        public int X 
        { 
            get 
            {
                return x;
            } 
            protected set
            {
                if (value != x)
                {
                    int antX=X;

                    if (value < 0) x = 0;
                    else if (value >= XMax) x = XMax - 1;
                    else x = value;

                    NotificarATodos(antX, Y);
                }
            } 
        }

        private int y;
        public int Y
        {
            get
            {
                return y;
            }
            protected set
            {
                if (value != y)
                {
                    int antY = y;

                    if (value < 0) Y = 0;
                    else if (value >= YMax) y = YMax - 1;
                    else y = value;

                    NotificarATodos(X, antY);
                }
            }
        }

        protected int XMax { get; set; }
        protected int YMax { get; set; }

        public GenericJugador(string nombre, int Ancho, int Alto)
        {
            Nombre = nombre;
            XMax = Ancho;
            YMax = Alto;
        }

        abstract public void Mover();

        //
        List<IObservador> obss = new List<IObservador>();

        public void AgregarObs(IObservador obs )
        {
            obss.Add(obs);

            obs.Notificar(X,Y,this);
        }
        public void QuitarObs(IObservador obs)
        {
            obss.Remove(obs);
        }

        protected void NotificarATodos(int antX, int antY)
        {
            foreach (IObservador obs in obss)
            {
                if(obs!=null)
                    obs.Notificar(antX, antY, this); 
            }
        }
    }
}
