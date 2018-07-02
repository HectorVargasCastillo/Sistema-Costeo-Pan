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
    public partial class FormUniMed : Form
    {
        public FormUniMed()
        {
            InitializeComponent();
            tb_nombre.Select();
            tb_nombre.MaxLength = 45;
            tb_abreviacion.MaxLength = 2;
            mostrar_datagridview();
            tb_id.Visible = false;

        }

        private void tb_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {

                if (e.KeyChar == '\r')
                {
                    if (string.IsNullOrEmpty(tb_nombre.Text))
                    {
                        MessageBox.Show("Debe Ingresar Nombre U.M.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tb_nombre.Focus();
                    }
                    else
                    {
                        tb_abreviacion.Focus();
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


        private void tb_abreviacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                if (e.KeyChar == '\r')
                {
                    if (string.IsNullOrEmpty(tb_abreviacion.Text))
                    {
                        MessageBox.Show("Debe Ingresar Abreviacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tb_abreviacion.Focus();
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

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if ((tb_nombre.Text == "") || (tb_abreviacion.Text == ""))
            {
                if (tb_nombre.Text == "")
                {
                    MessageBox.Show("Debe Ingresar Nombre U.M.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_nombre.Focus();
                }
                else
                {
                    if (tb_abreviacion.Text == "")
                    {
                        MessageBox.Show("Debe Ingresar Abreviacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tb_abreviacion.Focus();
                    }
                }
            }
            else
            {

                if (tb_id.Text == "")
                {
                    costeoEntities db = new costeoEntities();
                    String abre = "N";
                    String nomb = "N";

                    foreach (var dato in db.unidad_medida.ToList())
                    {
                        if (dato.codigo == tb_abreviacion.Text)
                        {
                            abre = "S";
                        }
                        if (dato.descripcion == tb_nombre.Text)
                        {
                            nomb = "S";
                        }

                    }


                    //unidad_medida umA = new unidad_medida();
                    //umA = db.unidad_medida.Find(Convert.ToString(tb_abreviacion.Text));
                    //unidad_medida umN = new unidad_medida();
                    //umN = db.unidad_medida.Find(Convert.ToString(tb_nombre.Text));
                    if ((abre == "S") || (nomb == "S"))
                    {
                        if (abre == "S")
                        {
                            MessageBox.Show("Abreviacion Ya Existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        if (nomb == "S")
                        {
                            MessageBox.Show("Descripcion Ya Existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        tb_nombre.Text = "";
                        tb_abreviacion.Text = "";
                        tb_id.Text = "";
                        mostrar_datagridview();
                        tb_nombre.Focus();
                    }
                    else
                    {
                        unidad_medida um = new unidad_medida();
                        um.codigo = tb_abreviacion.Text;
                        um.descripcion = tb_nombre.Text;
                        um.creado_el = DateTime.Today;
                        um.modificado_el = null;
                        um.eliminado_el = null;
                        //costeoEntities db = new costeoEntities();
                        db.unidad_medida.Add(um);
                        db.SaveChanges();
                        MessageBox.Show("Registro Guardado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tb_nombre.Text = "";
                        tb_abreviacion.Text = "";
                        tb_id.Text = "";
                        mostrar_datagridview();
                        tb_nombre.Focus();
                    }

                   
                }
                else
                {
                    MessageBox.Show("Registro Ya Existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_nombre.Text = "";
                    tb_abreviacion.Text = "";
                    tb_id.Text = "";
                    mostrar_datagridview();
                    tb_nombre.Focus();
                }
                
            }
        }

        private void mostrar_datagridview()
        {
            costeoEntities dbum = new costeoEntities();
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Descripcion");
            tabla.Columns.Add("Codigo");
            foreach (var dato in dbum.unidad_medida.ToList())
            {
                if (dato.eliminado_el == null)
                {
                    DataRow row = tabla.NewRow();
                    row["Id"] = Convert.ToString(dato.id);
                    row["Descripcion"] = dato.descripcion;
                    row["Codigo"] = dato.codigo;
                    tabla.Rows.Add(row);
                }
            }
            tabla.DefaultView.Sort = "[Id] DESC";
            dg_mostrar.DataSource = tabla;
            //dg_mostrar.Columns["Descripcion"].Width = 226;
            dg_mostrar.Columns["Id"].ReadOnly= true;
            dg_mostrar.Columns["Id"].Visible = false;
            dg_mostrar.Columns["Descripcion"].ReadOnly = true;
            dg_mostrar.Columns["Codigo"].ReadOnly = true;
            dg_mostrar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_mostrar.Refresh();
        }

        private void dg_mostrar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("XXXXXX", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            tb_id.Text = dg_mostrar.CurrentRow.Cells["Id"].Value.ToString();
            tb_nombre.Text = dg_mostrar.CurrentRow.Cells["Descripcion"].Value.ToString();
            tb_abreviacion.Text = dg_mostrar.CurrentRow.Cells["Codigo"].Value.ToString();
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            if ((tb_nombre.Text == "") || (tb_abreviacion.Text == ""))
            {
                MessageBox.Show("Para Editar, Debe Pinchar Celda de Grilla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_nombre.Focus();
            }
            else
            {

                //MessageBox.Show(tb_id.Text, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (tb_id.Text == "")
                {
                    MessageBox.Show("ERROR : No Permite Modificar Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_nombre.Focus();
                }
                else
                {
                    costeoEntities db = new costeoEntities();
                    unidad_medida um = new unidad_medida();
                    um = db.unidad_medida.Find(Convert.ToInt16(tb_id.Text));

                    if (um == null)
                    {
                        MessageBox.Show("ERROR : No Permite Modificar Registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {

                        if ((um.codigo != tb_abreviacion.Text) || (um.descripcion != tb_nombre.Text))
                        {
                            um.codigo = tb_abreviacion.Text;
                            um.descripcion = tb_nombre.Text;
                            um.modificado_el = DateTime.Today;
                            db.SaveChanges();
                            MessageBox.Show("Registro Modificado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            tb_nombre.Text = "";
                            tb_abreviacion.Text = "";
                            tb_id.Text = "";
                            mostrar_datagridview();
                            tb_nombre.Focus();
                        }
                        else{
                            MessageBox.Show("No Modificó Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            tb_nombre.Text = "";
                            tb_abreviacion.Text = "";
                            tb_id.Text = "";
                            mostrar_datagridview();
                            tb_nombre.Focus();
                        }
                    }
                }

            }
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if ((tb_nombre.Text == "") || (tb_abreviacion.Text == ""))
            {
                MessageBox.Show("Para Eliminar, Debe Pinchar Celda de Grilla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_nombre.Focus();
            }
            else
            {


                if (tb_id.Text == "")
                {
                    MessageBox.Show("ERROR : No Permite Eliminar Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_nombre.Focus();
                }
                else
                {

                    if (MessageBox.Show("Estas seguro de eliminar este registro ?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        costeoEntities db = new costeoEntities();
                        unidad_medida um = new unidad_medida();
                        um = db.unidad_medida.Find(Convert.ToInt16(tb_id.Text));

                        if (um == null)
                        {
                            MessageBox.Show("ERROR : No Permite Eliminar Registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            um.eliminado_el = DateTime.Today;
                            db.SaveChanges();
                            MessageBox.Show("Registro Eliminado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            tb_nombre.Text = "";
                            tb_abreviacion.Text = "";
                            tb_id.Text = "";
                            mostrar_datagridview();
                            tb_nombre.Focus();
                        }
                    }
                    else
                    {
                        tb_nombre.Text = "";
                        tb_abreviacion.Text = "";
                        tb_id.Text = "";
                        mostrar_datagridview();
                        tb_nombre.Focus();
                    }

                        
                }

            }
        }
    }
}
