using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class FormUniMed : Form
    {
        public FormUniMed()
        {
            InitializeComponent();
            tb_nombre.Select();
            tb_nombre.MaxLength = 45;
            tb_abreviacion.MaxLength = 2;
            
        }

        private void tb_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                
                if (e.KeyChar == '\r')
                {
                    if (string.IsNullOrEmpty(tb_nombre.Text))
                    {
                        MessageBox.Show("Debe Ingresar Nombre U.M.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tb_nombre.Focus();
                    }
                    else
                    {
                        tb_abreviacion.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Solo se Permiten Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }



            }
        }


        private void tb_abreviacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                if (e.KeyChar == '\r')
                {
                    if (string.IsNullOrEmpty(tb_abreviacion.Text))
                    {
                        MessageBox.Show("Debe Ingresar Abreviacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tb_abreviacion.Focus();
                    }
                    else
                    {
                        bt_guardar.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Solo se Permiten Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }

            }
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if ((tb_nombre.Text == "") || (tb_abreviacion.Text == ""))
            {
                if (tb_nombre.Text == "")
                {
                    MessageBox.Show("Debe Ingresar Nombre U.M.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_nombre.Focus();
                }
                else
                { 
                if (tb_abreviacion.Text == "")
                     {
                     MessageBox.Show("Debe Ingresar Abreviacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     tb_abreviacion.Focus();
                    }
                }
            }
            else
            {
                unidad_medida um = new unidad_medida();
                um.codigo = tb_abreviacion.Text;
                um.descripcion = tb_nombre.Text;
                um.creado_el = DateTime.Today;
                um.modificado_el = null;
                um.eliminado_el = null;
                costeoEntities db = new costeoEntities();
                db.unidad_medida.Add(um);
                db.SaveChanges();
                tb_nombre.Text = "";
                tb_abreviacion.Text = "";
            }
        }



    }
}
