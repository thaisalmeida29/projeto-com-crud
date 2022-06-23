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
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //string de conexao garante o elo do APP com o BD SQL Server Express

        private string conexaoString = ConfigurationManager.ConnectionStrings["GlicemiaDBString"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }


        private void carregarListView()
        {
            //objeto de conexao que conversa com o string de conexao
            SqlConnection conexao = new SqlConnection(conexaoString);
            try
            {
                conexao.Open();
                //ADO em ação -> texto ou sentença SQL
                string sqlTexto = "SELECT idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente FROM MedidaGlicemia";

                //ADO em ação -> associando o sqlTexto com a conexao, ou seja, tá mandando para o BD
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);

                listView_medidasGlicemias.Items.Clear();

                //objeto leitor tem a resposta do sqlTexto
                SqlDataReader leitor = comando.ExecuteReader();
                int i = 0;
                while (leitor.Read())
                {
                    listView_medidasGlicemias.Items.Add(leitor["idMedidaGlicemia"].ToString());
                    listView_medidasGlicemias.Items[i].SubItems.Add(leitor["valorGlicemia"].ToString());
                    listView_medidasGlicemias.Items[i].SubItems.Add(leitor["dataMedida"].ToString());
                    listView_medidasGlicemias.Items[i].SubItems.Add(leitor["idPaciente"].ToString());
                    i++;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Problemas de conexão com BD", "Alerta");
            }

            conexao.Close();
        }
        private void button_conectar_Click(object sender, EventArgs e)
        {
            carregarListView();
            Banco banco = new Banco();
            try
            {
                if (textBox_nomeBanco.Text.Equals("") || banco.abrirConexao(textBox_nomeBanco.Text) == null)
                {
                    throw new Exception();
                }
                MessageBox.Show("Banco conectado: " + textBox_nomeBanco.Text, "Alerta");
                button_conectar.Enabled = false;
                button_desconectar.Enabled = true;
                textBox_nomeBanco.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas para conectar com o banco", "Alerta");
            }
        }

        private void tbDataMedicao_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //capturar valores das variáveis
                int idMedidaGlicemia = int.Parse(tbmedidaGlicemia.Text);
                int valorGlicemia = int.Parse(tbValorGlicemia.Text);
                string dataMedida = (tbDataMedicao.Text);
                int idPaciente = int.Parse(tbPaciente.Text);

                //gerar sentenças SQL
                string sqlTexto = "INSERT INTO MedidaGlicemia (idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente) VALUES(@idMedidaGlicemia, @valorGlicemia, @dataMedida, @idPaciente)";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);
                comando.Parameters.AddWithValue("@valorGlicemia", valorGlicemia);
                comando.Parameters.AddWithValue("@dataMedida", dataMedida);
                comando.Parameters.AddWithValue("@idPaciente", idPaciente);

                //executar sentença SQL
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            conexao.Close();

            //recarregar ListView
            carregarListView();
            
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            tbmedidaGlicemia.Clear();
            tbDataMedicao.Clear();
            tbValorGlicemia.Clear();
            tbPaciente.Clear();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //MessageBox.Show(listView_medidasGlicemias.SelectedItems[0].Text);
                int idMedidaGlicemia = int.Parse(listView_medidasGlicemias.SelectedItems[0].Text);

                //gerar sentenças SQL
                string sqlTexto = "DELETE FROM MedidaGlicemia WHERE idMedidaGlicemia = @idMedidaGlicemia";

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);

                //executar sentença SQL
                if(comando.ExecuteNonQuery()!= 0)
                {
                    MessageBox.Show("Remoção realizada com sucesso.");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Remoção não realizada, tente novamente." + erro);
            }

            conexao.Close();

            //recarregar ListView
            carregarListView();
        }

        private void button_desconectar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            try
            {
                banco.fecharConexao();
                MessageBox.Show("Banco desconectado: " + textBox_nomeBanco.Text, "Alerta");
                button_conectar.Enabled = true;
                button_desconectar.Enabled = false;
                textBox_nomeBanco.Text = "";
                textBox_nomeBanco.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas para desconectar com o banco", "Alerta");
            }

           
        }
            
    }
}

