using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TableroObserver.Utils;
using TableroObserver.Modelo;

namespace TableroObserver
{
    public partial class FormPrincipal : Form, IObservador
    {
        EscaleraSerpientes pg;
        MapeadorPictureBoxHelper mapeadorHelper;
        FormTablero4 fTablero4;

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

        /// <summary>
        /// primero caso de uso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrearJuego_Click(object sender, EventArgs e)
        {
            //entrada de datos
            int ancho = 5;
            int alto = 5;

            #region inicialización del tablero.
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
            #endregion

            #region limpieza del tablero juego anterior.
            //
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
            if (fTablero4 != null)
            {
                fTablero4.Close();
                fTablero4.Dispose();
            }
            #endregion

            //
            cbTipoJugador.Items.Clear();
            cbTipoJugador.Items.Add("ONE");
            cbTipoJugador.Items.Add("TWO");


            #region creando el juego
            pg = new EscaleraSerpientes(ancho,alto);

            gbInicioJuego.Enabled = false;
            gbAgregarPersonaje.Enabled = true;
            gbJugar.Enabled = false;

            //
            mapeadorHelper = new MapeadorPictureBoxHelper(pnlTablero2, pnlTablero2.Width, pnlTablero2.Height, pg.Ancho, pg.Alto);

            //
            fTablero4 = new FormTablero4(pg.Ancho, pg.Alto);
            fTablero4.BackColor = Color.Gray;
            fTablero4.Show();
            #endregion
        }


        /// <summary>
        /// segundo caso de uso
        /// </summary>
        private void btnAgregarPersonaje_Click(object sender, EventArgs e)
        {
            //captura de datos de la pantalla.
            string nombre = tbNombreJugador.Text;
            int tipo = cbTipoJugador.SelectedIndex;

            //validador de las entradas 
            if (tipo != -1 && string.IsNullOrEmpty(nombre.Trim())==false)
            {
                
                /*proceso*/
                GenericJugador nuevoPersonaje;
                nuevoPersonaje = pg.AgregarJugador(nombre, (EscaleraSerpientes.TipoJugador)tipo);
                
                nuevoPersonaje.AgregarObs(this);
                nuevoPersonaje.AgregarObs(mapeadorHelper);
                nuevoPersonaje.AgregarObs(fTablero4);

                mapeadorHelper.AgregarPersonaje(nuevoPersonaje);
                fTablero4.AgregarPersonaje(nuevoPersonaje);

                //Imprimir(nuevoPersonaje);

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
            foreach (GenericJugador nuevoPersonaje in pg.ListarJugadores())
            {
                Imprimir(nuevoPersonaje);
            }
             
        }
        
        
         * forma de la programación tradicional.
         * 
        private void Limpiar()
        {
            for (int i = 0; i < dgvTablero1.RowCount; i++)
            {
                for (int j = 0; j < dgvTablero1.ColumnCount; j++)
                {
                    dgvTablero1[i, j].Value = "";
                }
            }
        }

        private void Imprimir(GenericJugador nuevoPersonaje)
        {
            //
            
            dgvTablero1[nuevoPersonaje.X, nuevoPersonaje.Y].Value = nuevoPersonaje.Nombre;
            //
            string linea = "Nombre:" + nuevoPersonaje.Nombre + " (" + nuevoPersonaje.X.ToString("00") + ", " + nuevoPersonaje.Y.ToString("00") + ")";
            lbxtablero3.Items.Add(linea);
        }
        */
        }

        public void Notificar(int antX, int antY, GenericJugador actual)
        {
            #region limpiar la posicion anterior
            string cell=(string)dgvTablero1[antX, antY].Value;
            if (cell == null) cell = "";
            cell = cell.Replace(actual.Nombre,"");
            dgvTablero1[antX, antY].Value=cell;
            #endregion

            #region imprimir la posicion nueva
            cell = (string)dgvTablero1[actual.X, actual.Y].Value;
            dgvTablero1[actual.X, actual.Y].Value = cell+actual.Nombre;
            #endregion
            //

            string linea = "Nombre:" + actual.Nombre +
                    " (" + antX.ToString("00") + ", " + antY.ToString("00") + ")"+
                    "-> (" + actual.X.ToString("00") + ", " + actual.Y.ToString("00") + ")";

            lbxTablero3.Items.Add(linea);
            lbxTablero3.TopIndex = lbxTablero3.Items.Count - 1;
        }
    }
}
