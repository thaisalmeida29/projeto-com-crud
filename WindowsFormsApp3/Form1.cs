using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            string stringConexao = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=usuarios_db;TrustServerCertificate=True;Integrated Security=True";
        
        private void carregarListView()
        {
            SqlConnection conexao = new SqlConnection(stringConexao);
            conexao.Open();
            try
            {
                
                string sqlTexto = "SELECT  idUsuario, nomeCompleto, email  from Usuario";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);

                    listViewUsuario.Items.Clear();
                SqlDataReader leitor = comando.ExecuteReader();
                int i = 0;
                while (leitor.Read())
                {
                        listViewUsuario.Items.Add(leitor["idUsuario"].ToString());
                        listViewUsuario.Items[i].SubItems.Add(leitor["nomeCompleto"].ToString());
                        listViewUsuario.Items[i].SubItems.Add(leitor["email"].ToString());
                    i++;
                }
                conexao.Close();
             
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Problemas de conexão com o Banco de Dados " + e.ToString(), "Alerta");
            }

        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            carregarListView();
            buttonConectar.Enabled = false;
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection(stringConexao);
            conexao.Open();
            try
            {
                //MessageBox.Show(listView_medidasGlicemias.SelectedItems[0].Text);
                int idUsuario = int.Parse(listViewUsuario.SelectedItems[0].Text);

                //gerar sentenças SQL
                string sqlTexto = "DELETE from Usuario Where idUsuario = @idUsuario";

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idUsuario", idUsuario);
               

                //executar sentença SQL
                if (comando.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Remoção realizada com sucesso.");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Remoção não realizada, tente novamente." + erro);
            }

            conexao.Close();

            carregarListView();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {

            Usuario u = new Usuario(int.Parse(tbId.Text), tbNomeDoUsuario.Text);
            tbId.Clear();
            tbNomeDoUsuario.Clear();
            u.gravarPessoa();
            carregarListView();
        }
    }

    
    }



