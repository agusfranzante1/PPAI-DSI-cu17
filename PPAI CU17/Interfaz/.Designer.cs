namespace PPAI_CU17
{
    partial class InterfazOperador
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
            this.txtNombre = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.lblSubOpcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValidacion1 = new System.Windows.Forms.TextBox();
            this.txtValidacion2 = new System.Windows.Forms.TextBox();
            this.txtValidacion3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(113, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(44, 13);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Nombre";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(122, 86);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 1;
            this.lblDNI.Text = "DNI";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(282, 53);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Location = new System.Drawing.Point(282, 86);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(41, 13);
            this.lblOpcion.TabIndex = 3;
            this.lblOpcion.Text = "Opcion";
            // 
            // lblSubOpcion
            // 
            this.lblSubOpcion.AutoSize = true;
            this.lblSubOpcion.Location = new System.Drawing.Point(282, 120);
            this.lblSubOpcion.Name = "lblSubOpcion";
            this.lblSubOpcion.Size = new System.Drawing.Size(60, 13);
            this.lblSubOpcion.TabIndex = 4;
            this.lblSubOpcion.Text = "SubOpcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "pregunta1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "pregunta2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "pregunta3";
            // 
            // txtValidacion1
            // 
            this.txtValidacion1.Location = new System.Drawing.Point(319, 229);
            this.txtValidacion1.Name = "txtValidacion1";
            this.txtValidacion1.Size = new System.Drawing.Size(100, 20);
            this.txtValidacion1.TabIndex = 8;
            // 
            // txtValidacion2
            // 
            this.txtValidacion2.Location = new System.Drawing.Point(319, 279);
            this.txtValidacion2.Name = "txtValidacion2";
            this.txtValidacion2.Size = new System.Drawing.Size(100, 20);
            this.txtValidacion2.TabIndex = 9;
            // 
            // txtValidacion3
            // 
            this.txtValidacion3.Location = new System.Drawing.Point(319, 336);
            this.txtValidacion3.Name = "txtValidacion3";
            this.txtValidacion3.Size = new System.Drawing.Size(100, 20);
            this.txtValidacion3.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(480, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 26);
            this.button2.TabIndex = 11;
            this.button2.Text = "Validar Datos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InterfazOperador
            // 
            this.ClientSize = new System.Drawing.Size(632, 588);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtValidacion3);
            this.Controls.Add(this.txtValidacion2);
            this.Controls.Add(this.txtValidacion1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSubOpcion);
            this.Controls.Add(this.lblOpcion);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtNombre);
            this.Name = "InterfazOperador";
            this.Load += new System.EventHandler(this.InterfazOperador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.Label lblSubOpcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValidacion1;
        private System.Windows.Forms.TextBox txtValidacion2;
        private System.Windows.Forms.TextBox txtValidacion3;
        private System.Windows.Forms.Button button2;
    }
}

