using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using TableroObserver.Modelo;

namespace TableroObserver.Utils
{
    /// <summary>
    /// ayuda a pintar los jugadores usando Graphics
    /// </summary>
    class MapeadorGraphicsHelper : IObservador
    {
        List<Image> pictures = new List<Image>();
        List<GenericJugador> jugadores = new List<GenericJugador>();

        Form parent;
        int Height; int Width;
        int Heightt; int Widtht;

        public MapeadorGraphicsHelper(Form parent, int width, int height, int widtht, int heightt)
        {
            this.parent = parent;
            this.Height = height;
            this.Width = width;

            this.Heightt = heightt;
            this.Widtht = widtht;
        }

        public void AgregarPersonaje(GenericJugador nuevoPersonaje)
        {
            pictures.Add(Util.SelectImage(nuevoPersonaje));
            jugadores.Add(nuevoPersonaje);
        }

        public Image this[GenericJugador personaje]
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

            Image pb = this[actual];
            if (pb != null)
            {
                Graphics g = parent.CreateGraphics();

                Brush brush = new SolidBrush(Color.Gray);
                g.FillRectangle(brush, antX * dx, antY * dy, dx, dy);

                #region CELDA VIEJA
                int shift = dx / 6;
                int i = 0;
                int dxp = dx;
                int dyp = dy;
                int offset = 0;
                foreach (GenericJugador personaje in jugadores)
                {
                    if (antX == personaje.X && antY == personaje.Y)
                    {
                        Image pb_o = this[personaje];
                        if (pb_o != null)
                        {
                            //g.DrawImage(pb_o, nuevoPersonaje.X * dx + shift, nuevoPersonaje.Y * dy + shift, dx, dy);
                            g.DrawImage(pb_o,
                                        new Rectangle(personaje.X * dx + offset, personaje.Y * dy + offset, dxp, dyp),
                                        new Rectangle(0, 0, pb_o.Width, pb_o.Height),
                                        GraphicsUnit.Pixel);
                            i++;
                            dxp -= i * shift;
                            dyp -= i * shift;
                            offset = i * shift;
                        }
                    }
                }
                #endregion

                #region NUEVA
                shift = dx / 6;
                i = 0;
                dxp = dx;
                dyp = dy;
                offset = 0;
                foreach (GenericJugador personaje in jugadores)
                {
                    if (actual.X == personaje.X && actual.Y == personaje.Y)
                    {
                        Image pb_o = this[personaje];
                        if (pb_o != null)
                        {
                            //g.DrawImage(pb_o, nuevoPersonaje.X * dx + shift, nuevoPersonaje.Y * dy + shift, dx, dy);
                            g.DrawImage(pb_o,
                                new Rectangle(personaje.X * dx + offset, personaje.Y * dy + offset,
                                                dxp, dyp),
                                new Rectangle(0, 0, pb_o.Width, pb_o.Height),
                                GraphicsUnit.Pixel);
                            i++;
                            dxp -= i * shift;
                            dyp -= i * shift;
                            offset = i * shift;
                        }
                    }
                }
                #endregion
                // pb.Top = actual.Y * dy;
                // pb.Left = actual.X * dx;
            }
        }
    }

}
