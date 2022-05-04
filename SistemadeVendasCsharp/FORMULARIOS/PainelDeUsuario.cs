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

        ConexaoBancoDados dal = new ConexaoBancoDados();
        DadosCliente dadoscliente = new DadosCliente();

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
            dadoscliente.usuario_tipo = comboTipoUsuario.Text;
            dadoscliente.add_data = DateTime.Now;
            dadoscliente.add_porquem = 1;

            bool isSucesso = cadastrar.Insert(dadoscliente);
            if (isSucesso == true)
            {
                MessageBox.Show("usuario cadastrado com sucesso.");
            }
            else
            {
                MessageBox.Show("erro ao cadastrar usuario.");
            }


            DataTable dt = cadastrar.Select();
            dvgUsuario.DataSource = dt;

            Limpar();
         }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            ConexaoBancoDados atualizar = new ConexaoBancoDados();  
            DadosCliente dadoscliente = new DadosCliente();

            dadoscliente.id = Convert.ToInt32(textID.Text);

            dadoscliente.nome = textNome.Text  ;
            dadoscliente.sobrenome = textSobrenome.Text;
            dadoscliente.email = textEmail.Text;
            dadoscliente.usuario = textUsuario.Text;
            dadoscliente.senha = textSenha.Text;
            dadoscliente.contato = textContato.Text;
            dadoscliente.endereco = textEndereco.Text;
            dadoscliente.sexo = comboSexo.Text;
            dadoscliente.usuario_tipo = comboTipoUsuario.Text;
            dadoscliente.add_data = DateTime.Now;
            dadoscliente.add_porquem = 1;
        

            bool isSucesso = atualizar.Update(dadoscliente);
            if (isSucesso == true)
            {
                MessageBox.Show("cadastro atualizado  com sucesso.");
                Limpar();
            }
            else
            {
                MessageBox.Show("erro ao atualizar cadastro.");
             
            }


            DataTable dt = atualizar.Select();
            dvgUsuario.DataSource = dt;

          
        }

        private void textPesquisarUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void dvgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PainelDeUsuario_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dvgUsuario.DataSource = dt;
        }

        private void btdeletar_Click(object sender, EventArgs e)
        {
       
        }
        //Toda vez que o cadastro for realizado com sucesso as caixinhas de texto serao limpas para digitar outro usuario.
        private void Limpar()
        {
            textID.Text = "";
            textNome.Text = "";
            textSobrenome.Text = "";
            textEmail.Text = "";
            textUsuario.Text = "";
            textSenha.Text = "";
            textContato.Text = "";
            textEndereco.Text = "";
            comboSexo.Text = "";
            comboTipoUsuario.Text = "";

        }

        private void dvgUsuario_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textID.Text = dvgUsuario.Rows[rowIndex].Cells[0].Value.ToString();
            textNome.Text = dvgUsuario.Rows[rowIndex].Cells[1].Value.ToString();
            textSobrenome.Text = dvgUsuario.Rows[rowIndex].Cells[2].Value.ToString();
            textEmail.Text = dvgUsuario.Rows[rowIndex].Cells[3].Value.ToString();
            textUsuario.Text = dvgUsuario.Rows[rowIndex].Cells[4].Value.ToString();
            textSenha.Text = dvgUsuario.Rows[rowIndex].Cells[5].Value.ToString();
            textContato.Text = dvgUsuario.Rows[rowIndex].Cells[6].Value.ToString();
            textEndereco.Text = dvgUsuario.Rows[rowIndex].Cells[7].Value.ToString();
            comboSexo.Text = dvgUsuario.Rows[rowIndex].Cells[8].Value.ToString();
            comboTipoUsuario.Text = dvgUsuario.Rows[rowIndex].Cells[9].Value.ToString();
        }
    }
}