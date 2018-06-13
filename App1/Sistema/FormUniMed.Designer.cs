namespace Sistema
{
    partial class FormUniMed
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
            this.lb_abreviacion = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.tb_abreviacion = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_abreviacion
            // 
            this.lb_abreviacion.AutoSize = true;
            this.lb_abreviacion.Location = new System.Drawing.Point(206, 165);
            this.lb_abreviacion.Name = "lb_abreviacion";
            this.lb_abreviacion.Size = new System.Drawing.Size(63, 13);
            this.lb_abreviacion.TabIndex = 0;
            this.lb_abreviacion.Text = "Abreviacion";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(206, 107);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(70, 13);
            this.lb_nombre.TabIndex = 1;
            this.lb_nombre.Text = "Nombre U.M.";
            // 
            // tb_abreviacion
            // 
            this.tb_abreviacion.Location = new System.Drawing.Point(285, 162);
            this.tb_abreviacion.Name = "tb_abreviacion";
            this.tb_abreviacion.Size = new System.Drawing.Size(39, 20);
            this.tb_abreviacion.TabIndex = 2;
            this.tb_abreviacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_abreviacion_KeyPress);
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(285, 104);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(267, 20);
            this.tb_nombre.TabIndex = 3;
            this.tb_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nombre_KeyPress);
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(339, 238);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(75, 23);
            this.bt_guardar.TabIndex = 4;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Location = new System.Drawing.Point(282, 48);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(132, 13);
            this.lb_titulo.TabIndex = 5;
            this.lb_titulo.Text = "Ingreso Unidad de Medida";
            // 
            // FormUniMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.tb_abreviacion);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.lb_abreviacion);
            this.Name = "FormUniMed";
            this.Text = "Ingreso Unidad de Medida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_abreviacion;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.TextBox tb_abreviacion;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Label lb_titulo;
    }
}