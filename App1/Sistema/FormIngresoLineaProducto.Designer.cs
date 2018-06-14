namespace Sistema
{
    partial class FormIngresoLineaProducto
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
            this.lb_descripcionlinea = new System.Windows.Forms.Label();
            this.tb_descripcionlinea = new System.Windows.Forms.TextBox();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_descripcionlinea
            // 
            this.lb_descripcionlinea.AutoSize = true;
            this.lb_descripcionlinea.Location = new System.Drawing.Point(116, 137);
            this.lb_descripcionlinea.Name = "lb_descripcionlinea";
            this.lb_descripcionlinea.Size = new System.Drawing.Size(92, 13);
            this.lb_descripcionlinea.TabIndex = 0;
            this.lb_descripcionlinea.Text = "Descripcion Linea";
            // 
            // tb_descripcionlinea
            // 
            this.tb_descripcionlinea.Location = new System.Drawing.Point(214, 134);
            this.tb_descripcionlinea.Name = "tb_descripcionlinea";
            this.tb_descripcionlinea.Size = new System.Drawing.Size(243, 20);
            this.tb_descripcionlinea.TabIndex = 13;
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(326, 171);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(130, 24);
            this.bt_guardar.TabIndex = 14;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormIngresoLineaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.tb_descripcionlinea);
            this.Controls.Add(this.lb_descripcionlinea);
            this.Name = "FormIngresoLineaProducto";
            this.Text = "FormIngresoLineaProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_descripcionlinea;
        private System.Windows.Forms.TextBox tb_descripcionlinea;
        private System.Windows.Forms.Button bt_guardar;
    }
}