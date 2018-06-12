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
            this.nombre = new System.Windows.Forms.Label();
            this.cmb_familia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(42, 38);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(44, 13);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "Nombre";
            // 
            // cmb_familia
            // 
            this.cmb_familia.FormattingEnabled = true;
            this.cmb_familia.Location = new System.Drawing.Point(120, 69);
            this.cmb_familia.Name = "cmb_familia";
            this.cmb_familia.Size = new System.Drawing.Size(121, 21);
            this.cmb_familia.TabIndex = 2;
            this.cmb_familia.SelectedIndexChanged += new System.EventHandler(this.cmb_familia_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Familia";
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_familia);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.bt_guardar);
            this.Name = "formNuevoLinea";
            this.Text = "formNuevoLinea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.ComboBox cmb_familia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nombre;
    }
}