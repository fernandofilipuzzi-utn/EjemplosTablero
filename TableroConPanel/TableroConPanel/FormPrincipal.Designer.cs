namespace TableroConPanel
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
            this.components = new System.ComponentModel.Container();
            this.nudNumeroCelda = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxEscalera = new System.Windows.Forms.PictureBox();
            this.pnlTablero = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroCelda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEscalera)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNumeroCelda
            // 
            this.nudNumeroCelda.Location = new System.Drawing.Point(142, 334);
            this.nudNumeroCelda.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudNumeroCelda.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumeroCelda.Name = "nudNumeroCelda";
            this.nudNumeroCelda.Size = new System.Drawing.Size(120, 20);
            this.nudNumeroCelda.TabIndex = 3;
            this.nudNumeroCelda.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumeroCelda.ValueChanged += new System.EventHandler(this.nudNumeroCelda_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mover elemento (al cambiar el numericUpDown)";
            // 
            // pictureBoxEscalera
            // 
            this.pictureBoxEscalera.Image = global::TableroConPanel.Properties.Resources.images;
            this.pictureBoxEscalera.Location = new System.Drawing.Point(552, 212);
            this.pictureBoxEscalera.Name = "pictureBoxEscalera";
            this.pictureBoxEscalera.Size = new System.Drawing.Size(59, 52);
            this.pictureBoxEscalera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEscalera.TabIndex = 1;
            this.pictureBoxEscalera.TabStop = false;
            this.pictureBoxEscalera.Click += new System.EventHandler(this.PictureBoxEscalera_Click);
            // 
            // pnlTablero
            // 
            this.pnlTablero.BackgroundImage = global::TableroConPanel.Properties.Resources.fondo;
            this.pnlTablero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTablero.Location = new System.Drawing.Point(12, 12);
            this.pnlTablero.Name = "pnlTablero";
            this.pnlTablero.Size = new System.Drawing.Size(494, 316);
            this.pnlTablero.TabIndex = 0;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudNumeroCelda);
            this.Controls.Add(this.pictureBoxEscalera);
            this.Controls.Add(this.pnlTablero);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroCelda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEscalera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTablero;
        private System.Windows.Forms.PictureBox pictureBoxEscalera;
        private System.Windows.Forms.NumericUpDown nudNumeroCelda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

