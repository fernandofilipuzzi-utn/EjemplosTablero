using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TableroObserver
{
    public partial class FormTablero4 : Form, IObservador
    {
        private MaperDraw md;


        public FormTablero4(int Widtht, int Heightt)
        {
            InitializeComponent();
            md = new MaperDraw(this, Width, Height, Widtht, Heightt);
        }
        public void AgregarGG(GenericJugador gg)
        {
            md.AgregarGG(gg);
        }
        private void FormMaperDraw_Load(object sender, EventArgs e)
        {
           
        }

        public void Notificar(int antX, int antY, GenericJugador actual)
        {
            md.Notificar(antX, antY, actual);
        }
    }
}
