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
        }


        private void cm_linea_SelectedIndexChanged(object sender, EventArgs e)
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

        private void tb_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_grabar_Click(object sender, EventArgs e)
        {

        }
    }
}
