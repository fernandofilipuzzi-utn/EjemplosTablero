﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace TableroObserver
{
    class Maper : IObservador
    {
        List<PictureBox> pictures = new List<PictureBox>();
        List<GenericJugador> gamers = new List<GenericJugador>();

        Control parent;
        int Height; int Width;
        int Heightt; int Widtht;

        public Maper(Control parent, int width, int height,
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
            PictureBox pb = new PictureBox();

            pb.Parent = parent;

            pb.Width = 20;
            pb.Height = 20;
            //pb.Image = Properties.Resources.caballero;
            pb.Image = Util.SelectImage( gg );

            pictures.Add(pb);

            pb.SizeMode = PictureBoxSizeMode.StretchImage;

            gamers.Add(gg);
        }

        public PictureBox this[GenericJugador gg]
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

            PictureBox pb = this[actual];
            if (pb != null)
            {
                pb.Top = actual.Y * dy;
                pb.Left = actual.X * dx;
            }
        }
    }
}
