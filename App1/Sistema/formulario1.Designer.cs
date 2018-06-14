namespace Sistema
{
    partial class formulario1
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
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.cmb_unidad_medida = new System.Windows.Forms.ComboBox();
            this.bt_cargar_combo = new System.Windows.Forms.Button();
            this.bt_cargar_editar = new System.Windows.Forms.Button();
            this.tb_edit_nombre = new System.Windows.Forms.TextBox();
            this.bt_guardar_editar = new System.Windows.Forms.Button();
            this.tb_edit_id = new System.Windows.Forms.TextBox();
            this.gv_todo = new System.Windows.Forms.DataGridView();
            this.bt_cargar_gv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_todo)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(333, 46);
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
            this.label1.Location = new System.Drawing.Point(176, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripcion";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(279, 125);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(190, 20);
            this.tb_nombre.TabIndex = 2;
            // 
            // cmb_unidad_medida
            // 
            this.cmb_unidad_medida.FormattingEnabled = true;
            this.cmb_unidad_medida.Location = new System.Drawing.Point(147, 114);
            this.cmb_unidad_medida.Name = "cmb_unidad_medida";
            this.cmb_unidad_medida.Size = new System.Drawing.Size(121, 21);
            this.cmb_unidad_medida.TabIndex = 3;
            // 
            // bt_cargar_combo
            // 
            this.bt_cargar_combo.Location = new System.Drawing.Point(31, 114);
            this.bt_cargar_combo.Name = "bt_cargar_combo";
            this.bt_cargar_combo.Size = new System.Drawing.Size(91, 23);
            this.bt_cargar_combo.TabIndex = 4;
            this.bt_cargar_combo.Text = "Cargar Combo";
            this.bt_cargar_combo.UseVisualStyleBackColor = true;
            this.bt_cargar_combo.Click += new System.EventHandler(this.bt_cargar_combo_Click);
            // 
            // bt_cargar_editar
            // 
            this.bt_cargar_editar.Location = new System.Drawing.Point(302, 112);
            this.bt_cargar_editar.Name = "bt_cargar_editar";
            this.bt_cargar_editar.Size = new System.Drawing.Size(75, 23);
            this.bt_cargar_editar.TabIndex = 5;
            this.bt_cargar_editar.Text = "Editar";
            this.bt_cargar_editar.UseVisualStyleBackColor = true;
            this.bt_cargar_editar.Click += new System.EventHandler(this.bt_cargar_editar_Click);
            // 
            // tb_edit_nombre
            // 
            this.tb_edit_nombre.Location = new System.Drawing.Point(464, 112);
            this.tb_edit_nombre.Name = "tb_edit_nombre";
            this.tb_edit_nombre.Size = new System.Drawing.Size(107, 20);
            this.tb_edit_nombre.TabIndex = 6;
            // 
            // bt_guardar_editar
            // 
            this.bt_guardar_editar.Location = new System.Drawing.Point(598, 112);
            this.bt_guardar_editar.Name = "bt_guardar_editar";
            this.bt_guardar_editar.Size = new System.Drawing.Size(117, 23);
            this.bt_guardar_editar.TabIndex = 7;
            this.bt_guardar_editar.Text = "Guardar Editar";
            this.bt_guardar_editar.UseVisualStyleBackColor = true;
            this.bt_guardar_editar.Click += new System.EventHandler(this.bt_guardar_editar_Click);
            // 
            // tb_edit_id
            // 
            this.tb_edit_id.Location = new System.Drawing.Point(396, 112);
            this.tb_edit_id.Name = "tb_edit_id";
            this.tb_edit_id.ReadOnly = true;
            this.tb_edit_id.Size = new System.Drawing.Size(49, 20);
            this.tb_edit_id.TabIndex = 8;
            // 
            // gv_todo
            // 
            this.gv_todo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_todo.Location = new System.Drawing.Point(52, 232);
            this.gv_todo.Name = "gv_todo";
            this.gv_todo.Size = new System.Drawing.Size(240, 150);
            this.gv_todo.TabIndex = 9;
            this.gv_todo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_todo_CellContentClick);
            // 
            // bt_cargar_gv
            // 
            this.bt_cargar_gv.Location = new System.Drawing.Point(52, 200);
            this.bt_cargar_gv.Name = "bt_cargar_gv";
            this.bt_cargar_gv.Size = new System.Drawing.Size(75, 23);
            this.bt_cargar_gv.TabIndex = 10;
            this.bt_cargar_gv.Text = "Cargar GridView";
            this.bt_cargar_gv.UseVisualStyleBackColor = true;
            this.bt_cargar_gv.Click += new System.EventHandler(this.bt_cargar_gv_Click);
            // 
            // formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_cargar_gv);
            this.Controls.Add(this.gv_todo);
            this.Controls.Add(this.tb_edit_id);
            this.Controls.Add(this.bt_guardar_editar);
            this.Controls.Add(this.tb_edit_nombre);
            this.Controls.Add(this.bt_cargar_editar);
            this.Controls.Add(this.bt_cargar_combo);
            this.Controls.Add(this.cmb_unidad_medida);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_guardar);
            this.Name = "formulario1";
            this.Text = "formulario1";
            ((System.ComponentModel.ISupportInitialize)(this.gv_todo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nombre;

        private System.Windows.Forms.ComboBox cmb_unidad_medida;
        private System.Windows.Forms.Button bt_cargar_combo;
        private System.Windows.Forms.Button bt_cargar_editar;
        private System.Windows.Forms.TextBox tb_edit_nombre;
        private System.Windows.Forms.Button bt_guardar_editar;
        private System.Windows.Forms.TextBox tb_edit_id;
        private System.Windows.Forms.DataGridView gv_todo;
        private System.Windows.Forms.Button bt_cargar_gv;

    }
}