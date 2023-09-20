using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableroObserver.Modelo
{
    /// <summary>
    /// Representa el juego, tablero con los jugadores
    /// </summary>
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
                    nuevo = new EspecializadoUno(nombre, Ancho, Alto);
                    jugadores.Add(nuevo);
                    break;
                case TipoJugador.TWO:
                    nuevo = new EspecializadoDos(nombre, Ancho, Alto);
                    jugadores.Add(nuevo);
                    break;
            }

            return nuevo;
        }
        
        public void Jugar()
        {
            /*
            foreach (object personaje in jugadores)
            {
                if (personaje is EspecializadoUno)
                {
                    ((EspecializadoUno)personaje).Mover();
                }
                else if (personaje is EspecializadoDos)
                {
                    ((EspecializadoDos)personaje).Mover();
                }
            }
            */

            foreach (GenericJugador jugador in jugadores)
            {
                if(jugador!=null) jugador.Mover();             
            }
        }
        

        /*para consultar jugadores */
        public List<GenericJugador> ListarJugadores() 
        {
            return jugadores;//jugadores;
        }
    }
}
