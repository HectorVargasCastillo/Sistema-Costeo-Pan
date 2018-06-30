using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class FormReporteKilo : Form
    {
        public FormReporteKilo()
        {
            InitializeComponent();
            llenarCompoTipoPan();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void llenarCompoTipoPan() {
            costeoEntities db = new costeoEntities();
            var lista = db.producto.ToList();

            if (lista.Count > 0)
            {

                cb_tipopan.DataSource = lista;
                cb_tipopan.DisplayMember = "nombre";
                cb_tipopan.ValueMember = "id";
            }
        }
        private void cb_tipopan_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }



        private void bt_mostrar_Click(object sender, EventArgs e)
        {
            // RECIBIR DATOS
            var fecha_inicio = tp_inicio;
            var fecha_fin = tp_fin;
            var tipo_pan = cb_tipopan;

            costeoEntities db = new costeoEntities();
            DataTable tabla = new DataTable();

            tabla.Columns.Add("Fecha");
            tabla.Columns.Add("Precio Costo");
            tabla.Columns.Add("Precio Venta");
            tabla.Columns.Add("Rentabilidad $");
            tabla.Columns.Add("Rentabilidad %");

            Boolean se_encontro=false;
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
                
                    if ((int.Parse(cb_tipopan.SelectedValue.ToString()) == pd.producto_id) && (f_inicio<= pd.fecha) && (f_fin >= pd.fecha))
                    {
                        se_encontro = true;

                        DataRow row = tabla.NewRow();
                        row["Fecha"] = Convert.ToString(pd.fecha);
                        var costo = db.costo.FirstOrDefault(codigo => codigo.producto_id == pd.producto_id);
                        row["Precio Costo"] = costo.valor;
                        var venta = db.precio_venta.FirstOrDefault(codigo => codigo.producto_id == pd.producto_id);
                        row["Precio Venta"] = venta.valor;
                        row["Rentabilidad $"] = (venta.valor - costo.valor);
                        Decimal rentabilidad = (((Convert.ToDecimal(venta.valor) / costo.valor) - 1) * 100);
                        row["Rentabilidad %"] = rentabilidad.ToString("###,###.##");
                        tabla.Rows.Add(row);                        
                    }
                }
            }
            if (se_encontro == false) {
                MessageBox.Show("No se encontraron registros ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            dg_reporte.DataSource = tabla;
            dg_reporte.Refresh();
        }

        private void FormReporteKilo_Load(object sender, EventArgs e)
        {

        }

        private void dg_reporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
