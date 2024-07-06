namespace EjemploControles
{
    partial class Calendario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calFecha = new System.Windows.Forms.MonthCalendar();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnPruebaUno = new System.Windows.Forms.Button();
            this.btnPruebaDos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calFecha
            // 
            this.calFecha.Location = new System.Drawing.Point(304, 208);
            this.calFecha.Name = "calFecha";
            this.calFecha.TabIndex = 0;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(321, 138);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // btnPruebaUno
            // 
            this.btnPruebaUno.Location = new System.Drawing.Point(598, 138);
            this.btnPruebaUno.Name = "btnPruebaUno";
            this.btnPruebaUno.Size = new System.Drawing.Size(75, 23);
            this.btnPruebaUno.TabIndex = 2;
            this.btnPruebaUno.Text = "Prueba 1";
            this.btnPruebaUno.UseVisualStyleBackColor = true;
            this.btnPruebaUno.Click += new System.EventHandler(this.btnPruebaUno_Click);
            // 
            // btnPruebaDos
            // 
            this.btnPruebaDos.Location = new System.Drawing.Point(598, 208);
            this.btnPruebaDos.Name = "btnPruebaDos";
            this.btnPruebaDos.Size = new System.Drawing.Size(75, 23);
            this.btnPruebaDos.TabIndex = 3;
            this.btnPruebaDos.Text = "Prueba 2";
            this.btnPruebaDos.UseVisualStyleBackColor = true;
            this.btnPruebaDos.Click += new System.EventHandler(this.btnPruebaDos_Click);
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPruebaDos);
            this.Controls.Add(this.btnPruebaUno);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.calFecha);
            this.Name = "Calendario";
            this.Text = "Calendario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnPruebaUno;
        private System.Windows.Forms.Button btnPruebaDos;
    }
}