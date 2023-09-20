using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TableroConPanel
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
        }
            

        private void nudNumeroCelda_ValueChanged(object sender, EventArgs e)
        {
            int cel = Convert.ToInt32(nudNumeroCelda.Value);
            Dibujar(cel);
        }

        private void PictureBoxEscalera_Click(object sender, EventArgs e)
        {
            int cel = Convert.ToInt32(nudNumeroCelda.Value);
            int fila=0;
            int columna=0;
            Util.CellToFilaColumna(cel, ref fila, ref columna);

            toolTip1.Show($"celda:{cel} - {{fila,columna}}:{{ {fila},{columna}}}; ", PictureBoxEscalera, 5000);
        }

        //

        void Dibujar(int cel)
        {
            int Aw = pnlTablero.Width / Util.Columnas;
            int Ah = pnlTablero.Height / Util.Renglones;

            int columna = 0, fila = 0;
            Util.CellToFilaColumna(cel, ref fila, ref columna);

            PictureBoxEscalera.Top = Ah * fila;
            PictureBoxEscalera.Left = Aw * columna;

            //alternativa
            //PictureBoxEscalera.Location=new Point { Y = Ah* fila,X = Aw * columna }; 
        }
    }
}
