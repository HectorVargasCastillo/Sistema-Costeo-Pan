namespace Sistema
{
    partial class FormProDiariaPan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cm_prodfinal = new System.Windows.Forms.ComboBox();
            this.tb_unidadmedida = new System.Windows.Forms.TextBox();
            this.tb_produccion = new System.Windows.Forms.TextBox();
            this.dg_reporte = new System.Windows.Forms.DataGridView();
            this.dg_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_unimedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_produccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_modificar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_eliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(474, 89);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(75, 23);
            this.bt_guardar.TabIndex = 0;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unidad de medida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Produccion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cm_prodfinal
            // 
            this.cm_prodfinal.FormattingEnabled = true;
            this.cm_prodfinal.Location = new System.Drawing.Point(59, 92);
            this.cm_prodfinal.Name = "cm_prodfinal";
            this.cm_prodfinal.Size = new System.Drawing.Size(95, 21);
            this.cm_prodfinal.TabIndex = 4;
            // 
            // tb_unidadmedida
            // 
            this.tb_unidadmedida.Location = new System.Drawing.Point(203, 92);
            this.tb_unidadmedida.Name = "tb_unidadmedida";
            this.tb_unidadmedida.Size = new System.Drawing.Size(100, 20);
            this.tb_unidadmedida.TabIndex = 5;
            // 
            // tb_produccion
            // 
            this.tb_produccion.Location = new System.Drawing.Point(347, 92);
            this.tb_produccion.Name = "tb_produccion";
            this.tb_produccion.Size = new System.Drawing.Size(100, 20);
            this.tb_produccion.TabIndex = 6;
            // 
            // dg_reporte
            // 
            this.dg_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_reporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_producto,
            this.dg_unimedida,
            this.dg_produccion,
            this.dg_fecha,
            this.dg_modificar,
            this.dg_eliminar});
            this.dg_reporte.Location = new System.Drawing.Point(59, 174);
            this.dg_reporte.Name = "dg_reporte";
            this.dg_reporte.Size = new System.Drawing.Size(644, 96);
            this.dg_reporte.TabIndex = 11;
            this.dg_reporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_reporte_CellContentClick);
            // 
            // dg_producto
            // 
            this.dg_producto.HeaderText = "Producto";
            this.dg_producto.Name = "dg_producto";
            // 
            // dg_unimedida
            // 
            this.dg_unimedida.HeaderText = "Unidad de medida";
            this.dg_unimedida.Name = "dg_unimedida";
            // 
            // dg_produccion
            // 
            this.dg_produccion.HeaderText = "Produccion";
            this.dg_produccion.Name = "dg_produccion";
            // 
            // dg_fecha
            // 
            this.dg_fecha.HeaderText = "Fecha";
            this.dg_fecha.Name = "dg_fecha";
            // 
            // dg_modificar
            // 
            this.dg_modificar.HeaderText = "Modificar";
            this.dg_modificar.Name = "dg_modificar";
            // 
            // dg_eliminar
            // 
            this.dg_eliminar.HeaderText = "Eliminar";
            this.dg_eliminar.Name = "dg_eliminar";
            // 
            // FormProDiariaPan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dg_reporte);
            this.Controls.Add(this.tb_produccion);
            this.Controls.Add(this.tb_unidadmedida);
            this.Controls.Add(this.cm_prodfinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_guardar);
            this.Name = "FormProDiariaPan";
            this.Text = "FormProDiariaPan";
            this.Load += new System.EventHandler(this.FormProDiariaPan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_reporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cm_prodfinal;
        private System.Windows.Forms.TextBox tb_unidadmedida;
        private System.Windows.Forms.TextBox tb_produccion;
        private System.Windows.Forms.DataGridView dg_reporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_unimedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_produccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_eliminar;
    }
}