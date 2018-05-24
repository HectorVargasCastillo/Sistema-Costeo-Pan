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
    public partial class formulario1 : Form
    {
        public formulario1()
        {
            InitializeComponent();
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (tb_nombre.Text!= "")
            {
                unidad_medida um = new unidad_medida();
                um.nombre = tb_nombre.Text;

                costeoEntities db = new costeoEntities();
                db.unidad_medidaSet.Add(um);
                db.SaveChanges();
                tb_nombre.Text = "";
            }
            


        }
    }
}
