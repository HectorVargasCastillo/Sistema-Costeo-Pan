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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistroProducto));
            this.lb_codigobarra = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.lb_unidadmedida = new System.Windows.Forms.Label();
            this.lb_marca = new System.Windows.Forms.Label();
            this.lb_formato = new System.Windows.Forms.Label();
            this.lb_familia = new System.Windows.Forms.Label();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.cm_unidadmedida = new System.Windows.Forms.ComboBox();
            this.cm_familia = new System.Windows.Forms.ComboBox();
            this.tb_codigobarra = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_marca = new System.Windows.Forms.TextBox();
            this.tb_formato = new System.Windows.Forms.TextBox();
            this.dg_producto = new System.Windows.Forms.DataGridView();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.lb_ingresopro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_producto)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_codigobarra
            // 
            this.lb_codigobarra.AutoSize = true;
            this.lb_codigobarra.Location = new System.Drawing.Point(135, 69);
            this.lb_codigobarra.Name = "lb_codigobarra";
            this.lb_codigobarra.Size = new System.Drawing.Size(86, 13);
            this.lb_codigobarra.TabIndex = 0;
            this.lb_codigobarra.Text = "Codigo de  Barra";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(135, 109);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(44, 13);
            this.lb_nombre.TabIndex = 1;
            this.lb_nombre.Text = "Nombre";
            // 
            // lb_unidadmedida
            // 
            this.lb_unidadmedida.AutoSize = true;
            this.lb_unidadmedida.Location = new System.Drawing.Point(136, 149);
            this.lb_unidadmedida.Name = "lb_unidadmedida";
            this.lb_unidadmedida.Size = new System.Drawing.Size(93, 13);
            this.lb_unidadmedida.TabIndex = 2;
            this.lb_unidadmedida.Text = "Unidad de medida";
            // 
            // lb_marca
            // 
            this.lb_marca.AutoSize = true;
            this.lb_marca.Location = new System.Drawing.Point(423, 152);
            this.lb_marca.Name = "lb_marca";
            this.lb_marca.Size = new System.Drawing.Size(37, 13);
            this.lb_marca.TabIndex = 3;
            this.lb_marca.Text = "Marca";
            // 
            // lb_formato
            // 
            this.lb_formato.AutoSize = true;
            this.lb_formato.Location = new System.Drawing.Point(136, 202);
            this.lb_formato.Name = "lb_formato";
            this.lb_formato.Size = new System.Drawing.Size(45, 13);
            this.lb_formato.TabIndex = 4;
            this.lb_formato.Text = "Formato";
            // 
            // lb_familia
            // 
            this.lb_familia.AutoSize = true;
            this.lb_familia.Location = new System.Drawing.Point(423, 202);
            this.lb_familia.Name = "lb_familia";
            this.lb_familia.Size = new System.Drawing.Size(39, 13);
            this.lb_familia.TabIndex = 6;
            this.lb_familia.Text = "Familia";
            // 
            // bt_guardar
            // 
            this.bt_guardar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_guardar.Location = new System.Drawing.Point(228, 394);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(75, 23);
            this.bt_guardar.TabIndex = 7;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cm_unidadmedida
            // 
            this.cm_unidadmedida.FormattingEnabled = true;
            this.cm_unidadmedida.Location = new System.Drawing.Point(255, 146);
            this.cm_unidadmedida.Name = "cm_unidadmedida";
            this.cm_unidadmedida.Size = new System.Drawing.Size(100, 21);
            this.cm_unidadmedida.TabIndex = 8;
            this.cm_unidadmedida.SelectedIndexChanged += new System.EventHandler(this.cm_unidadmedida_SelectedIndexChanged);
            // 
            // cm_familia
            // 
            this.cm_familia.FormattingEnabled = true;
            this.cm_familia.Location = new System.Drawing.Point(483, 199);
            this.cm_familia.Name = "cm_familia";
            this.cm_familia.Size = new System.Drawing.Size(145, 21);
            this.cm_familia.TabIndex = 10;
            this.cm_familia.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // tb_codigobarra
            // 
            this.tb_codigobarra.Location = new System.Drawing.Point(255, 66);
            this.tb_codigobarra.Name = "tb_codigobarra";
            this.tb_codigobarra.Size = new System.Drawing.Size(100, 20);
            this.tb_codigobarra.TabIndex = 11;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(255, 102);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(243, 20);
            this.tb_nombre.TabIndex = 12;
            this.tb_nombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb_marca
            // 
            this.tb_marca.Location = new System.Drawing.Point(483, 147);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(143, 20);
            this.tb_marca.TabIndex = 13;
            this.tb_marca.TextChanged += new System.EventHandler(this.tb_marca_TextChanged);
            // 
            // tb_formato
            // 
            this.tb_formato.Location = new System.Drawing.Point(255, 199);
            this.tb_formato.Name = "tb_formato";
            this.tb_formato.Size = new System.Drawing.Size(143, 20);
            this.tb_formato.TabIndex = 14;
            this.tb_formato.TextChanged += new System.EventHandler(this.tb_formato_TextChanged);
            // 
            // dg_producto
            // 
            this.dg_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_producto.Location = new System.Drawing.Point(50, 238);
            this.dg_producto.Name = "dg_producto";
            this.dg_producto.Size = new System.Drawing.Size(643, 150);
            this.dg_producto.TabIndex = 15;
            this.dg_producto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_producto_CellContentClick);
            this.dg_producto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_producto_CellDoubleClick);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(349, 423);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 22;
            this.tb_id.Visible = false;
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_eliminar.Location = new System.Drawing.Point(440, 394);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(75, 23);
            this.bt_eliminar.TabIndex = 21;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = false;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_editar.Location = new System.Drawing.Point(332, 394);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(75, 23);
            this.bt_editar.TabIndex = 20;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = false;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // lb_ingresopro
            // 
            this.lb_ingresopro.AutoSize = true;
            this.lb_ingresopro.Location = new System.Drawing.Point(255, 20);
            this.lb_ingresopro.Name = "lb_ingresopro";
            this.lb_ingresopro.Size = new System.Drawing.Size(93, 13);
            this.lb_ingresopro.TabIndex = 23;
            this.lb_ingresopro.Text = "Ingreso Productos";
            // 
            // FormRegistroProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_ingresopro);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.dg_producto);
            this.Controls.Add(this.tb_formato);
            this.Controls.Add(this.tb_marca);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.tb_codigobarra);
            this.Controls.Add(this.cm_familia);
            this.Controls.Add(this.cm_unidadmedida);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.lb_familia);
            this.Controls.Add(this.lb_formato);
            this.Controls.Add(this.lb_marca);
            this.Controls.Add(this.lb_unidadmedida);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.lb_codigobarra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistroProducto";
            this.Text = "Ingreso Producto";
            this.Load += new System.EventHandler(this.FormRegistroProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_producto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_codigobarra;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label lb_unidadmedida;
        private System.Windows.Forms.Label lb_marca;
        private System.Windows.Forms.Label lb_formato;
        private System.Windows.Forms.Label lb_familia;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.ComboBox cm_unidadmedida;
        private System.Windows.Forms.ComboBox cm_familia;
        private System.Windows.Forms.TextBox tb_codigobarra;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_marca;
        private System.Windows.Forms.TextBox tb_formato;
        private System.Windows.Forms.DataGridView dg_producto;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Label lb_ingresopro;
    }
}