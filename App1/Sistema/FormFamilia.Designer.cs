namespace Sistema
{
    partial class FormFamilia
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
            this.cm_linea = new System.Windows.Forms.ComboBox();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.tb_descripcion = new System.Windows.Forms.TextBox();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_codigo
            // 
            this.lb_codigo.AutoSize = true;
            this.lb_codigo.Location = new System.Drawing.Point(229, 111);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(84, 13);
            this.lb_codigo.TabIndex = 0;
            this.lb_codigo.Text = "Linea Productos";
            // 
            // lb_descripcion
            // 
            this.lb_descripcion.AutoSize = true;
            this.lb_descripcion.Location = new System.Drawing.Point(229, 156);
            this.lb_descripcion.Name = "lb_descripcion";
            this.lb_descripcion.Size = new System.Drawing.Size(98, 13);
            this.lb_descripcion.TabIndex = 1;
            this.lb_descripcion.Text = "Descripcion Familia";
            // 
            // cm_linea
            // 
            this.cm_linea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cm_linea.FormattingEnabled = true;
            this.cm_linea.Location = new System.Drawing.Point(363, 108);
            this.cm_linea.Name = "cm_linea";
            this.cm_linea.Size = new System.Drawing.Size(121, 21);
            this.cm_linea.TabIndex = 4;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Location = new System.Drawing.Point(318, 53);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(128, 13);
            this.lb_titulo.TabIndex = 6;
            this.lb_titulo.Text = "Ingreso Familia Productos";
            // 
            // tb_descripcion
            // 
            this.tb_descripcion.Location = new System.Drawing.Point(363, 156);
            this.tb_descripcion.Name = "tb_descripcion";
            this.tb_descripcion.Size = new System.Drawing.Size(221, 20);
            this.tb_descripcion.TabIndex = 7;
            this.tb_descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_descripcion_KeyPress);
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(363, 224);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(75, 23);
            this.bt_guardar.TabIndex = 8;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click_1);
            // 
            // FormFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.tb_descripcion);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.cm_linea);
            this.Controls.Add(this.lb_descripcion);
            this.Controls.Add(this.lb_codigo);
            this.Name = "FormFamilia";
            this.Text = "Ingreso Familia Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_codigo;
        private System.Windows.Forms.Label lb_descripcion;
        private System.Windows.Forms.ComboBox cm_linea;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.TextBox tb_descripcion;
        private System.Windows.Forms.Button bt_guardar;
    }
}