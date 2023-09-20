using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TableroObserver
{
    class MaperDraw: IObservador
    {
        List<Image> pictures = new List<Image>();
        List<GenericJugador> gamers = new List<GenericJugador>();

        Form parent;
        int Height; int Width;
        int Heightt; int Widtht;

        public MaperDraw(Form parent, int width, int height,
            int widtht, int heightt )
        {
            this.parent=parent;
            this.Height=height;
            this.Width=width; 
           
            this.Heightt=heightt;
           this.Widtht=widtht;
        }

        public void AgregarGG(GenericJugador gg)
        {         
            pictures.Add(Util.SelectImage(gg));
            gamers.Add(gg);
        }

        public Image this[GenericJugador gg]
        {
            get
            {
                for (int i = 0; i < gamers.Count; i++)
                    if (gamers[i] == gg)
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
               
                //CELDA VIEJA
                int shift = dx/6;
                int i = 0;
                int dxp = dx;
                int dyp = dy;
                int offset = 0;
                foreach (GenericJugador gg in gamers)
                {
                    if (antX == gg.X && antY == gg.Y)
                    {
                        Image pb_o = this[gg];
                        if (pb_o != null)
                        {
                            //g.DrawImage(pb_o, gg.X * dx + shift, gg.Y * dy + shift, dx, dy);
                            g.DrawImage(pb_o,
                                new Rectangle(gg.X * dx + offset, gg.Y * dy + offset,
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

                //CELDA NUEVA
                shift = dx / 6;
                i = 0;
                dxp = dx;
                dyp = dy;
                offset = 0;
                foreach (GenericJugador gg in gamers)
                {
                    if (actual.X == gg.X && actual.Y == gg.Y)
                    {
                        Image pb_o = this[gg];
                        if (pb_o != null)
                        {
                            //g.DrawImage(pb_o, gg.X * dx + shift, gg.Y * dy + shift, dx, dy);
                            g.DrawImage(pb_o,
                                new Rectangle(gg.X * dx + offset, gg.Y * dy + offset,
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
               // pb.Top = actual.Y * dy;
               // pb.Left = actual.X * dx;
            }


        }
    }

}
