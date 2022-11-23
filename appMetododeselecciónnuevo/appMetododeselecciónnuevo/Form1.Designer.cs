
namespace appMetododeselecciónnuevo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.txtvector = new System.Windows.Forms.TextBox();
            this.lbltiempoenordenar = new System.Windows.Forms.Label();
            this.lblod = new System.Windows.Forms.Label();
            this.txttamaño = new System.Windows.Forms.TextBox();
            this.lbltamaño = new System.Windows.Forms.Label();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(383, 131);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(90, 25);
            this.btnEjecutar.TabIndex = 0;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // txtvector
            // 
            this.txtvector.BackColor = System.Drawing.Color.Black;
            this.txtvector.ForeColor = System.Drawing.SystemColors.Info;
            this.txtvector.Location = new System.Drawing.Point(12, 2);
            this.txtvector.Multiline = true;
            this.txtvector.Name = "txtvector";
            this.txtvector.Size = new System.Drawing.Size(212, 428);
            this.txtvector.TabIndex = 1;
            // 
            // lbltiempoenordenar
            // 
            this.lbltiempoenordenar.AutoSize = true;
            this.lbltiempoenordenar.ForeColor = System.Drawing.Color.Cyan;
            this.lbltiempoenordenar.Location = new System.Drawing.Point(263, 261);
            this.lbltiempoenordenar.Name = "lbltiempoenordenar";
            this.lbltiempoenordenar.Size = new System.Drawing.Size(125, 13);
            this.lbltiempoenordenar.TabIndex = 4;
            this.lbltiempoenordenar.Text = "Tiempo en ordenar datos";
            // 
            // lblod
            // 
            this.lblod.AutoSize = true;
            this.lblod.Location = new System.Drawing.Point(414, 261);
            this.lblod.Name = "lblod";
            this.lblod.Size = new System.Drawing.Size(22, 13);
            this.lblod.TabIndex = 6;
            this.lblod.Text = "0:0";
            // 
            // txttamaño
            // 
            this.txttamaño.BackColor = System.Drawing.Color.Black;
            this.txttamaño.ForeColor = System.Drawing.Color.White;
            this.txttamaño.Location = new System.Drawing.Point(365, 44);
            this.txttamaño.Multiline = true;
            this.txttamaño.Name = "txttamaño";
            this.txttamaño.Size = new System.Drawing.Size(100, 30);
            this.txttamaño.TabIndex = 7;
            // 
            // lbltamaño
            // 
            this.lbltamaño.AutoSize = true;
            this.lbltamaño.ForeColor = System.Drawing.Color.Cyan;
            this.lbltamaño.Location = new System.Drawing.Point(263, 55);
            this.lbltamaño.Name = "lbltamaño";
            this.lbltamaño.Size = new System.Drawing.Size(96, 13);
            this.lbltamaño.TabIndex = 8;
            this.lbltamaño.Text = "Tamaño del vector";
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(384, 162);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(90, 25);
            this.btnborrar.TabIndex = 9;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(465, 407);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 10;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(543, 442);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.lbltamaño);
            this.Controls.Add(this.txttamaño);
            this.Controls.Add(this.lblod);
            this.Controls.Add(this.lbltiempoenordenar);
            this.Controls.Add(this.txtvector);
            this.Controls.Add(this.btnEjecutar);
            this.Name = "Form1";
            this.Text = "Ordenamiento por selección";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.TextBox txtvector;
        private System.Windows.Forms.Label lbltiempoenordenar;
        private System.Windows.Forms.Label lblod;
        private System.Windows.Forms.TextBox txttamaño;
        private System.Windows.Forms.Label lbltamaño;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btncerrar;
    }
}

