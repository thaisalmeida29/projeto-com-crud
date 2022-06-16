using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAula15_06
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxBairro.Clear();
            textBoxCpf.Clear();
            textBoxNome.Clear();
            textBoxEnd.Clear();
            textBoxCep.Clear();
            textBoxCidade.Clear();
            textBoxIdade.Clear();

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa(textBoxNome.Text, int.Parse(textBoxIdade.Text), textBoxCpf.Text, textBoxEnd.Text, textBoxBairro.Text, textBoxCep.Text, textBoxCidade.Text);

            MessageBox.Show($"Nome: {p.nome} \n Idade: {p.idade} \n CPF: {p.cpf} \n Endereço: {p.end} \n " +
                $"Bairro: {p.bairro} \n CEP: {p.cep} \n Cidade: {p.cidade} ");
            textBoxBairro.Clear();
            textBoxCpf.Clear();
            textBoxNome.Clear();
            textBoxEnd.Clear();
            textBoxCep.Clear();
            textBoxCidade.Clear();
            textBoxIdade.Clear();
            p.gravarPessoa();
        }
    }
}
