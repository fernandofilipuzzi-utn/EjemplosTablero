namespace TableroObserver
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearJuego = new System.Windows.Forms.Button();
            this.btnAgregarPersonaje = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.dgvTablero1 = new System.Windows.Forms.DataGridView();
            this.lbxTablero3 = new System.Windows.Forms.ListBox();
            this.tbNombreJugador = new System.Windows.Forms.TextBox();
            this.cbTipoJugador = new System.Windows.Forms.ComboBox();
            this.gbInicioJuego = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gbAgregarPersonaje = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbJugar = new System.Windows.Forms.GroupBox();
            this.pnlTablero2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablero1)).BeginInit();
            this.gbInicioJuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gbAgregarPersonaje.SuspendLayout();
            this.gbJugar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearJuego
            // 
            this.btnCrearJuego.Location = new System.Drawing.Point(197, 23);
            this.btnCrearJuego.Name = "btnCrearJuego";
            this.btnCrearJuego.Size = new System.Drawing.Size(190, 23);
            this.btnCrearJuego.TabIndex = 0;
            this.btnCrearJuego.Text = "Crear el juego";
            this.btnCrearJuego.UseVisualStyleBackColor = true;
            this.btnCrearJuego.Click += new System.EventHandler(this.btnCrearJuego_Click);
            // 
            // btnAgregarPersonaje
            // 
            this.btnAgregarPersonaje.Location = new System.Drawing.Point(197, 35);
            this.btnAgregarPersonaje.Name = "btnAgregarPersonaje";
            this.btnAgregarPersonaje.Size = new System.Drawing.Size(190, 23);
            this.btnAgregarPersonaje.TabIndex = 1;
            this.btnAgregarPersonaje.Text = "Agregar Personaje";
            this.btnAgregarPersonaje.UseVisualStyleBackColor = true;
            this.btnAgregarPersonaje.Click += new System.EventHandler(this.btnAgregarPersonaje_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(197, 31);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(190, 23);
            this.btnJugar.TabIndex = 2;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // dgvTablero1
            // 
            this.dgvTablero1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablero1.Location = new System.Drawing.Point(12, 22);
            this.dgvTablero1.Name = "dgvTablero1";
            this.dgvTablero1.Size = new System.Drawing.Size(396, 221);
            this.dgvTablero1.TabIndex = 3;
            // 
            // lbxTablero3
            // 
            this.lbxTablero3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxTablero3.FormattingEnabled = true;
            this.lbxTablero3.ItemHeight = 18;
            this.lbxTablero3.Location = new System.Drawing.Point(420, 249);
            this.lbxTablero3.Name = "lbxTablero3";
            this.lbxTablero3.Size = new System.Drawing.Size(391, 256);
            this.lbxTablero3.TabIndex = 4;
            // 
            // tbNombreJugador
            // 
            this.tbNombreJugador.Location = new System.Drawing.Point(6, 37);
            this.tbNombreJugador.Name = "tbNombreJugador";
            this.tbNombreJugador.Size = new System.Drawing.Size(49, 20);
            this.tbNombreJugador.TabIndex = 5;
            // 
            // cbTipoJugador
            // 
            this.cbTipoJugador.FormattingEnabled = true;
            this.cbTipoJugador.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cbTipoJugador.Location = new System.Drawing.Point(73, 36);
            this.cbTipoJugador.Name = "cbTipoJugador";
            this.cbTipoJugador.Size = new System.Drawing.Size(65, 21);
            this.cbTipoJugador.TabIndex = 6;
            // 
            // gbInicioJuego
            // 
            this.gbInicioJuego.Controls.Add(this.numericUpDown2);
            this.gbInicioJuego.Controls.Add(this.numericUpDown1);
            this.gbInicioJuego.Controls.Add(this.btnCrearJuego);
            this.gbInicioJuego.Location = new System.Drawing.Point(414, 22);
            this.gbInicioJuego.Name = "gbInicioJuego";
            this.gbInicioJuego.Size = new System.Drawing.Size(396, 64);
            this.gbInicioJuego.TabIndex = 7;
            this.gbInicioJuego.TabStop = false;
            this.gbInicioJuego.Text = "Inicio del juego";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(94, 22);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(23, 23);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // gbAgregarPersonaje
            // 
            this.gbAgregarPersonaje.Controls.Add(this.label1);
            this.gbAgregarPersonaje.Controls.Add(this.tbNombreJugador);
            this.gbAgregarPersonaje.Controls.Add(this.cbTipoJugador);
            this.gbAgregarPersonaje.Controls.Add(this.btnAgregarPersonaje);
            this.gbAgregarPersonaje.Location = new System.Drawing.Point(414, 92);
            this.gbAgregarPersonaje.Name = "gbAgregarPersonaje";
            this.gbAgregarPersonaje.Size = new System.Drawing.Size(396, 68);
            this.gbAgregarPersonaje.TabIndex = 8;
            this.gbAgregarPersonaje.TabStop = false;
            this.gbAgregarPersonaje.Text = "Agregar Personaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // gbJugar
            // 
            this.gbJugar.Controls.Add(this.btnJugar);
            this.gbJugar.Location = new System.Drawing.Point(414, 166);
            this.gbJugar.Name = "gbJugar";
            this.gbJugar.Size = new System.Drawing.Size(396, 60);
            this.gbJugar.TabIndex = 9;
            this.gbJugar.TabStop = false;
            this.gbJugar.Text = "Jugar";
            // 
            // pnlTablero2
            // 
            this.pnlTablero2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlTablero2.Location = new System.Drawing.Point(12, 249);
            this.pnlTablero2.Name = "pnlTablero2";
            this.pnlTablero2.Size = new System.Drawing.Size(396, 263);
            this.pnlTablero2.TabIndex = 10;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 520);
            this.Controls.Add(this.pnlTablero2);
            this.Controls.Add(this.gbJugar);
            this.Controls.Add(this.gbAgregarPersonaje);
            this.Controls.Add(this.gbInicioJuego);
            this.Controls.Add(this.lbxTablero3);
            this.Controls.Add(this.dgvTablero1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPrincipal";
            this.Text = "Prueba patrón observer en multiples vistas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablero1)).EndInit();
            this.gbInicioJuego.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gbAgregarPersonaje.ResumeLayout(false);
            this.gbAgregarPersonaje.PerformLayout();
            this.gbJugar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearJuego;
        private System.Windows.Forms.Button btnAgregarPersonaje;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.DataGridView dgvTablero1;
        private System.Windows.Forms.ListBox lbxTablero3;
        private System.Windows.Forms.TextBox tbNombreJugador;
        private System.Windows.Forms.ComboBox cbTipoJugador;
        private System.Windows.Forms.GroupBox gbInicioJuego;
        private System.Windows.Forms.GroupBox gbAgregarPersonaje;
        private System.Windows.Forms.GroupBox gbJugar;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel pnlTablero2;
        private System.Windows.Forms.Label label1;
    }
}

