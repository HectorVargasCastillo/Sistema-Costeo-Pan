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
    public partial class FormIngresoLineaProducto : Form
    {
        public FormIngresoLineaProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              if (tb_descripcionlinea.Text != "")
                {
                    linea lin = new linea();
                    lin.nombre = tb_descripcionlinea.Text;

                    costeoEntities db = new costeoEntities();
                    db.linea.Add(lin);
                    db.SaveChanges();
                tb_descripcionlinea.Text = "";

                }

        }
    }
}
