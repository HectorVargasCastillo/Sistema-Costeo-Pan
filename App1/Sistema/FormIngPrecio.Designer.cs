namespace Sistema
{
    partial class FormIngPrecio
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
            this.lb_nombre = new System.Windows.Forms.Label();
            this.lb_unidad = new System.Windows.Forms.Label();
            this.lb_marca = new System.Windows.Forms.Label();
            this.lb_formato = new System.Windows.Forms.Label();
            this.lb_linea = new System.Windows.Forms.Label();
            this.lb_familia = new System.Windows.Forms.Label();
            this.lb_nuevo = new System.Windows.Forms.Label();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_unidad = new System.Windows.Forms.TextBox();
            this.tb_marca = new System.Windows.Forms.TextBox();
            this.tb_formato = new System.Windows.Forms.TextBox();
            this.tb_linea = new System.Windows.Forms.TextBox();
            this.tb_familia = new System.Windows.Forms.TextBox();
            this.tb_nuevo = new System.Windows.Forms.TextBox();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.dg_mostrar = new System.Windows.Forms.DataGridView();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_codigo
            // 
            this.lb_codigo.AutoSize = true;
            this.lb_codigo.Location = new System.Drawing.Point(175, 61);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(83, 13);
            this.lb_codigo.TabIndex = 0;
            this.lb_codigo.Text = "Codigo de Barra";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(175, 90);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(44, 13);
            this.lb_nombre.TabIndex = 1;
            this.lb_nombre.Text = "Nombre";
            // 
            // lb_unidad
            // 
            this.lb_unidad.AutoSize = true;
            this.lb_unidad.Location = new System.Drawing.Point(174, 120);
            this.lb_unidad.Name = "lb_unidad";
            this.lb_unidad.Size = new System.Drawing.Size(79, 13);
            this.lb_unidad.TabIndex = 2;
            this.lb_unidad.Text = "Unidad Medida";
            // 
            // lb_marca
            // 
            this.lb_marca.AutoSize = true;
            this.lb_marca.Location = new System.Drawing.Point(174, 149);
            this.lb_marca.Name = "lb_marca";
            this.lb_marca.Size = new System.Drawing.Size(37, 13);
            this.lb_marca.TabIndex = 3;
            this.lb_marca.Text = "Marca";
            // 
            // lb_formato
            // 
            this.lb_formato.AutoSize = true;
            this.lb_formato.Location = new System.Drawing.Point(174, 177);
            this.lb_formato.Name = "lb_formato";
            this.lb_formato.Size = new System.Drawing.Size(45, 13);
            this.lb_formato.TabIndex = 4;
            this.lb_formato.Text = "Formato";
            // 
            // lb_linea
            // 
            this.lb_linea.AutoSize = true;
            this.lb_linea.Location = new System.Drawing.Point(174, 205);
            this.lb_linea.Name = "lb_linea";
            this.lb_linea.Size = new System.Drawing.Size(33, 13);
            this.lb_linea.TabIndex = 5;
            this.lb_linea.Text = "Linea";
            // 
            // lb_familia
            // 
            this.lb_familia.AutoSize = true;
            this.lb_familia.Location = new System.Drawing.Point(174, 239);
            this.lb_familia.Name = "lb_familia";
            this.lb_familia.Size = new System.Drawing.Size(39, 13);
            this.lb_familia.TabIndex = 6;
            this.lb_familia.Text = "Familia";
            // 
            // lb_nuevo
            // 
            this.lb_nuevo.AutoSize = true;
            this.lb_nuevo.Location = new System.Drawing.Point(174, 272);
            this.lb_nuevo.Name = "lb_nuevo";
            this.lb_nuevo.Size = new System.Drawing.Size(72, 13);
            this.lb_nuevo.TabIndex = 7;
            this.lb_nuevo.Text = "Nuevo Precio";
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Location = new System.Drawing.Point(297, 25);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(126, 13);
            this.lb_titulo.TabIndex = 8;
            this.lb_titulo.Text = "Ingreso Precios de Venta";
            // 
            // tb_codigo
            // 
            this.tb_codigo.Location = new System.Drawing.Point(300, 53);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(100, 20);
            this.tb_codigo.TabIndex = 9;
            this.tb_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_codigo_KeyPress);
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(300, 90);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.ReadOnly = true;
            this.tb_nombre.Size = new System.Drawing.Size(266, 20);
            this.tb_nombre.TabIndex = 10;
            // 
            // tb_unidad
            // 
            this.tb_unidad.Location = new System.Drawing.Point(300, 118);
            this.tb_unidad.Name = "tb_unidad";
            this.tb_unidad.ReadOnly = true;
            this.tb_unidad.Size = new System.Drawing.Size(48, 20);
            this.tb_unidad.TabIndex = 11;
            // 
            // tb_marca
            // 
            this.tb_marca.Location = new System.Drawing.Point(300, 145);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.ReadOnly = true;
            this.tb_marca.Size = new System.Drawing.Size(75, 20);
            this.tb_marca.TabIndex = 12;
            // 
            // tb_formato
            // 
            this.tb_formato.Location = new System.Drawing.Point(300, 172);
            this.tb_formato.Name = "tb_formato";
            this.tb_formato.ReadOnly = true;
            this.tb_formato.Size = new System.Drawing.Size(48, 20);
            this.tb_formato.TabIndex = 13;
            // 
            // tb_linea
            // 
            this.tb_linea.Location = new System.Drawing.Point(300, 201);
            this.tb_linea.Name = "tb_linea";
            this.tb_linea.ReadOnly = true;
            this.tb_linea.Size = new System.Drawing.Size(75, 20);
            this.tb_linea.TabIndex = 14;
            // 
            // tb_familia
            // 
            this.tb_familia.Location = new System.Drawing.Point(300, 232);
            this.tb_familia.Name = "tb_familia";
            this.tb_familia.ReadOnly = true;
            this.tb_familia.Size = new System.Drawing.Size(75, 20);
            this.tb_familia.TabIndex = 15;
            // 
            // tb_nuevo
            // 
            this.tb_nuevo.Location = new System.Drawing.Point(300, 265);
            this.tb_nuevo.Name = "tb_nuevo";
            this.tb_nuevo.Size = new System.Drawing.Size(100, 20);
            this.tb_nuevo.TabIndex = 16;
            this.tb_nuevo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nuevo_KeyPress);
            // 
            // bt_buscar
            // 
            this.bt_buscar.Location = new System.Drawing.Point(491, 50);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(75, 23);
            this.bt_buscar.TabIndex = 17;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // bt_guardar
            // 
            this.bt_guardar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_guardar.Location = new System.Drawing.Point(197, 467);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(75, 23);
            this.bt_guardar.TabIndex = 18;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // dg_mostrar
            // 
            this.dg_mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_mostrar.Location = new System.Drawing.Point(140, 312);
            this.dg_mostrar.Name = "dg_mostrar";
            this.dg_mostrar.Size = new System.Drawing.Size(472, 139);
            this.dg_mostrar.TabIndex = 19;
            this.dg_mostrar.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_mostrar_CellDoubleClick);
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_editar.Location = new System.Drawing.Point(348, 467);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(75, 23);
            this.bt_editar.TabIndex = 20;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = false;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_eliminar.Location = new System.Drawing.Point(491, 467);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(75, 23);
            this.bt_eliminar.TabIndex = 21;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = false;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(27, 468);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 22;
            this.tb_id.Visible = false;
            // 
            // FormIngPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.dg_mostrar);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.tb_nuevo);
            this.Controls.Add(this.tb_familia);
            this.Controls.Add(this.tb_linea);
            this.Controls.Add(this.tb_formato);
            this.Controls.Add(this.tb_marca);
            this.Controls.Add(this.tb_unidad);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.lb_nuevo);
            this.Controls.Add(this.lb_familia);
            this.Controls.Add(this.lb_linea);
            this.Controls.Add(this.lb_formato);
            this.Controls.Add(this.lb_marca);
            this.Controls.Add(this.lb_unidad);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.lb_codigo);
            this.Name = "FormIngPrecio";
            this.Text = "Ingreso Precio Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_codigo;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label lb_unidad;
        private System.Windows.Forms.Label lb_marca;
        private System.Windows.Forms.Label lb_formato;
        private System.Windows.Forms.Label lb_linea;
        private System.Windows.Forms.Label lb_familia;
        private System.Windows.Forms.Label lb_nuevo;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_unidad;
        private System.Windows.Forms.TextBox tb_marca;
        private System.Windows.Forms.TextBox tb_formato;
        private System.Windows.Forms.TextBox tb_linea;
        private System.Windows.Forms.TextBox tb_familia;
        private System.Windows.Forms.TextBox tb_nuevo;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.DataGridView dg_mostrar;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.TextBox tb_id;
    }
}