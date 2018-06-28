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
    public partial class FormReporteDiario : Form
    {
        public FormReporteDiario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_mostrar_Click(object sender, EventArgs e)
        {
            // RECIBIR DATOS
            var fecha_inicio = tp_inicio;
            var fecha_fin = tp_fin;

            costeoEntities db = new costeoEntities();
            DataTable tabla = new DataTable();

            tabla.Columns.Add("Fecha");
            tabla.Columns.Add("Precio Costo");
            tabla.Columns.Add("Precio Venta");
            tabla.Columns.Add("Rentabilidad $");
            tabla.Columns.Add("Rentabilidad %");

            //dg_reporte.Rows.Clear();

            Boolean se_encontro = false;
            DateTime f_inicio = tp_inicio.Value.Date;
            DateTime f_fin = tp_fin.Value.Date;


            if (f_inicio > f_fin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha de termino ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                foreach (var pd in db.produccion_diaria.ToList())
                {

                    if ((f_inicio <= pd.fecha) && (f_fin >= pd.fecha))
                    {
                        se_encontro = true;
                        DataRow row = tabla.NewRow();
                        row["Fecha"] = Convert.ToString(pd.fecha);
                        var costo = db.costo.FirstOrDefault(codigo => codigo.producto_id == pd.producto_id);
                        row["Precio Costo"] = costo.valor;
                        var venta = db.precio_venta.FirstOrDefault(codigo => codigo.producto_id == pd.producto_id);
                        //row["Precio Venta"] = venta.valor;
                        row["Rentabilidad $"] = (venta.valor - costo.valor);
                        Decimal rentabilidad = (((Convert.ToDecimal(venta.valor) / costo.valor) - 1) * 100);
                        row["Rentabilidad %"] = rentabilidad.ToString("###,###.##");
                        tabla.Rows.Add(row);
                    }
                }
            }
            if (se_encontro == false)
            {
                MessageBox.Show("No se encontraron registros ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            dg_reporte.DataSource = tabla;
            dg_reporte.Refresh();
        }
        private void FormReporteDiario_Load(object sender, EventArgs e)
        {

        }
    }
}
