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
            this.lb_codigo = new System.Windows.Forms.Label();
            this.lb_descripcion = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.tb_descripcion = new System.Windows.Forms.TextBox();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_codigo
            // 
            this.lb_codigo.AutoSize = true;
            this.lb_codigo.Location = new System.Drawing.Point(206, 112);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(40, 13);
            this.lb_codigo.TabIndex = 0;
            this.lb_codigo.Text = "Codigo";
            // 
            // lb_descripcion
            // 
            this.lb_descripcion.AutoSize = true;
            this.lb_descripcion.Location = new System.Drawing.Point(206, 160);
            this.lb_descripcion.Name = "lb_descripcion";
            this.lb_descripcion.Size = new System.Drawing.Size(63, 13);
            this.lb_descripcion.TabIndex = 1;
            this.lb_descripcion.Text = "Descripcion";
            // 
            // tb_codigo
            // 
            this.tb_codigo.Location = new System.Drawing.Point(285, 105);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(39, 20);
            this.tb_codigo.TabIndex = 2;
            this.tb_codigo.TextChanged += new System.EventHandler(this.tb_codigo_TextChanged);
            // 
            // tb_descripcion
            // 
            this.tb_descripcion.Location = new System.Drawing.Point(285, 157);
            this.tb_descripcion.Name = "tb_descripcion";
            this.tb_descripcion.Size = new System.Drawing.Size(267, 20);
            this.tb_descripcion.TabIndex = 3;
            this.tb_descripcion.TextChanged += new System.EventHandler(this.tb_descripcion_TextChanged);
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(330, 232);
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
            this.Controls.Add(this.tb_descripcion);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.lb_descripcion);
            this.Controls.Add(this.lb_codigo);
            this.Name = "FormUniMed";
            this.Text = "Ingreso Unidad de Medida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_codigo;
        private System.Windows.Forms.Label lb_descripcion;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.TextBox tb_descripcion;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Label lb_titulo;
    }
}