namespace Sistema
{
    partial class formNuevoLinea
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
            this.lb_nombre = new System.Windows.Forms.Label();
            this.cm_familia = new System.Windows.Forms.ComboBox();
            this.lb_familia = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(166, 106);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(75, 23);
            this.bt_guardar.TabIndex = 0;
            this.bt_guardar.Text = "Guardar Familia";
            this.bt_guardar.UseVisualStyleBackColor = true;
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(42, 38);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(44, 13);
            this.lb_nombre.TabIndex = 1;
            this.lb_nombre.Text = "Nombre";
            // 
            // cm_familia
            // 
            this.cm_familia.FormattingEnabled = true;
            this.cm_familia.Location = new System.Drawing.Point(120, 69);
            this.cm_familia.Name = "cm_familia";
            this.cm_familia.Size = new System.Drawing.Size(121, 21);
            this.cm_familia.TabIndex = 2;
            this.cm_familia.SelectedIndexChanged += new System.EventHandler(this.cmb_familia_SelectedIndexChanged);
            // 
            // lb_familia
            // 
            this.lb_familia.AutoSize = true;
            this.lb_familia.Location = new System.Drawing.Point(42, 69);
            this.lb_familia.Name = "lb_familia";
            this.lb_familia.Size = new System.Drawing.Size(39, 13);
            this.lb_familia.TabIndex = 3;
            this.lb_familia.Text = "Familia";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(120, 30);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(121, 20);
            this.tb_nombre.TabIndex = 4;
            // 
            // formNuevoLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 272);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.lb_familia);
            this.Controls.Add(this.cm_familia);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.bt_guardar);
            this.Name = "formNuevoLinea";
            this.Text = "formNuevoLinea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.ComboBox cm_familia;
        private System.Windows.Forms.Label lb_familia;
        private System.Windows.Forms.TextBox tb_nombre;
    }
}