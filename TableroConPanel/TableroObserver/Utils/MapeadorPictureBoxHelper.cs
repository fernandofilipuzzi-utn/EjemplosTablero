using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using TableroObserver.Modelo;

namespace TableroObserver.Utils
{
    /// <summary>
    /// ayuda a pintar o representar los jugadores usando picturebox y un panel
    /// </summary>
    class MapeadorPictureBoxHelper : IObservador
    {
        List<PictureBox> pictures = new List<PictureBox>();
        List<GenericJugador> jugadores = new List<GenericJugador>();

        Control parent;
        int Height; int Width;
        int Heightt; int Widtht;

        public MapeadorPictureBoxHelper(Control parent, int width, int height,
            int widtht, int heightt )
        {
            this.parent=parent;
            this.Height=height;
            this.Width=width; 
            this.Heightt=heightt;
           
            
            this.Widtht=widtht;
        }

        public void AgregarPersonaje(GenericJugador gg)
        {
            PictureBox pb = new PictureBox();

            pb.Parent = parent;

            pb.Width = 20;
            pb.Height = 20;
            //pb.Image = Properties.Resources.caballero;
            pb.Image = Util.SelectImage( gg );

            pictures.Add(pb);

            pb.SizeMode = PictureBoxSizeMode.StretchImage;

            jugadores.Add(gg);
        }

        public PictureBox this[GenericJugador personaje]
        {
            get
            {
                for (int i = 0; i < jugadores.Count; i++)
                    if (jugadores[i] == personaje)
                        return pictures[i];
                return null;
            }
        }

        public void Notificar(int antX, int antY, GenericJugador actual)
        {
            int ancho = Width;
            int alto = Height;

            int dx = ancho / Widtht;
            int dy = alto / Heightt;

            PictureBox pb = this[actual];
            if (pb != null)
            {
                pb.Top = actual.Y * dy;
                pb.Left = actual.X * dx;
            }
        }
    }
}
