namespace Sistema
{
    partial class FormRegistroProducto
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
            this.lb_codigobarra = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.lb_unidadmedida = new System.Windows.Forms.Label();
            this.lb_marca = new System.Windows.Forms.Label();
            this.lb_formato = new System.Windows.Forms.Label();
            this.lb_linea = new System.Windows.Forms.Label();
            this.lb_familia = new System.Windows.Forms.Label();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.cm_unidadmedida = new System.Windows.Forms.ComboBox();
            this.cm_linea = new System.Windows.Forms.ComboBox();
            this.cm_familia = new System.Windows.Forms.ComboBox();
            this.tb_codigobarra = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_marca = new System.Windows.Forms.TextBox();
            this.tb_formato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_codigobarra
            // 
            this.lb_codigobarra.AutoSize = true;
            this.lb_codigobarra.Location = new System.Drawing.Point(127, 84);
            this.lb_codigobarra.Name = "lb_codigobarra";
            this.lb_codigobarra.Size = new System.Drawing.Size(86, 13);
            this.lb_codigobarra.TabIndex = 0;
            this.lb_codigobarra.Text = "Codigo de  Barra";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(127, 121);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(44, 13);
            this.lb_nombre.TabIndex = 1;
            this.lb_nombre.Text = "Nombre";
            // 
            // lb_unidadmedida
            // 
            this.lb_unidadmedida.AutoSize = true;
            this.lb_unidadmedida.Location = new System.Drawing.Point(128, 158);
            this.lb_unidadmedida.Name = "lb_unidadmedida";
            this.lb_unidadmedida.Size = new System.Drawing.Size(93, 13);
            this.lb_unidadmedida.TabIndex = 2;
            this.lb_unidadmedida.Text = "Unidad de medida";
            // 
            // lb_marca
            // 
            this.lb_marca.AutoSize = true;
            this.lb_marca.Location = new System.Drawing.Point(127, 202);
            this.lb_marca.Name = "lb_marca";
            this.lb_marca.Size = new System.Drawing.Size(37, 13);
            this.lb_marca.TabIndex = 3;
            this.lb_marca.Text = "Marca";
            // 
            // lb_formato
            // 
            this.lb_formato.AutoSize = true;
            this.lb_formato.Location = new System.Drawing.Point(127, 249);
            this.lb_formato.Name = "lb_formato";
            this.lb_formato.Size = new System.Drawing.Size(45, 13);
            this.lb_formato.TabIndex = 4;
            this.lb_formato.Text = "Formato";
            // 
            // lb_linea
            // 
            this.lb_linea.AutoSize = true;
            this.lb_linea.Location = new System.Drawing.Point(130, 288);
            this.lb_linea.Name = "lb_linea";
            this.lb_linea.Size = new System.Drawing.Size(33, 13);
            this.lb_linea.TabIndex = 5;
            this.lb_linea.Text = "Linea";
            this.lb_linea.Click += new System.EventHandler(this.label6_Click);
            // 
            // lb_familia
            // 
            this.lb_familia.AutoSize = true;
            this.lb_familia.Location = new System.Drawing.Point(130, 331);
            this.lb_familia.Name = "lb_familia";
            this.lb_familia.Size = new System.Drawing.Size(39, 13);
            this.lb_familia.TabIndex = 6;
            this.lb_familia.Text = "Familia";
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(368, 387);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(75, 23);
            this.bt_guardar.TabIndex = 7;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cm_unidadmedida
            // 
            this.cm_unidadmedida.FormattingEnabled = true;
            this.cm_unidadmedida.Location = new System.Drawing.Point(247, 158);
            this.cm_unidadmedida.Name = "cm_unidadmedida";
            this.cm_unidadmedida.Size = new System.Drawing.Size(121, 21);
            this.cm_unidadmedida.TabIndex = 8;
            // 
            // cm_linea
            // 
            this.cm_linea.FormattingEnabled = true;
            this.cm_linea.Location = new System.Drawing.Point(247, 288);
            this.cm_linea.Name = "cm_linea";
            this.cm_linea.Size = new System.Drawing.Size(121, 21);
            this.cm_linea.TabIndex = 9;
            // 
            // cm_familia
            // 
            this.cm_familia.FormattingEnabled = true;
            this.cm_familia.Location = new System.Drawing.Point(247, 331);
            this.cm_familia.Name = "cm_familia";
            this.cm_familia.Size = new System.Drawing.Size(121, 21);
            this.cm_familia.TabIndex = 10;
            this.cm_familia.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // tb_codigobarra
            // 
            this.tb_codigobarra.Location = new System.Drawing.Point(247, 84);
            this.tb_codigobarra.Name = "tb_codigobarra";
            this.tb_codigobarra.Size = new System.Drawing.Size(100, 20);
            this.tb_codigobarra.TabIndex = 11;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(247, 121);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(243, 20);
            this.tb_nombre.TabIndex = 12;
            this.tb_nombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb_marca
            // 
            this.tb_marca.Location = new System.Drawing.Point(247, 202);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(143, 20);
            this.tb_marca.TabIndex = 13;
            // 
            // tb_formato
            // 
            this.tb_formato.Location = new System.Drawing.Point(247, 241);
            this.tb_formato.Name = "tb_formato";
            this.tb_formato.Size = new System.Drawing.Size(143, 20);
            this.tb_formato.TabIndex = 14;
            // 
            // FormRegistroProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_formato);
            this.Controls.Add(this.tb_marca);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.tb_codigobarra);
            this.Controls.Add(this.cm_familia);
            this.Controls.Add(this.cm_linea);
            this.Controls.Add(this.cm_unidadmedida);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.lb_familia);
            this.Controls.Add(this.lb_linea);
            this.Controls.Add(this.lb_formato);
            this.Controls.Add(this.lb_marca);
            this.Controls.Add(this.lb_unidadmedida);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.lb_codigobarra);
            this.Name = "FormRegistroProducto";
            this.Text = "FormRegistroArticulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_codigobarra;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label lb_unidadmedida;
        private System.Windows.Forms.Label lb_marca;
        private System.Windows.Forms.Label lb_formato;
        private System.Windows.Forms.Label lb_linea;
        private System.Windows.Forms.Label lb_familia;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.ComboBox cm_unidadmedida;
        private System.Windows.Forms.ComboBox cm_linea;
        private System.Windows.Forms.ComboBox cm_familia;
        private System.Windows.Forms.TextBox tb_codigobarra;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_marca;
        private System.Windows.Forms.TextBox tb_formato;
    }
}