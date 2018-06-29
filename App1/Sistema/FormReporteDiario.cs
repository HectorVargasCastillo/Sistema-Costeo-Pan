using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
                        row["Precio Venta"] = Convert.ToInt32(venta.valor);
                        row["Rentabilidad $"] = (venta.valor - costo.valor);
                        Decimal rentabilidad = (((Convert.ToDecimal(venta.valor) / costo.valor) - 1) * 100);
                        row["Rentabilidad %"] = rentabilidad.ToString("###,###.##");
                        tabla.Rows.Add(row);

                    }       
                }
                var query = from r in tabla.AsEnumerable()
                            group r by r.Field<string>("Fecha") into groupedTable
                            select new
                            {
                                id = groupedTable.Key,
                                Precio_Costo = groupedTable.Sum(s => Convert.ToInt32(s["Precio Costo"])),
                                Precio_Venta = groupedTable.Sum(s => Convert.ToInt32(s["Precio Venta"])),
                                Rent_Moneda = groupedTable.Sum(s => Convert.ToInt32(s["Rentabilidad $"])),
                                Rent_Porcentaje = groupedTable.Sum(s => Convert.ToDecimal(s["Rentabilidad %"]))
                            };

                DataTable nueva_tabla = ConvertToDataTable(query);

                for(int i=0; i<nueva_tabla.Rows.Count; i++)
                {
                    int precio_costo_g = (int) nueva_tabla.Rows[i][1];
                    int precio_venta_g = (int)nueva_tabla.Rows[i][2];

                    decimal rentabilidad_g = (((Convert.ToDecimal(precio_venta_g) / precio_costo_g) - 1) * 100);

                    nueva_tabla.Rows[i][4] = Math.Round(rentabilidad_g,2);
                }

                    dg_reporte.DataSource = nueva_tabla;
            }
            if (se_encontro == false)
            {
                MessageBox.Show("No se encontraron registros ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //dg_reporte.DataSource = nueva_tabla;
            dg_reporte.Refresh();
        }

        public DataTable ConvertToDataTable<T>(IEnumerable<T> varlist)
        {
            DataTable dtReturn = new DataTable();


            // column names
            PropertyInfo[] oProps = null;


            if (varlist == null) return dtReturn;


            foreach (T rec in varlist)
            {
                // Use reflection to get property names, to create table, Only first time, others will follow
                if (oProps == null)
                {
                    oProps = ((Type)rec.GetType()).GetProperties();
                    foreach (PropertyInfo pi in oProps)
                    {
                        Type colType = pi.PropertyType;


                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }


                        dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                    }
                }


                DataRow dr = dtReturn.NewRow();


                foreach (PropertyInfo pi in oProps)
                {
                    dr[pi.Name] = pi.GetValue(rec, null) == null ? DBNull.Value : pi.GetValue
                    (rec, null);
                }


                dtReturn.Rows.Add(dr);
            }
            return dtReturn;
        }

        private void FormReporteDiario_Load(object sender, EventArgs e)
        {

        }
    }
}
