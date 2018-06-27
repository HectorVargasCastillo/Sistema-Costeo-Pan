namespace Sistema
{
    partial class FormIngresoLineaProducto
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
            this.lb_descripcionlinea = new System.Windows.Forms.Label();
            this.tb_descripcionlinea = new System.Windows.Forms.TextBox();
            this.dg_mostrar = new System.Windows.Forms.DataGridView();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_descripcionlinea
            // 
            this.lb_descripcionlinea.AutoSize = true;
            this.lb_descripcionlinea.Location = new System.Drawing.Point(116, 137);
            this.lb_descripcionlinea.Name = "lb_descripcionlinea";
            this.lb_descripcionlinea.Size = new System.Drawing.Size(92, 13);
            this.lb_descripcionlinea.TabIndex = 0;
            this.lb_descripcionlinea.Text = "Descripcion Linea";
            // 
            // tb_descripcionlinea
            // 
            this.tb_descripcionlinea.Location = new System.Drawing.Point(214, 134);
            this.tb_descripcionlinea.Name = "tb_descripcionlinea";
            this.tb_descripcionlinea.Size = new System.Drawing.Size(243, 20);
            this.tb_descripcionlinea.TabIndex = 13;
            // 
            // dg_mostrar
            // 
            this.dg_mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_mostrar.Location = new System.Drawing.Point(204, 201);
            this.dg_mostrar.Name = "dg_mostrar";
            this.dg_mostrar.Size = new System.Drawing.Size(343, 150);
            this.dg_mostrar.TabIndex = 15;
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_eliminar.Location = new System.Drawing.Point(432, 357);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(75, 23);
            this.bt_eliminar.TabIndex = 18;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = false;
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_editar.Location = new System.Drawing.Point(324, 357);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(75, 23);
            this.bt_editar.TabIndex = 17;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = false;
            // 
            // bt_guardar
            // 
            this.bt_guardar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_guardar.Location = new System.Drawing.Point(214, 357);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(75, 23);
            this.bt_guardar.TabIndex = 16;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.UseVisualStyleBackColor = false;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(204, 408);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 19;
            this.tb_id.Visible = false;
            // 
            // FormIngresoLineaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.dg_mostrar);
            this.Controls.Add(this.tb_descripcionlinea);
            this.Controls.Add(this.lb_descripcionlinea);
            this.Name = "FormIngresoLineaProducto";
            this.Text = "FormIngresoLineaProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_descripcionlinea;
        private System.Windows.Forms.TextBox tb_descripcionlinea;
        private System.Windows.Forms.DataGridView dg_mostrar;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.TextBox tb_id;
    }
}