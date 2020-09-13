using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMVI
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            txtDataCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtCpf.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroClientes Clientes = new CadastroClientes(txtNome.Text, txtCpf.Text, txtRg.Text, txtLogradouro.Text, txtEndereco.Text, txtNumero.Text, mskCep.Text, txtBairro.Text, txtCidade.Text, cmbUf.Text, txtDdd.Text, txtTelefone.Text, txtContato.Text, txtEmail.Text, txtObs.Text);
            MessageBox.Show(Clientes.mensagem, "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
        }
    }
}
