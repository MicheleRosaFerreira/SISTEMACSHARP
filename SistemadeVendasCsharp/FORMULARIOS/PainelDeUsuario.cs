using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemadeVendasCsharp.DAL;
using SistemadeVendasCsharp.BLL;

namespace SistemadeVendasCsharp.FORMULARIOS
{
    public partial class PainelDeUsuario : Form
    {
        public PainelDeUsuario()
        {
            InitializeComponent();
        }
  

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {



            ConexaoBancoDados cadastrar = new ConexaoBancoDados();
            DadosCliente dadoscliente = new DadosCliente();
            dadoscliente.nome = textNome.Text;
            dadoscliente.sobrenome = textSobrenome.Text;
            dadoscliente.email = textEmail.Text;
            dadoscliente.usuario = textUsuario.Text;    
            dadoscliente.senha = textSenha.Text;
            dadoscliente.contato = textContato.Text;    
            dadoscliente.endereco = textEndereco.Text;
            dadoscliente.sexo = comboSexo.Text;
            dadoscliente.usuario_tipo= comboTipoUsuario.Text;  
            dadoscliente.add_data = DateTime.Now;
            dadoscliente.add_porquem = 1;

            bool isSucesso = cadastrar.Insert(dadoscliente);
            if(isSucesso == true)
            {
                MessageBox.Show("usuario cadastrado com sucesso.");
            }
            else
            {
                MessageBox.Show("erro ao cadastrar usuario.");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
          

        }

        private void textPesquisarUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void dvgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PainelDeUsuario_Load(object sender, EventArgs e)
        {
           
       
        }
    }
}
