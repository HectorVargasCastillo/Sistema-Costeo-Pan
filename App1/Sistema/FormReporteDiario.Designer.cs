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
            this.bt_mostrar = new System.Windows.Forms.Button();
            this.tp_inicio = new System.Windows.Forms.DateTimePicker();
            this.tp_fin = new System.Windows.Forms.DateTimePicker();
            this.dg_reporte = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_reporte)).BeginInit();
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
            // bt_mostrar
            // 
            this.bt_mostrar.Location = new System.Drawing.Point(297, 154);
            this.bt_mostrar.Name = "bt_mostrar";
            this.bt_mostrar.Size = new System.Drawing.Size(100, 23);
            this.bt_mostrar.TabIndex = 4;
            this.bt_mostrar.Text = "Mostrar Reporte";
            this.bt_mostrar.UseVisualStyleBackColor = true;
            this.bt_mostrar.Click += new System.EventHandler(this.bt_mostrar_Click);
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
            // dg_reporte
            // 
            this.dg_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_reporte.Location = new System.Drawing.Point(81, 214);
            this.dg_reporte.Name = "dg_reporte";
            this.dg_reporte.Size = new System.Drawing.Size(543, 150);
            this.dg_reporte.TabIndex = 7;
            this.dg_reporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormReporteDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.dg_reporte);
            this.Controls.Add(this.tp_fin);
            this.Controls.Add(this.tp_inicio);
            this.Controls.Add(this.bt_mostrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormReporteDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Diario";
            this.Load += new System.EventHandler(this.FormReporteDiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_reporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_mostrar;
        private System.Windows.Forms.DateTimePicker tp_inicio;
        private System.Windows.Forms.DateTimePicker tp_fin;
        private System.Windows.Forms.DataGridView dg_reporte;
    }
}