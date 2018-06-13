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
    public partial class FormFamilia : Form
    {
        public FormFamilia()
        {
            InitializeComponent();
            tb_descripcion.MaxLength = 45;
            listaLineas();

        }

        public void listaLineas()

        {
            costeoEntities db = new costeoEntities();
            var lista = db.linea.ToList();
            if (lista.Count > 0)
            {
                cm_linea.DataSource = lista;
                cm_linea.DisplayMember = "nombre";
                cm_linea.ValueMember = "id";
            }

        }

        
        private void tb_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {


                if (e.KeyChar == '\r')
                {
                    if (string.IsNullOrEmpty(tb_descripcion.Text))
                    {
                        MessageBox.Show("Debe Ingresar Descripcion Familia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tb_descripcion.Focus();
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

        private void bt_guardar_Click_1(object sender, EventArgs e)
        {
            if (tb_descripcion.Text == "")
            {
                // MessageBox.Show("Debe Ingresar Descripcion Familia");
                MessageBox.Show("Debe Ingresar Descripcion Familia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_descripcion.Focus();

            }
            else
            {
                familia fam = new familia();
                fam.nombre = tb_descripcion.Text;
                //var linea_id_txt = cm_linea.SelectedValue.ToString();
                //fam.linea.id = Convert.ToInt16(linea_id_txt);
                fam.linea.id = Convert.ToInt16(cm_linea.SelectedValue.ToString());
                fam.creado_el = DateTime.Today;
                fam.modificado_el = null;
                fam.eliminado_el = null;

                costeoEntities db = new costeoEntities();
                db.familia.Add(fam);
                db.SaveChanges();
                tb_descripcion.Text = "";
            }
        }

       
    }
}
