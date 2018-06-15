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
    public partial class FormProDiariaPan : Form
    {
        public FormProDiariaPan()
        {
            InitializeComponent();
        }

        private void FormProDiariaPan_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dg_reporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            
        }

        private void cm_prodfinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            costeoEntities db = new costeoEntities();
            var lista = db.produccion_diaria.ToList();


            if (lista.Count > 0)
            {

                cm_prodfinal.DataSource = lista;
                cm_prodfinal.DisplayMember = "nombre";
                cm_prodfinal.ValueMember = "id";
            }

        }
    }
}
