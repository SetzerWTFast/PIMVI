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

namespace PIMVI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CKNEAKE;Initial Catalog=PIMVI;User ID=sa;Password=30136416");
                string query = "SELECT * FROM tbl_Usuarios WHERE usuario = '" + txtUsuario.Text.Trim() + "'AND senha = '" + txtSenha.Text.Trim() + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                da.Fill(table);

                if (table.Rows.Count == 1)
                {
                    frmMenu Menu = new frmMenu();
                    Menu.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha incorretos, tente novamente.", "Erro ao Entrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                    txtUsuario.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao conectar com o Banco de Dados, entre em contato com o suporte do sistema ou reinicie seu computador!");
                Application.Exit();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
