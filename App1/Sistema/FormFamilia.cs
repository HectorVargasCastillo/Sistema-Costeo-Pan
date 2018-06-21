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
            cargar_columnas_datagridview();
            tb_id.Visible = false;

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
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
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
                if (tb_id.Text == "")
                {
                    costeoEntities db = new costeoEntities();
                    String nomb = "N";
                    foreach (var dato in db.familia.ToList())
                    {
                        if (dato.nombre == tb_descripcion.Text)
                        {
                            nomb = "S";
                        }
                    }
                    if (nomb == "S")
                    {
                        MessageBox.Show("Descripcion Ya Existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tb_descripcion.Text = "";
                        tb_id.Text = "";
                        mostrar_datagridview();
                        cm_linea.Focus();
                    }
                    else
                    {
                        familia fam = new familia();
                        var codigo_lin = Convert.ToInt16(cm_linea.SelectedValue);
                        //costeoEntities db = new costeoEntities();
                        var linea = db.linea.FirstOrDefault(codigol => codigol.id == codigo_lin);
                        fam.nombre = tb_descripcion.Text;
                        //var linea_id_txt = cm_linea.SelectedValue.ToString();
                        //fam.linea.id = Convert.ToInt16(linea_id_txt);
                        //fam.linea.id = Convert.ToInt16(cm_linea.SelectedValue);
                        fam.linea = linea;
                        fam.creado_el = DateTime.Today;
                        fam.modificado_el = null;
                        fam.eliminado_el = null;
                        db.familia.Add(fam);
                        db.SaveChanges();
                        MessageBox.Show("Registro Guardado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tb_descripcion.Text = "";
                        tb_id.Text = "";
                        mostrar_datagridview();
                        cm_linea.Focus();

                    }
                }
                else
                {
                    MessageBox.Show("Registro Ya Existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_descripcion.Text = "";
                    tb_id.Text = "";
                    mostrar_datagridview();
                    cm_linea.Focus();
                }
            }
            
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {

            if (tb_descripcion.Text == "")
            {
                MessageBox.Show("Para Editar, Debe Pinchar Celda de Grilla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cm_linea.Focus();
            }
            else
            {
                if (tb_id.Text == "")
                {
                    MessageBox.Show("ERROR : No Permite Modificar Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cm_linea.Focus();
                }
                else
                {
                    costeoEntities db = new costeoEntities();
                    familia fam = new familia();
                    fam = db.familia.Find(Convert.ToInt16(tb_id.Text));

                    if (fam == null)
                    {
                        MessageBox.Show("ERROR : No Permite Modificar Registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        if (fam.nombre != tb_descripcion.Text)
                        {
                            fam.nombre = tb_descripcion.Text;
                            var codigo_lin = Convert.ToInt16(cm_linea.SelectedValue);
                            var linea = db.linea.FirstOrDefault(codigol => codigol.id == codigo_lin);
                            fam.linea = linea;
                            fam.modificado_el = DateTime.Today;
                            db.SaveChanges();
                            MessageBox.Show("Registro Modificado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            tb_descripcion.Text = "";
                            tb_id.Text = "";
                            mostrar_datagridview();
                            cm_linea.Focus();
                        }
                        else
                        {
                            MessageBox.Show("No Modificó Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            tb_descripcion.Text = "";
                            tb_id.Text = "";
                            mostrar_datagridview();
                            cm_linea.Focus();
                        }
                    }
                }

            }
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (tb_descripcion.Text == "") 
            {
                MessageBox.Show("Para Eliminar, Debe Pinchar Celda de Grilla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cm_linea.Focus();
            }
            else
            {
                if (tb_id.Text == "")
                {
                    MessageBox.Show("ERROR : No Permite Eliminar Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cm_linea.Focus();
                }
                else
                {

                    if (MessageBox.Show("Estas seguro de eliminar este registro ?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                                costeoEntities db = new costeoEntities();
                        familia fam = new familia();
                        fam = db.familia.Find(Convert.ToInt16(tb_id.Text));

                        if (fam == null)
                        {
                            MessageBox.Show("ERROR : No Permite Eliminar Registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }   
                        else
                        {
                        fam.eliminado_el = DateTime.Today;
                        db.SaveChanges();
                        MessageBox.Show("Registro Eliminado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tb_descripcion.Text = "";
                        tb_id.Text = "";
                        mostrar_datagridview();
                        cm_linea.Focus();
                        }
                    }
                    else
                    {
                        tb_descripcion.Text = "";
                        tb_id.Text = "";
                        mostrar_datagridview();
                        cm_linea.Focus();
                    }
                }

            }
        }

        private void mostrar_datagridview()
        {
            var codigo_lin = Convert.ToInt16(cm_linea.SelectedValue);
            costeoEntities dbfamilia = new costeoEntities();
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Descripcion");
            tabla.Columns.Add("Linea");
            foreach (var dato in dbfamilia.familia.ToList())
            {
                if (dato.linea_id == codigo_lin)
                {
                    if (dato.eliminado_el == null)
                    {
                        DataRow row = tabla.NewRow();
                        row["Id"] = Convert.ToString(dato.id);
                        row["Descripcion"] = Convert.ToString(dato.nombre);
                        costeoEntities dblinea = new costeoEntities();
                        var linea = dblinea.linea.FirstOrDefault(codigo => codigo.id == dato.linea_id);
                        row["Linea"] = linea.nombre;
                        tabla.Rows.Add(row);
                    }
                }
            }
            tabla.DefaultView.Sort = "[Id] DESC";
            dg_mostrar.DataSource = tabla;
            dg_mostrar.Columns["Id"].ReadOnly = true;
            dg_mostrar.Columns["Descripcion"].ReadOnly = true;
            dg_mostrar.Columns["Linea"].ReadOnly = true;
            dg_mostrar.Refresh();
        }
        private void cargar_columnas_datagridview()
        {
            var codigo_lin = Convert.ToInt16(cm_linea.SelectedValue);
            costeoEntities dbfamilia = new costeoEntities();
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Descripcion");
            tabla.Columns.Add("Linea");
            
            dg_mostrar.DataSource = tabla;
            dg_mostrar.Columns["Id"].ReadOnly = true;
            dg_mostrar.Columns["Descripcion"].ReadOnly = true;
            dg_mostrar.Columns["Linea"].ReadOnly = true;
            dg_mostrar.Refresh();
        }
        private void dg_mostrar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_id.Text = dg_mostrar.CurrentRow.Cells["Id"].Value.ToString();
            tb_descripcion.Text = dg_mostrar.CurrentRow.Cells["Descripcion"].Value.ToString();
            //tb_abreviacion.Text = dg_mostrar.CurrentRow.Cells["Codigo"].Value.ToString();
        }

        private void cm_linea_SelectionChangeCommited(object sender, EventArgs e)
        {
            mostrar_datagridview();
            tb_descripcion.Focus();
        }
    }
}
