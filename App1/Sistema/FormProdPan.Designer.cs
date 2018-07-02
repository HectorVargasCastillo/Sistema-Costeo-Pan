namespace Sistema
{
    partial class FormProdPan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdPan));
            this.bt_guardar = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.cm_producto = new System.Windows.Forms.ComboBox();
            this.cm_unimed = new System.Windows.Forms.ComboBox();
            this.dg_mostrar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_produccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_produccion = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_guardar
            // 
            this.bt_guardar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_guardar.Location = new System.Drawing.Point(261, 362);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(75, 23);
            this.bt_guardar.TabIndex = 7;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_editar.Location = new System.Drawing.Point(385, 363);
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
            this.bt_eliminar.Location = new System.Drawing.Point(502, 363);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(75, 23);
            this.bt_eliminar.TabIndex = 2;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = false;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // cm_producto
            // 
            this.cm_producto.FormattingEnabled = true;
            this.cm_producto.Location = new System.Drawing.Point(206, 130);
            this.cm_producto.Name = "cm_producto";
            this.cm_producto.Size = new System.Drawing.Size(121, 21);
            this.cm_producto.TabIndex = 3;
            this.cm_producto.SelectionChangeCommitted += new System.EventHandler(this.cm_producto_SelectionChangeCommitted);
            // 
            // cm_unimed
            // 
            this.cm_unimed.FormattingEnabled = true;
            this.cm_unimed.Location = new System.Drawing.Point(361, 130);
            this.cm_unimed.Name = "cm_unimed";
            this.cm_unimed.Size = new System.Drawing.Size(121, 21);
            this.cm_unimed.TabIndex = 4;
            this.cm_unimed.SelectionChangeCommitted += new System.EventHandler(this.cm_unimed_SelecionChangeCommited);
            // 
            // dg_mostrar
            // 
            this.dg_mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_mostrar.Location = new System.Drawing.Point(107, 184);
            this.dg_mostrar.Name = "dg_mostrar";
            this.dg_mostrar.Size = new System.Drawing.Size(590, 150);
            this.dg_mostrar.TabIndex = 5;
            this.dg_mostrar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_mostrar_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Producto Final";
            // 
            // tb_produccion
            // 
            this.tb_produccion.Location = new System.Drawing.Point(510, 130);
            this.tb_produccion.Name = "tb_produccion";
            this.tb_produccion.Size = new System.Drawing.Size(100, 20);
            this.tb_produccion.TabIndex = 0;
            this.tb_produccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_produccion_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Unidad Medida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Produccion";
            // 
            // lb_produccion
            // 
            this.lb_produccion.AutoSize = true;
            this.lb_produccion.Location = new System.Drawing.Point(358, 44);
            this.lb_produccion.Name = "lb_produccion";
            this.lb_produccion.Size = new System.Drawing.Size(113, 13);
            this.lb_produccion.TabIndex = 10;
            this.lb_produccion.Text = "Produccion Diaria Pan";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(206, 408);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 11;
            this.tb_id.Visible = false;
            // 
            // FormProdPan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lb_produccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_produccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_mostrar);
            this.Controls.Add(this.cm_unimed);
            this.Controls.Add(this.cm_producto);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_guardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProdPan";
            this.Text = "Produccion Diaria de Pan";
            ((System.ComponentModel.ISupportInitialize)(this.dg_mostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.ComboBox cm_producto;
        private System.Windows.Forms.ComboBox cm_unimed;
        private System.Windows.Forms.DataGridView dg_mostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_produccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_produccion;
        private System.Windows.Forms.TextBox tb_id;
    }
}