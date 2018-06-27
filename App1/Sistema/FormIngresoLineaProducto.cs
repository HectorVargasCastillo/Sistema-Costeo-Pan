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
            tb_descripcionlinea.MaxLength = 45;
            tb_descripcionlinea.Focus();
            cargar_columnas_datagridview();
            tb_id.Visible = false;
        }
        private void tb_descripcionlinea_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {


                if (e.KeyChar == '\r')
                {
                    if (string.IsNullOrEmpty(tb_descripcionlinea.Text))
                    {
                        MessageBox.Show("Debe Ingresar Descripcion Linea", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tb_descripcionlinea.Focus();
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
            if (tb_descripcionlinea.Text == "")
            {
                // MessageBox.Show("Debe Ingresar Descripcion linea");
                MessageBox.Show("Debe Ingresar Descripcion Linea", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_descripcionlinea.Focus();

            }
            else
            {
                if (tb_id.Text == "")
                {
                    costeoEntities db = new costeoEntities();
                    String nomb = "N";
                    foreach (var dato in db.familia.ToList())
                    {
                        if (dato.nombre == tb_descripcionlinea.Text)
                        {
                            nomb = "S";
                        }
                    }
                    if (nomb == "S")
                    {
                        MessageBox.Show("Descripcion Ya Existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tb_descripcionlinea.Text = "";
                        tb_id.Text = "";
                        mostrar_datagridview();
                        tb_descripcionlinea.Focus();
                    }
                    else
                    {
                        linea lin = new linea();
                        var codigo_lin = Convert.ToInt16(tb_descripcionlinea.Text);

                        var linea = db.linea.FirstOrDefault(codigol => codigol.id == codigo_lin);
                        lin.nombre = tb_descripcionlinea.Text;
                        //var linea_id_txt = cm_linea.SelectedValue.ToString();
                        //fam.linea.id = Convert.ToInt16(linea_id_txt);
                        //fam.linea.id = Convert.ToInt16(cm_linea.SelectedValue);
                        
                        lin.creado_el = DateTime.Today;
                        lin.modificado_el = null;
                        lin.eliminado_el = null;
                        db.linea.Add(lin);
                        db.SaveChanges();
                        MessageBox.Show("Registro Guardado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tb_descripcionlinea.Text = "";
                        tb_id.Text = "";
                        mostrar_datagridview();
                        tb_descripcionlinea.Focus();

                    }
                }
                else
                {
                    MessageBox.Show("Registro Ya Existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_descripcionlinea.Text = "";
                    tb_id.Text = "";
                    mostrar_datagridview();
                    tb_descripcionlinea.Focus();
                }
            }

        }

        private void bt_editar_Click(object sender, EventArgs e)
        {

            if (tb_descripcionlinea.Text == "")
            {
                MessageBox.Show("Para Editar, Debe Pinchar Celda de Grilla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // cm_linea.Focus();
                tb_descripcionlinea.Focus();
            }
            else
            {
                if (tb_id.Text == "")
                {
                    MessageBox.Show("ERROR : No Permite Modificar Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //   cm_linea.Focus()
                    tb_descripcionlinea.Focus();
                }
                else
                {
                    costeoEntities db = new costeoEntities();
                    linea lin = new linea();
                    lin = db.linea.Find(Convert.ToInt16(tb_id.Text));

                    if (lin == null)
                    {
                        MessageBox.Show("ERROR : No Permite Modificar Registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        if (lin.nombre != tb_descripcionlinea.Text)
                        {
                            lin.nombre = tb_descripcionlinea.Text;
                            var codigo_lin = Convert.ToInt16(tb_descripcionlinea.Text);
                            var linea = db.linea.FirstOrDefault(codigol => codigol.id == codigo_lin);
                            //lin.linea = linea;
                            lin.modificado_el = DateTime.Today;
                            db.SaveChanges();
                            MessageBox.Show("Registro Modificado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            tb_descripcionlinea.Text = "";
                            tb_id.Text = "";
                            mostrar_datagridview();
                            //cm_linea.Focus();
                            tb_descripcionlinea.Focus();
                        }
                        else
                        {
                            MessageBox.Show("No Modificó Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            tb_descripcionlinea.Text = "";
                            tb_id.Text = "";
                            mostrar_datagridview();
                            //cm_linea.Focus();
                            tb_descripcionlinea.Focus();
                        }
                    }
                }

            }
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (tb_descripcionlinea.Text == "")
            {
                MessageBox.Show("Para Eliminar, Debe Pinchar Celda de Grilla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //cm_linea.Focus();
                tb_descripcionlinea.Focus();
            }
            else
            {
                if (tb_id.Text == "")
                {
                    MessageBox.Show("ERROR : No Permite Eliminar Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //cm_linea.Focus();
                    tb_descripcionlinea.Focus();
                }
                else
                {

                    if (MessageBox.Show("Estas seguro de eliminar este registro ?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        costeoEntities db = new costeoEntities();
                        linea lin = new linea();
                        lin = db.linea.Find(Convert.ToInt16(tb_id.Text));

                        if (lin == null)
                        {
                            MessageBox.Show("ERROR : No Permite Eliminar Registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            lin.eliminado_el = DateTime.Today;
                            db.SaveChanges();
                            MessageBox.Show("Registro Eliminado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            tb_descripcionlinea.Text = "";
                            tb_id.Text = "";
                            mostrar_datagridview();
                            // cm_linea.Focus();
                            tb_descripcionlinea.Focus();
                        }
                    }
                    else
                    {
                        tb_descripcionlinea.Text = "";
                        tb_id.Text = "";
                        mostrar_datagridview();
                        //cm_linea.Focus();
                        tb_descripcionlinea.Focus();
                    }
                }

            }
        }

        private void mostrar_datagridview()
        {
            var codigo_lin = Convert.ToInt16(tb_descripcionlinea.Text);
            costeoEntities dblinea = new costeoEntities();
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Descripcion");
            
            foreach (var dato in dblinea.linea.ToList())
            {
                
                    if (dato.eliminado_el == null)
                    {
                        DataRow row = tabla.NewRow();
                        row["Id"] = Convert.ToString(dato.id);
                        row["Descripcion"] = Convert.ToString(dato.nombre);
                        
                        tabla.Rows.Add(row);
                    }
                
            }
            tabla.DefaultView.Sort = "[Id] DESC";
            dg_mostrar.DataSource = tabla;
            dg_mostrar.Columns["Id"].ReadOnly = true;
            dg_mostrar.Columns["Descripcion"].ReadOnly = true;
            
            dg_mostrar.Refresh();
        }
        private void cargar_columnas_datagridview()
        {
            var codigo_lin = Convert.ToInt16(tb_descripcionlinea.Text);
            costeoEntities dbfamilia = new costeoEntities();
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Descripcion");
            

            dg_mostrar.DataSource = tabla;
            dg_mostrar.Columns["Id"].ReadOnly = true;
            dg_mostrar.Columns["Descripcion"].ReadOnly = true;
            dg_mostrar.Columns["Linea"].ReadOnly = true;
            dg_mostrar.Refresh();
        }
        private void dg_mostrar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_id.Text = dg_mostrar.CurrentRow.Cells["Id"].Value.ToString();
            tb_descripcionlinea.Text = dg_mostrar.CurrentRow.Cells["Descripcion"].Value.ToString();
            //tb_abreviacion.Text = dg_mostrar.CurrentRow.Cells["Codigo"].Value.ToString();
        }

        private void tb_linea_SelectionChangeCommited(object sender, EventArgs e)
        {
            mostrar_datagridview();
            tb_descripcionlinea.Focus();
        }
    }
}