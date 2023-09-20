using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableroObserver
{
    public class EscaleraSerpientes
    {
        public enum TipoJugador { ONE, TWO }

        List<GenericJugador> jugadores = new List<GenericJugador>();

        private int ancho;
        public int Ancho 
        {
            get
            {
                return 4;
            }
            private set
            {
                ancho = value; 
            }
        }
        public int Alto { get; private set; }


        public EscaleraSerpientes(int Ancho, int Alto)
        { 
            this.Ancho=Ancho;
            this.Alto = Alto;
        }

        public GenericJugador AgregarJugador(string nombre,TipoJugador tipo )
        {
            GenericJugador nuevo = null;

            switch (tipo)
            { 
                case TipoJugador.ONE:
                    nuevo = new SpecializedOne(nombre, Ancho, Alto);
                    jugadores.Add(nuevo);
                    break;
                case TipoJugador.TWO:
                    nuevo = new SpecializedTwo(nombre, Ancho, Alto);
                    jugadores.Add(nuevo);
                    break;
            }

            return nuevo;
        }
        
        public void Jugar()
        {
            //code here
            /*
            foreach (object gg in jugadores)
            {
                if (gg is SpecializedOne)
                {
                    ((SpecializedOne)gg).Mover();
                }
                else if (gg is SpecializedTwo)
                {
                    ((SpecializedTwo)gg).Mover();
                }
            }
            */

            foreach (GenericJugador gg in jugadores)
            {
                if(gg!=null) gg.Mover();             
            }
        }
        

        /*para consultar jugadores */
        public List<GenericJugador> ListarJugadores() 
        {
            return jugadores;//jugadores;
        }

    }
}
