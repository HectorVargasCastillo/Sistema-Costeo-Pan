namespace Sistema
{
    partial class FormIngReceta
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
            this.bt_guardar = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.dg_mostrar = new System.Windows.Forms.DataGridView();
            this.cm_producto = new System.Windows.Forms.ComboBox();
            this.lb_producto = new System.Windows.Forms.Label();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_estado = new System.Windows.Forms.TextBox();
            this.lb_insumo = new System.Windows.Forms.Label();
            this.lb_unimed = new System.Windows.Forms.Label();
            this.lb_cantidad = new System.Windows.Forms.Label();
            this.cm_insumo = new System.Windows.Forms.ComboBox();
            this.cm_unimed = new System.Windows.Forms.ComboBox();
            this.tb_cantidad = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_guardar
            // 
            this.bt_guardar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_guardar.Location = new System.Drawing.Point(242, 378);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(75, 23);
            this.bt_guardar.TabIndex = 14;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_editar.Location = new System.Drawing.Point(373, 378);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(75, 23);
            this.bt_editar.TabIndex = 1;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = false;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_eliminar.Location = new System.Drawing.Point(488, 378);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(75, 23);
            this.bt_eliminar.TabIndex = 2;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = false;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // dg_mostrar
            // 
            this.dg_mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_mostrar.Location = new System.Drawing.Point(159, 203);
            this.dg_mostrar.Name = "dg_mostrar";
            this.dg_mostrar.Size = new System.Drawing.Size(470, 150);
            this.dg_mostrar.TabIndex = 3;
            this.dg_mostrar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gd_mostrar_CellDoubleClick);
            // 
            // cm_producto
            // 
            this.cm_producto.FormattingEnabled = true;
            this.cm_producto.Location = new System.Drawing.Point(316, 61);
            this.cm_producto.Name = "cm_producto";
            this.cm_producto.Size = new System.Drawing.Size(121, 21);
            this.cm_producto.TabIndex = 4;
            this.cm_producto.SelectionChangeCommitted += new System.EventHandler(this.cm_producto_SelectionChangedCommited);
            // 
            // lb_producto
            // 
            this.lb_producto.AutoSize = true;
            this.lb_producto.Location = new System.Drawing.Point(200, 64);
            this.lb_producto.Name = "lb_producto";
            this.lb_producto.Size = new System.Drawing.Size(75, 13);
            this.lb_producto.TabIndex = 5;
            this.lb_producto.Text = "Producto Final";
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Location = new System.Drawing.Point(324, 27);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(95, 13);
            this.lb_titulo.TabIndex = 6;
            this.lb_titulo.Text = "Ingreso de Receta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Estado";
            // 
            // tb_estado
            // 
            this.tb_estado.Location = new System.Drawing.Point(316, 104);
            this.tb_estado.Name = "tb_estado";
            this.tb_estado.Size = new System.Drawing.Size(100, 20);
            this.tb_estado.TabIndex = 8;
            // 
            // lb_insumo
            // 
            this.lb_insumo.AutoSize = true;
            this.lb_insumo.Location = new System.Drawing.Point(206, 144);
            this.lb_insumo.Name = "lb_insumo";
            this.lb_insumo.Size = new System.Drawing.Size(41, 13);
            this.lb_insumo.TabIndex = 9;
            this.lb_insumo.Text = "Insumo";
            // 
            // lb_unimed
            // 
            this.lb_unimed.AutoSize = true;
            this.lb_unimed.Location = new System.Drawing.Point(347, 143);
            this.lb_unimed.Name = "lb_unimed";
            this.lb_unimed.Size = new System.Drawing.Size(79, 13);
            this.lb_unimed.TabIndex = 10;
            this.lb_unimed.Text = "Unidad Medida";
            // 
            // lb_cantidad
            // 
            this.lb_cantidad.AutoSize = true;
            this.lb_cantidad.Location = new System.Drawing.Point(490, 142);
            this.lb_cantidad.Name = "lb_cantidad";
            this.lb_cantidad.Size = new System.Drawing.Size(49, 13);
            this.lb_cantidad.TabIndex = 11;
            this.lb_cantidad.Text = "Cantidad";
            // 
            // cm_insumo
            // 
            this.cm_insumo.FormattingEnabled = true;
            this.cm_insumo.Location = new System.Drawing.Point(206, 161);
            this.cm_insumo.Name = "cm_insumo";
            this.cm_insumo.Size = new System.Drawing.Size(121, 21);
            this.cm_insumo.TabIndex = 12;
            this.cm_insumo.SelectionChangeCommitted += new System.EventHandler(this.cm_insumo_SelectedChangedCommited);
            // 
            // cm_unimed
            // 
            this.cm_unimed.FormattingEnabled = true;
            this.cm_unimed.Location = new System.Drawing.Point(349, 161);
            this.cm_unimed.Name = "cm_unimed";
            this.cm_unimed.Size = new System.Drawing.Size(121, 21);
            this.cm_unimed.TabIndex = 13;
            this.cm_unimed.SelectionChangeCommitted += new System.EventHandler(this.cm_unimed_SelectedChangedCommited);
            // 
            // tb_cantidad
            // 
            this.tb_cantidad.Location = new System.Drawing.Point(491, 161);
            this.tb_cantidad.Name = "tb_cantidad";
            this.tb_cantidad.Size = new System.Drawing.Size(100, 20);
            this.tb_cantidad.TabIndex = 0;
            this.tb_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cantidad_KeyPress);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(242, 418);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 15;
            this.tb_id.Visible = false;
            // 
            // FormIngReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_cantidad);
            this.Controls.Add(this.cm_unimed);
            this.Controls.Add(this.cm_insumo);
            this.Controls.Add(this.lb_cantidad);
            this.Controls.Add(this.lb_unimed);
            this.Controls.Add(this.lb_insumo);
            this.Controls.Add(this.tb_estado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.lb_producto);
            this.Controls.Add(this.cm_producto);
            this.Controls.Add(this.dg_mostrar);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_guardar);
            this.Name = "FormIngReceta";
            this.Text = "Ingreso Receta";
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.DataGridView dg_mostrar;
        private System.Windows.Forms.ComboBox cm_producto;
        private System.Windows.Forms.Label lb_producto;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_estado;
        private System.Windows.Forms.Label lb_insumo;
        private System.Windows.Forms.Label lb_unimed;
        private System.Windows.Forms.Label lb_cantidad;
        private System.Windows.Forms.ComboBox cm_insumo;
        private System.Windows.Forms.ComboBox cm_unimed;
        private System.Windows.Forms.TextBox tb_cantidad;
        private System.Windows.Forms.TextBox tb_id;
    }
}