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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
  
        }

        private void bt_ingresar_Click(object sender, EventArgs e)
        {
            costeoEntities db = new costeoEntities();
            bool salir = false;
            var userLog="";
            foreach (var user in db.usuario) {   
                if (Convert.ToString(tb_usuario.Text) == user.nombre && Convert.ToString(tb_pass.Text) == user.password)
                {
                    Form MenuPrincipal = new MenuPrincipal();
                    MenuPrincipal.Show();
                    Form FormLogin = new FormLogin();
                    FormLogin.Close();
                    salir = true;
                    userLog = user.nombre;
                    break;                                   
                }
            }
            if (salir)
            {
                MessageBox.Show("Bienvenido "+userLog, "Login correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Usuario o Contrasena incorrectas, favor intentar nuevamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            

        }
    }
}
