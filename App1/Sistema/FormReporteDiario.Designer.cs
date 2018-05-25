namespace Sistema
{
    partial class FormReporteDiario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.tp_inicio = new System.Windows.Forms.DateTimePicker();
            this.tp_fin = new System.Windows.Forms.DateTimePicker();
            this.dgv_reporte = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentabilidad_porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentabilidad_moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha final";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(297, 154);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(100, 23);
            this.btn_mostrar.TabIndex = 4;
            this.btn_mostrar.Text = "Mostrar Reporte";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            // 
            // tp_inicio
            // 
            this.tp_inicio.Location = new System.Drawing.Point(260, 54);
            this.tp_inicio.Name = "tp_inicio";
            this.tp_inicio.Size = new System.Drawing.Size(200, 20);
            this.tp_inicio.TabIndex = 5;
            // 
            // tp_fin
            // 
            this.tp_fin.Location = new System.Drawing.Point(260, 92);
            this.tp_fin.Name = "tp_fin";
            this.tp_fin.Size = new System.Drawing.Size(200, 20);
            this.tp_fin.TabIndex = 6;
            // 
            // dgv_reporte
            // 
            this.dgv_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.precio_costo,
            this.precio_venta,
            this.rentabilidad_porcentaje,
            this.rentabilidad_moneda});
            this.dgv_reporte.Location = new System.Drawing.Point(113, 214);
            this.dgv_reporte.Name = "dgv_reporte";
            this.dgv_reporte.Size = new System.Drawing.Size(543, 150);
            this.dgv_reporte.TabIndex = 7;
            this.dgv_reporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // precio_costo
            // 
            this.precio_costo.HeaderText = "Precio costo";
            this.precio_costo.Name = "precio_costo";
            // 
            // precio_venta
            // 
            this.precio_venta.HeaderText = "Precio venta";
            this.precio_venta.Name = "precio_venta";
            // 
            // rentabilidad_porcentaje
            // 
            this.rentabilidad_porcentaje.HeaderText = "Rentabilidad %";
            this.rentabilidad_porcentaje.Name = "rentabilidad_porcentaje";
            // 
            // rentabilidad_moneda
            // 
            this.rentabilidad_moneda.HeaderText = "Rentabilidad $";
            this.rentabilidad_moneda.Name = "rentabilidad_moneda";
            // 
            // FormReporteDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_reporte);
            this.Controls.Add(this.tp_fin);
            this.Controls.Add(this.tp_inicio);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormReporteDiario";
            this.Text = "Reporte Diario";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.DateTimePicker tp_inicio;
        private System.Windows.Forms.DateTimePicker tp_fin;
        private System.Windows.Forms.DataGridView dgv_reporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentabilidad_porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentabilidad_moneda;
    }
}