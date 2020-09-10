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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjuda Ajuda = new frmAjuda();
            Ajuda.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente Clientes = new frmCadastroCliente();
            Clientes.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto Produtos = new frmCadastroProduto();
            Produtos.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria Categoria = new frmCadastroCategoria();
            Categoria.Show();
        }

        private void fabricanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFabricante Fabricante = new frmCadastroFabricante();
            Fabricante.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCliente Clientes = new frmConsultaCliente();
            Clientes.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaProduto Produtos = new frmConsultaProduto();
            Produtos.Show();
        }
    }
}
