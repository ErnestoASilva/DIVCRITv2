using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace DIVCRITv2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        /*
         * CADENA VIEJA PARA BASE DE DATOS INTURBIDE
        static string cadena = "Server=iturbide;Database=SISTEMA_CRIT;User Id=super;Password=super;";
        */

        //static string cadena = "Server=tutuli;Database=SISTEMA_CRIT;User Id=sa;Password=Sistemas21;";

        public static string cadena = "Data Source = Ernesto-PC; Initial Catalog =SISTEMA_CRIT;Persist Security Info=True;User ID = Admin; Password = admin1";

        public SqlConnection conexion = new SqlConnection(cadena);

        public string contrasenaEscrita; /*!< La contraseña que el usuario escribió en el campo de contraseña en el inicio de sesión. */
        public string contrasenaDevuelta; /*!< Es la contraseña del usuario guardada en la base de datos, la cual se compara con la contraseña escrita. */
        public string correoDevuelto; /*!< Es el correo guardado en la base de datos, el cuál se compara con el correo escrito por el usuario. */
        public string tipoUsuario; /*!< Es el tipo de usuario registrado con el colaborador. */

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            //GUARDAR VALOR DE CORREO EN UNA VARIABLE GLOBAL
            VariablesGlobales.emailUsuario = tbxUsuario.Text.Trim();
            contrasenaEscrita = tbxPassword.Text.Trim();
            try
            {
                //SE HACE LA CONSULTA AL SERVIDOR SQL Y SE GUARDAN LOS DATOS DEVUELTOS EN VARIABLES 
                conexion.Open();
                string consulta = string.Format("SELECT correo, contrasena, tipo_usuario FROM COLABORADORES WHERE correo = " + "'" + VariablesGlobales.emailUsuario + "';");
                SqlCommand command = new SqlCommand(consulta, conexion);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    correoDevuelto = reader[0] as string;
                    contrasenaDevuelta = reader[1] as string;
                    tipoUsuario = reader[2] as string;
                }

                conexion.Close();
                //GUARDAR VALOR DE TIPO DE USUARIO EN UNA VARIABLE GLOBAL
                VariablesGlobales.tipoUsuario = tipoUsuario;

                //COMPROBAR SI LA CONTRASEÑA OBTENIDA COINCIDE CON LA ESCRITA
                if (contrasenaEscrita == contrasenaDevuelta)
                {
                    frmMenu frmMenu = new frmMenu();
                    frmMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxUsuario.Clear();
                    tbxPassword.Clear();

                }
                //menu.ShowDialog();
                //this.Hide();
                //frmMenu menu = new frmMenu();
                //menu.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Favor de conectarse a la red local.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbxUsuario_Click(object sender, EventArgs e)
        {
            tbxUsuario.Text = "";
        }

        private void tbxPassword_Click(object sender, EventArgs e)
        {
            
        }

        private void tbxUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            //INGRESAR AL HACER CLICK A LA TECLA ENTER
            if (e.KeyCode == Keys.Enter)
            {
                btnUsuario_Click((object)sender, (EventArgs)e);
            }
        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            tbxPassword.Text = "";
            tbxPassword.PasswordChar = '•';
        }
    }
}
