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
    public partial class FormPrincipal : Form, IObservador
    {
        EscaleraSerpientes pg;
        Maper maperHelper;
        FormTablero4 fmd;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbInicioJuego.Enabled = true;
            gbAgregarPersonaje.Enabled = false;
            gbJugar.Enabled = false;
        }

        /*primero caso de uso*/
        private void btnCrearJuego_Click(object sender, EventArgs e)
        {
            //entrada de datos
            int ancho = 5;
            int alto = 5;

            //inicialización del tablero.
            //
            dgvTablero1.RowCount = alto;
            dgvTablero1.RowHeadersVisible = false;

            int height = dgvTablero1.ClientSize.Height - dgvTablero1.Margin.Bottom ;
            foreach(DataGridViewRow rv in dgvTablero1.Rows)
            {
                rv.Height =height/alto;
            }
            
            dgvTablero1.ColumnCount = alto;
            dgvTablero1.ColumnHeadersVisible = false;

            int width = dgvTablero1.ClientSize.Width - dgvTablero1.Margin.Right;
            foreach (DataGridViewColumn cv in dgvTablero1.Columns)
            {
                cv.Width = width / ancho;
            }

            //limpieza del tablero juego anterior.
            for (int i = 0; i < dgvTablero1.RowCount; i++)
            {
                for (int j = 0; j < dgvTablero1.ColumnCount; j++)
                {
                    dgvTablero1[i, j].Value = "";
                }
            }

            //
            lbxTablero3.Items.Clear();

            //
            cbTipoJugador.Items.Clear();
            cbTipoJugador.Items.Add("ONE");
            cbTipoJugador.Items.Add("TWO");
                       

            //
            pg = new EscaleraSerpientes(ancho,alto);

            gbInicioJuego.Enabled = false;
            gbAgregarPersonaje.Enabled = true;
            gbJugar.Enabled = false;

            //
            maperHelper = new Maper(pnlTablero2, pnlTablero2.Width, pnlTablero2.Height, pg.Ancho, pg.Alto);

            //
            fmd = new FormTablero4(pg.Ancho, pg.Alto);
            fmd.BackColor = Color.Gray;
            fmd.Show();
        }


        /*segundo caso de uso*/
        private void btnAgregarPersonaje_Click(object sender, EventArgs e)
        {
            //captura de datos de la pantalla.
            string nombre = tbNombreJugador.Text;
            int tipo = cbTipoJugador.SelectedIndex;

            //validador de las entradas 
            if (tipo != -1 && string.IsNullOrEmpty(nombre.Trim())==false)
            {
                
                /*proceso*/
                GenericJugador gg;
                gg = pg.AgregarJugador(nombre, (EscaleraSerpientes.TipoJugador)tipo);
                
                gg.AgregarObs(this);
                gg.AgregarObs(maperHelper);
                gg.AgregarObs(fmd);

                maperHelper.AgregarGG(gg);
                fmd.AgregarGG(gg);

                //Imprimir(gg);

                gbJugar.Enabled = true;
                tbNombreJugador.Text = "";
                cbTipoJugador.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Complete los datos!");
            }
        }


        /*tercero caso de uso*/
        private void btnJugar_Click(object sender, EventArgs e)
        {
            gbAgregarPersonaje.Enabled = false;
            gbInicioJuego.Enabled = true;

            pg.Jugar();

            /*
             * METODO simple para actualizar las posiciones si no tuviera el observer implementado
            /Limpiar();
            foreach (GenericJugador gg in pg.ListarJugadores())
            {
                Imprimir(gg);
            }
             
        }
        
        
         * forma de la programación tradicional.
         * 
        private void Limpiar()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1[i, j].Value = "";
                }
            }
        }

        private void Imprimir(GenericJugador gg)
        {
            //
            
            dataGridView1[gg.X, gg.Y].Value = gg.Nombre;
            //
            string linea = "Nombre:" + gg.Nombre + " (" + gg.X.ToString("00") + ", " + gg.Y.ToString("00") + ")";
            listBox1.Items.Add(linea);
        }
        */
        }

        public void Notificar(int antX, int antY, GenericJugador actual)
        {
            //limpiar la posicion anterior
            //ACB
            string cell=(string)dgvTablero1[antX, antY].Value;
            if (cell == null) cell = "";
            cell = cell.Replace(actual.Nombre,"");
            dgvTablero1[antX, antY].Value=cell;

            //imprimir la posicion nueva
            cell = (string)dgvTablero1[actual.X, actual.Y].Value;
            dgvTablero1[actual.X, actual.Y].Value = cell+actual.Nombre;
            
            //

            string linea = "Nombre:" + actual.Nombre +
                    " (" + antX.ToString("00") + ", " + antY.ToString("00") + ")"+
                    "-> (" + actual.X.ToString("00") + ", " + actual.Y.ToString("00") + ")";

            lbxTablero3.Items.Add(linea);

            lbxTablero3.TopIndex = lbxTablero3.Items.Count - 1;
        }
    }
}
