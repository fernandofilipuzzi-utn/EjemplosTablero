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
            int fila = 0;
            int columna = 0;
            Util.CellToFilaColumna(cel, ref fila, ref columna);

            toolTip1.Show($"celda:{cel} - {{fila,columna}}:{{ {fila},{columna}}}; ", pictureBoxEscalera, 5000);
        }

        //

        void Dibujar(int cel)
        {
            int anchoColumna = pnlTablero.Width / Util.Columnas;
            int altoFila = pnlTablero.Height / Util.Renglones;

            int columna = 0, fila = 0;
            Util.CellToFilaColumna(cel, ref fila, ref columna);

            pictureBoxEscalera.Top = altoFila * fila + altoFila / 2;
            pictureBoxEscalera.Left = anchoColumna * columna + anchoColumna / 2;

            //alternativa
            //pictureBoxEscalera.Location=new Point { Y = altoFila* fila,X = anchoColumna * columna }; 
        }


        //hay una forma alternativa , poniendo una imagen de fondo.
        //el problema que tiene esa forma es que queda limitado
        //el cambiar el numero de filas y columnas
        private void pnlTablero_Paint(object sender, PaintEventArgs e)
        {

            //
            //este evento no está activo ahora!
            //como fondo del panel se coloca una imagen de la cuadricula
            //

            int anchoColumna = pnlTablero.Width / Util.Columnas;
            int altoFila = pnlTablero.Height / Util.Renglones;

            Graphics g = e.Graphics;

            Brush brushFondo = new SolidBrush(Color.LightBlue);
            g.FillRectangle(brushFondo, 0, 0, pnlTablero.Width - 2, pnlTablero.Height - 2);


            Brush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(brush);

            for (int fila = 0; fila < Util.Renglones; fila++)
            {
                int x1 = pnlTablero.Width; int y0 = altoFila * fila;
                int x0 = 0; int y1 = y0;
                g.DrawLine(pen, x0, y0, x1, y1);
            }

            for (int columna = 0; columna < Util.Columnas; columna++)
            {
                int x0 = anchoColumna * columna; int y0 = 0;
                int x1 = x0; int y1 = pnlTablero.Height;
                g.DrawLine(pen, x0, y0, x1, y1);
            }

            g.DrawRectangle(pen, 0, 0, pnlTablero.Width - 2, pnlTablero.Height - 2);
        }
    }
}
