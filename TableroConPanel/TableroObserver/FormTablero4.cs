using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TableroObserver.Modelo;
using TableroObserver.Utils;

namespace TableroObserver
{
    public partial class FormTablero4 : Form, IObservador
    {
        private MapeadorGraphicsHelper mapeador;

        public FormTablero4(int Widtht, int Heightt)
        {
            InitializeComponent();
            mapeador = new MapeadorGraphicsHelper(this, Width, Height, Widtht, Heightt);
        }
        public void AgregarPersonaje(GenericJugador nuevoPersonaje)
        {
            mapeador.AgregarPersonaje(nuevoPersonaje);
        }
        private void FormTablero4_Load(object sender, EventArgs e)
        {
        }

        public void Notificar(int antX, int antY, GenericJugador actual)
        {
            mapeador.Notificar(antX, antY, actual);
        }
    }
}
