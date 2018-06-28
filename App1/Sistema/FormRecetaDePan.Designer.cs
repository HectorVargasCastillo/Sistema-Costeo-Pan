namespace Sistema
{
    partial class FormRecetaDePan
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
            this.lb_prodfinal = new System.Windows.Forms.Label();
            this.lb_estado = new System.Windows.Forms.Label();
            this.lb_inginsumos = new System.Windows.Forms.Label();
            this.lb_unimedida = new System.Windows.Forms.Label();
            this.lb_cantidad = new System.Windows.Forms.Label();
            this.cm_prodfinal = new System.Windows.Forms.ComboBox();
            this.cm_inginsumos = new System.Windows.Forms.ComboBox();
            this.tb_estado = new System.Windows.Forms.TextBox();
            this.tb_cantidad = new System.Windows.Forms.TextBox();
            this.dg_reporte = new System.Windows.Forms.DataGridView();
            this.dg_insumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_unidadmedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_prodfinal
            // 
            this.lb_prodfinal.AutoSize = true;
            this.lb_prodfinal.Location = new System.Drawing.Point(64, 60);
            this.lb_prodfinal.Name = "lb_prodfinal";
            this.lb_prodfinal.Size = new System.Drawing.Size(72, 13);
            this.lb_prodfinal.TabIndex = 0;
            this.lb_prodfinal.Text = "Producto final";
            this.lb_prodfinal.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_estado
            // 
            this.lb_estado.AutoSize = true;
            this.lb_estado.Location = new System.Drawing.Point(64, 113);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(40, 13);
            this.lb_estado.TabIndex = 1;
            this.lb_estado.Text = "Estado";
            // 
            // lb_inginsumos
            // 
            this.lb_inginsumos.AutoSize = true;
            this.lb_inginsumos.Location = new System.Drawing.Point(64, 159);
            this.lb_inginsumos.Name = "lb_inginsumos";
            this.lb_inginsumos.Size = new System.Drawing.Size(98, 13);
            this.lb_inginsumos.TabIndex = 2;
            this.lb_inginsumos.Text = "Ingreso de insumos";
            this.lb_inginsumos.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb_unimedida
            // 
            this.lb_unimedida.AutoSize = true;
            this.lb_unimedida.Location = new System.Drawing.Point(259, 159);
            this.lb_unimedida.Name = "lb_unimedida";
            this.lb_unimedida.Size = new System.Drawing.Size(93, 13);
            this.lb_unimedida.TabIndex = 3;
            this.lb_unimedida.Text = "Unidad de medida";
            this.lb_unimedida.Click += new System.EventHandler(this.label4_Click);
            // 
            // lb_cantidad
            // 
            this.lb_cantidad.AutoSize = true;
            this.lb_cantidad.Location = new System.Drawing.Point(445, 159);
            this.lb_cantidad.Name = "lb_cantidad";
            this.lb_cantidad.Size = new System.Drawing.Size(49, 13);
            this.lb_cantidad.TabIndex = 4;
            this.lb_cantidad.Text = "Cantidad";
            // 
            // cm_prodfinal
            // 
            this.cm_prodfinal.FormattingEnabled = true;
            this.cm_prodfinal.Location = new System.Drawing.Point(151, 51);
            this.cm_prodfinal.Name = "cm_prodfinal";
            this.cm_prodfinal.Size = new System.Drawing.Size(121, 21);
            this.cm_prodfinal.TabIndex = 5;
            this.cm_prodfinal.SelectedIndexChanged += new System.EventHandler(this.cm_prodfinal_SelectedIndexChanged);
            // 
            // cm_inginsumos
            // 
            this.cm_inginsumos.FormattingEnabled = true;
            this.cm_inginsumos.Location = new System.Drawing.Point(67, 186);
            this.cm_inginsumos.Name = "cm_inginsumos";
            this.cm_inginsumos.Size = new System.Drawing.Size(121, 21);
            this.cm_inginsumos.TabIndex = 6;
            this.cm_inginsumos.SelectedIndexChanged += new System.EventHandler(this.cm_inginsumos_SelectedIndexChanged);
            // 
            // tb_estado
            // 
            this.tb_estado.Location = new System.Drawing.Point(151, 113);
            this.tb_estado.Name = "tb_estado";
            this.tb_estado.Size = new System.Drawing.Size(100, 20);
            this.tb_estado.TabIndex = 7;
            // 
            // tb_cantidad
            // 
            this.tb_cantidad.Location = new System.Drawing.Point(430, 187);
            this.tb_cantidad.Name = "tb_cantidad";
            this.tb_cantidad.Size = new System.Drawing.Size(100, 20);
            this.tb_cantidad.TabIndex = 8;
            // 
            // dg_reporte
            // 
            this.dg_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_reporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_insumos,
            this.dg_unidadmedida,
            this.dg_cantidad});
            this.dg_reporte.Location = new System.Drawing.Point(67, 237);
            this.dg_reporte.Name = "dg_reporte";
            this.dg_reporte.Size = new System.Drawing.Size(343, 59);
            this.dg_reporte.TabIndex = 10;
            this.dg_reporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_reporte_CellContentClick);
            // 
            // dg_insumos
            // 
            this.dg_insumos.HeaderText = "Insumos";
            this.dg_insumos.Name = "dg_insumos";
            // 
            // dg_unidadmedida
            // 
            this.dg_unidadmedida.HeaderText = "Unidad de medida";
            this.dg_unidadmedida.Name = "dg_unidadmedida";
            // 
            // dg_cantidad
            // 
            this.dg_cantidad.HeaderText = "Cantidad";
            this.dg_cantidad.Name = "dg_cantidad";
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_eliminar.Location = new System.Drawing.Point(285, 406);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(75, 23);
            this.bt_eliminar.TabIndex = 21;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = false;
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_editar.Location = new System.Drawing.Point(177, 406);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(75, 23);
            this.bt_editar.TabIndex = 20;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(67, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(394, 409);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 22;
            this.tb_id.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(243, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(117, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // FormRecetaDePan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dg_reporte);
            this.Controls.Add(this.tb_cantidad);
            this.Controls.Add(this.tb_estado);
            this.Controls.Add(this.cm_inginsumos);
            this.Controls.Add(this.cm_prodfinal);
            this.Controls.Add(this.lb_cantidad);
            this.Controls.Add(this.lb_unimedida);
            this.Controls.Add(this.lb_inginsumos);
            this.Controls.Add(this.lb_estado);
            this.Controls.Add(this.lb_prodfinal);
            this.Name = "FormRecetaDePan";
            this.Text = "FormRecetaDePan";
            this.Load += new System.EventHandler(this.FormRecetaDePan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_reporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_prodfinal;
        private System.Windows.Forms.Label lb_estado;
        private System.Windows.Forms.Label lb_inginsumos;
        private System.Windows.Forms.Label lb_unimedida;
        private System.Windows.Forms.Label lb_cantidad;
        private System.Windows.Forms.ComboBox cm_prodfinal;
        private System.Windows.Forms.ComboBox cm_inginsumos;
        private System.Windows.Forms.TextBox tb_estado;
        private System.Windows.Forms.TextBox tb_cantidad;
        private System.Windows.Forms.DataGridView dg_reporte;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_insumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_unidadmedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_cantidad;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}