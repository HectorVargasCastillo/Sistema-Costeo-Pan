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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cm_prodfinal = new System.Windows.Forms.ComboBox();
            this.tb_unidadmedida = new System.Windows.Forms.TextBox();
            this.tb_produccion = new System.Windows.Forms.TextBox();
            this.dg_reporte = new System.Windows.Forms.DataGridView();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_reporte)).BeginInit();
            this.SuspendLayout();
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
            this.label2.Location = new System.Drawing.Point(208, 65);
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
            this.cm_prodfinal.SelectedIndexChanged += new System.EventHandler(this.cm_prodfinal_SelectedIndexChanged);
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
            this.dg_reporte.Location = new System.Drawing.Point(59, 177);
            this.dg_reporte.Name = "dg_reporte";
            this.dg_reporte.Size = new System.Drawing.Size(567, 96);
            this.dg_reporte.TabIndex = 11;
            this.dg_reporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_reporte_CellContentClick);
            this.dg_reporte.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_reporte_CellContentDoubleClick);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_eliminar.Location = new System.Drawing.Point(407, 294);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(75, 23);
            this.bt_eliminar.TabIndex = 24;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = false;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_editar.Location = new System.Drawing.Point(299, 294);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(75, 23);
            this.bt_editar.TabIndex = 23;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = false;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(189, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(526, 297);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 25;
            this.tb_id.Visible = false;
            this.tb_id.TextChanged += new System.EventHandler(this.tb_id_TextChanged);
            // 
            // FormProDiariaPan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dg_reporte);
            this.Controls.Add(this.tb_produccion);
            this.Controls.Add(this.tb_unidadmedida);
            this.Controls.Add(this.cm_prodfinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProDiariaPan";
            this.Text = "FormProDiariaPan";
            this.Load += new System.EventHandler(this.FormProDiariaPan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_reporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cm_prodfinal;
        private System.Windows.Forms.TextBox tb_unidadmedida;
        private System.Windows.Forms.TextBox tb_produccion;
        private System.Windows.Forms.DataGridView dg_reporte;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_id;
    }
}