namespace FormEjercicioException
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
            this.medicoextenso = new System.Windows.Forms.Button();
            this.crearvacio = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // medicoextenso
            // 
            this.medicoextenso.Location = new System.Drawing.Point(917, 51);
            this.medicoextenso.Name = "medicoextenso";
            this.medicoextenso.Size = new System.Drawing.Size(489, 147);
            this.medicoextenso.TabIndex = 0;
            this.medicoextenso.Text = "Crear Médico nombre Extenso";
            this.medicoextenso.UseVisualStyleBackColor = true;
            this.medicoextenso.Click += new System.EventHandler(this.button1_Click);
            // 
            // crearvacio
            // 
            this.crearvacio.Location = new System.Drawing.Point(917, 231);
            this.crearvacio.Name = "crearvacio";
            this.crearvacio.Size = new System.Drawing.Size(489, 147);
            this.crearvacio.TabIndex = 1;
            this.crearvacio.Text = "Crear médico nombre vacío";
            this.crearvacio.UseVisualStyleBackColor = true;
            this.crearvacio.Click += new System.EventHandler(this.crearvacio_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(917, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(489, 147);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2460, 731);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.crearvacio);
            this.Controls.Add(this.medicoextenso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button medicoextenso;
        private System.Windows.Forms.Button crearvacio;
        private System.Windows.Forms.Button button3;
    }
}

