using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    internal class Usuario
    {
        public int idUsuario;
        public string nomeCompleto;
        public string email;
       

        public Usuario(int idUsuario, string nomeCompleto)
        {
            this.idUsuario = idUsuario;
            this.nomeCompleto = nomeCompleto;
            this.email = email;
           
        }

        public bool gravarPessoa()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into Usuario values (@idUsuario, @nomeCompleto, @email);";
            command.Parameters.Add("@idUsuario", SqlDbType.Int);
            command.Parameters.Add("@nomeCompleto", SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);
            command.Parameters[0].Value = this.idUsuario;
            command.Parameters[1].Value = this.nomeCompleto;
            //    command.Parameters[2].Value = this.email;
          //  command.Parameters[2].Value = "thais@ufn.edu.br";
            string[] vetorDados = this.nomeCompleto.Split(' ');
            this.email = vetorDados[vetorDados.Length - 1] + "." + vetorDados[0] + "@ufn.edu.br";
            this.email = this.email.ToLower();
            command.Parameters[2].Value = this.email;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }
        }

        private void gerarEmail()
        {
            string[] vetorDados = this.nomeCompleto.Split(' ');
            this.email = vetorDados[vetorDados.Length - 1] + "." + vetorDados[0] + "@ufn.edu.br";
            this.email = this.email.ToLower();
        }

        //construtor usado no cadastro de um usuario
        public Usuario(string nome)
        {
            this.nomeCompleto = nome;
            this.gerarEmail();
        }

        //construtor usado para popular a lista a partir do arquivo (banco)
        public Usuario(string nome, string email)
        {
            this.nomeCompleto = nome;
            this.email = email;
        }

        public string Nome { get => nomeCompleto; set => nomeCompleto = value; }

        public string Email { get => email; }
    }
}

