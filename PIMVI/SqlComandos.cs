using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PIMVI
{
    class CadastroClientes
    {
        //class Clientes
        //{

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            public string mensagem = "";

            public CadastroClientes(String nome,
                            String cpf,
                            String rg,
                            String logradouro,
                            String endereco,
                            String numero,
                            String cep,
                            String bairro,
                            String cidade,
                            String uf,
                            String ddd,
                            String telefone,
                            String nomeContato,
                            String email,
                            String obs)
            {
                cmd.CommandText = "INSERT INTO tbl_Clientes (nome, data, cpf, rg, logradouro, endereco, numero, cep, bairro, cidade, uf, ddd, telefone, nomeContato, email, obs) " +
                                  "VALUES (@nome, @data, @cpf, @rg, @logradouro, @endereco, @numero, @cep, @bairro, @cidade, @uf, @ddd, @telefone, @nomeContato, @email, @obs)";

                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@data", DateTime.Now);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@logradouro", logradouro);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.Parameters.AddWithValue("@cep", cep);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@uf", uf);
                cmd.Parameters.AddWithValue("@ddd", ddd);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@nomeContato", nomeContato);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@obs", obs);

                try
                {
                    cmd.Connection = conexao.conectar();
                    cmd.ExecuteNonQuery();
                    conexao.desconectar();
                    this.mensagem = "Cliente cadastrado com sucesso!";
                }
                catch (SqlException e)
                {
                    this.mensagem = e.Message;
                }
            }
        //}

        //class Produtos
        //{
        //    Conexao conexao = new Conexao();
        //    SqlCommand cmd = new SqlCommand();
        //    public string mensagem = "";

        //    public Produtos(String barra,
        //                    String nome,
        //                    String categoria,
        //                    String fabricante,
        //                    String plataforma,
        //                    double quantidade,
        //                    String garantia,
        //                    String obs
        //                    )

        //    {
        //        cmd.CommandText = "INSERT INTO tbl_Produtos (data, barra, nome, categoria, fabricante, plataforma, quantidade, garantia, obs)" +
        //                          "VALUES(@data, @barra, @nome, @categoria, @fabricante, @plataforma, @quantidade, @garantia, @obs)";

        //        cmd.Parameters.AddWithValue("@barra", barra);
        //        cmd.Parameters.AddWithValue("@data", DateTime.Now);
        //        cmd.Parameters.AddWithValue("@nome", nome);
        //        cmd.Parameters.AddWithValue("@categoria", categoria);
        //        cmd.Parameters.AddWithValue("@fabricante", fabricante);
        //        cmd.Parameters.AddWithValue("@plataforma", plataforma);
        //        cmd.Parameters.AddWithValue("@quantidade", quantidade);
        //        cmd.Parameters.AddWithValue("@garantia", garantia);
        //        cmd.Parameters.AddWithValue("@obs", obs);

        //        try
        //        {
        //            cmd.Connection = conexao.conectar();
        //            cmd.ExecuteNonQuery();
        //            conexao.desconectar();
        //            this.mensagem = "Produto cadastrado com sucesso!";
        //        }
        //        catch (SqlException e)
        //        {
        //            this.mensagem = e.Message;
        //        }

        //    }
        //}

        //class Usuario
        //{
        //    Conexao conexao = new Conexao();
        //    SqlCommand cmd = new SqlCommand();
        //    public string mensagem = "";

        //    public Usuario()
        //    {

        //    }
        //}

        //class Fabricante
        //{
        //    Conexao conexao = new Conexao();
        //    SqlCommand cmd = new SqlCommand();
        //    public string mensagem = "";

        //    public Fabricante()
        //    {

        //    }
        //}

        //class Categoria
        //{
        //    Conexao conexao = new Conexao();
        //    SqlCommand cmd = new SqlCommand();
        //    public string mensagem = "";

        //    public Categoria()
        //    {

        //    }
        //}
    
    }

    class Consulta
    {
        class Clientes
        {

        }

        class Produtos
        {

        }

        //ver bloco de codigo que nao ta conseguindo busucar os users nessa class 
        class Login
        {
            public Login()
            {
                /*try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CKNEAKE;Initial Catalog=PIMV;User ID=sa;Password=30136416");
                    string query = "SELECT * FROM tbl_Login WHERE login = '" + txtUsuario.Text.Trim() + "'AND senha = '" + txtSenha.Text.Trim() + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable table = new DataTable();
                    da.Fill(table);

                    if (table.Rows.Count == 1)
                    {
                        Sistema.FRM_Menu Menu = new Sistema.FRM_Menu();
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
                }*/
            }
        }
    }

    class Alterar
    {
        class Senha
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            public string mensagem = "";

            public Senha(String usuario, String senha)
            {
                cmd.CommandText = "UPDATE tbl_Login SET senha = @senha WHERE login = @login";

                cmd.Parameters.AddWithValue("@login", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);

                try
                {
                    cmd.Connection = conexao.conectar();
                    cmd.ExecuteNonQuery();
                    conexao.desconectar();
                    this.mensagem = "Senha alterada com sucesso, entre com o mesmo";
                }
                catch (SqlException e)
                {
                    this.mensagem = e.Message;
                }
            }
        }
    }
}
