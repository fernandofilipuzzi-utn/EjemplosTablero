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
        FormMaperDraw fmd;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        /*primero caso de uso*/
        private void button1_Click(object sender, EventArgs e)
        {
            //entrada de datos
            int ancho = 5;
            int alto = 5;

            //inicialización del tablero.
            //
            dataGridView1.RowCount = alto;
            dataGridView1.RowHeadersVisible = false;

            int height = dataGridView1.ClientSize.Height - dataGridView1.Margin.Bottom ;
            foreach(DataGridViewRow rv in dataGridView1.Rows)
            {
                rv.Height =height/alto;
            }
            
            dataGridView1.ColumnCount = alto;
            dataGridView1.ColumnHeadersVisible = false;

            int width = dataGridView1.ClientSize.Width - dataGridView1.Margin.Right;
            foreach (DataGridViewColumn cv in dataGridView1.Columns)
            {
                cv.Width = width / ancho;
            }

            //limpieza del tablero juego anterior.
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1[i, j].Value = "";
                }
            }

            //
            listBox1.Items.Clear();

            //
            cbTipoJugador.Items.Clear();
            cbTipoJugador.Items.Add("ONE");
            cbTipoJugador.Items.Add("TWO");
                       

            //
            pg = new EscaleraSerpientes(ancho,alto);


            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            groupBox3.Enabled = false;

            ///

            maperHelper = new Maper(panel1, panel1.Width, panel1.Height,
                                            pg.Ancho, pg.Alto);

            //
            fmd = new FormMaperDraw(pg.Ancho, pg.Alto);
            fmd.BackColor = Color.Gray;
            fmd.Show();
        }


        /*segundo caso de uso*/
        private void button2_Click(object sender, EventArgs e)
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

                groupBox3.Enabled = true;
                tbNombreJugador.Text = "";
                cbTipoJugador.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Complete los datos!");
            }
        }


        /*tercero caso de uso*/
        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox1.Enabled = true;

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
            string cell=(string)dataGridView1[antX, antY].Value;
            if (cell == null) cell = "";
            cell = cell.Replace(actual.Nombre,"");
            dataGridView1[antX, antY].Value=cell;

            //imprimir la posicion nueva
            cell = (string)dataGridView1[actual.X, actual.Y].Value;
            dataGridView1[actual.X, actual.Y].Value = cell+actual.Nombre;
            
            //

            string linea = "Nombre:" + actual.Nombre +
                    " (" + antX.ToString("00") + ", " + antY.ToString("00") + ")"+
                    "-> (" + actual.X.ToString("00") + ", " + actual.Y.ToString("00") + ")";

            listBox1.Items.Add(linea);

            listBox1.TopIndex = listBox1.Items.Count - 1;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
        }
    }
}
