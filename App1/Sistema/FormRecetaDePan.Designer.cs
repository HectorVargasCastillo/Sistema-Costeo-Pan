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
            this.tb_unimedida = new System.Windows.Forms.TextBox();
            this.dg_reporte = new System.Windows.Forms.DataGridView();
            this.dg_insumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_unidadmedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_grabar = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
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
            // tb_unimedida
            // 
            this.tb_unimedida.Location = new System.Drawing.Point(262, 187);
            this.tb_unimedida.Name = "tb_unimedida";
            this.tb_unimedida.Size = new System.Drawing.Size(100, 20);
            this.tb_unimedida.TabIndex = 9;
            this.tb_unimedida.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
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
            this.dg_reporte.Size = new System.Drawing.Size(543, 150);
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
            // bt_grabar
            // 
            this.bt_grabar.Location = new System.Drawing.Point(566, 183);
            this.bt_grabar.Name = "bt_grabar";
            this.bt_grabar.Size = new System.Drawing.Size(75, 23);
            this.bt_grabar.TabIndex = 11;
            this.bt_grabar.Text = "Grabar";
            this.bt_grabar.UseVisualStyleBackColor = true;
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(535, 406);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(75, 23);
            this.bt_guardar.TabIndex = 12;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.UseVisualStyleBackColor = true;
            // 
            // FormRecetaDePan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.bt_grabar);
            this.Controls.Add(this.dg_reporte);
            this.Controls.Add(this.tb_unimedida);
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
        private System.Windows.Forms.TextBox tb_unimedida;
        private System.Windows.Forms.DataGridView dg_reporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_insumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_unidadmedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_cantidad;
        private System.Windows.Forms.Button bt_grabar;
        private System.Windows.Forms.Button bt_guardar;
    }
}