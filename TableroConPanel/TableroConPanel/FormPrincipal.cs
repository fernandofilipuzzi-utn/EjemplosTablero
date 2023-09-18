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

        

        void dibujar(int cel)
        {
            int Aw = panel1.Width / Util.columnas;
            int Ah = panel1.Width / Util.renglones;

            int x = 0, y = 0;
            Util.cellToxy(cel, ref x, ref y);

            escalera.Top = Aw * y;
            escalera.Left = Aw * x;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int cel = Convert.ToInt32(numericUpDown1.Value);
            dibujar(cel);
        }

        

    }
}
