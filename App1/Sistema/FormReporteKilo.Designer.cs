namespace Sistema
{
    partial class FormReporteKilo
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
            this.bt_mostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tp_inicio = new System.Windows.Forms.DateTimePicker();
            this.tp_fin = new System.Windows.Forms.DateTimePicker();
            this.dg_reporte = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_tipopan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_mostrar
            // 
            this.bt_mostrar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_mostrar.Location = new System.Drawing.Point(304, 256);
            this.bt_mostrar.Name = "bt_mostrar";
            this.bt_mostrar.Size = new System.Drawing.Size(97, 23);
            this.bt_mostrar.TabIndex = 3;
            this.bt_mostrar.Text = "Mostrar Reporte";
            this.bt_mostrar.UseVisualStyleBackColor = false;
            this.bt_mostrar.Click += new System.EventHandler(this.bt_mostrar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(150, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha inicial";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha final";
            // 
            // tp_inicio
            // 
            this.tp_inicio.Location = new System.Drawing.Point(264, 105);
            this.tp_inicio.Name = "tp_inicio";
            this.tp_inicio.Size = new System.Drawing.Size(200, 20);
            this.tp_inicio.TabIndex = 0;
            // 
            // tp_fin
            // 
            this.tp_fin.Location = new System.Drawing.Point(264, 152);
            this.tp_fin.Name = "tp_fin";
            this.tp_fin.Size = new System.Drawing.Size(200, 20);
            this.tp_fin.TabIndex = 1;
            // 
            // dg_reporte
            // 
            this.dg_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_reporte.Location = new System.Drawing.Point(79, 315);
            this.dg_reporte.Name = "dg_reporte";
            this.dg_reporte.Size = new System.Drawing.Size(543, 150);
            this.dg_reporte.TabIndex = 5;
            this.dg_reporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_reporte_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo pan";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cb_tipopan
            // 
            this.cb_tipopan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipopan.FormattingEnabled = true;
            this.cb_tipopan.Location = new System.Drawing.Point(264, 194);
            this.cb_tipopan.Name = "cb_tipopan";
            this.cb_tipopan.Size = new System.Drawing.Size(200, 21);
            this.cb_tipopan.TabIndex = 2;
            this.cb_tipopan.SelectedIndexChanged += new System.EventHandler(this.cb_tipopan_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Reporte por Kilo  (Kg.)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FormReporteKilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 508);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_tipopan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dg_reporte);
            this.Controls.Add(this.tp_fin);
            this.Controls.Add(this.tp_inicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_mostrar);
            this.Name = "FormReporteKilo";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte por kilo";
            this.Load += new System.EventHandler(this.FormReporteKilo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_reporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_mostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker tp_inicio;
        private System.Windows.Forms.DateTimePicker tp_fin;
        private System.Windows.Forms.DataGridView dg_reporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_tipopan;
        private System.Windows.Forms.Label label4;
    }
}