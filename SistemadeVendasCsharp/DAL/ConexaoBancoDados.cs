using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemadeVendasCsharp.BLL;

namespace SistemadeVendasCsharp.DAL
{
    public class ConexaoBancoDados
    {
        SqlConnection con = new SqlConnection();

        #region selecionar dados do banco de dados.
        public string myconstring = (@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = CsharpVenda; Integrated Security = True");
        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(myconstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select * from tabela_usuarios";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);


            }
            finally
            {
                con.Close();
            }

            return dt;
        }
        #endregion

        #region inserir dados no banco de dados.
        public bool Insert(DadosCliente u)
        {
            bool isSucess = false;


            SqlConnection con = new SqlConnection(myconstring);

            try
            {
                string sql = "insert into tabela_usuarios (nome, sobrenome, email, usuario, PasswordChar , contato, endereco, sexo, usuario_tipo, add_data, add_porquem) values" +
                    " (@nome, @sobrenome,@email, @usuario, @PasswordChar , @contato, @endereco, @sexo, @usuario_tipo, @add_data, @add_porquem) ";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@sobrenome", u.sobrenome);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@usuario", u.usuario);
                cmd.Parameters.AddWithValue("@PasswordChar", u.PasswordChar);
                cmd.Parameters.AddWithValue("@contato", u.contato);
                cmd.Parameters.AddWithValue("@endereco", u.endereco);
                cmd.Parameters.AddWithValue("@sexo", u.sexo);
                cmd.Parameters.AddWithValue("@usuario_tipo", u.usuario_tipo);
                cmd.Parameters.AddWithValue("@add_data", u.add_data);
                cmd.Parameters.AddWithValue("@add_porquem", u.add_porquem);

                con.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucess = true;

                }
                else
                {

                    isSucess = false;
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);


            }
            finally
            {
                con.Close();

            }
            return isSucess;
        }




        #endregion
        #region atualizando dados no banco de dados.
        public bool Update(DadosCliente u)
        {
            bool isSucess = false;
            SqlConnection con = new SqlConnection(myconstring);

            try
            {
                string sql = "update tabela_usuarios set nome=@nome, sobrenome=@sobrenome, email=@email, usuario=@usuario, PasswordChar=@PasswordChar, contato=@contato," +
                    " endereco=@endereco, sexo=@sexo, usuario_tipo=@usuario_tipo, add_data=@add_data, add_porquem=@add_porquem where id=@id ";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@sobrenome", u.sobrenome);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@usuario", u.usuario);
                cmd.Parameters.AddWithValue("@PasswordChar", u.PasswordChar);
                cmd.Parameters.AddWithValue("@contato", u.contato);
                cmd.Parameters.AddWithValue("@endereco", u.endereco);
                cmd.Parameters.AddWithValue("@sexo", u.sexo);
                cmd.Parameters.AddWithValue("@usuario_tipo", u.usuario_tipo);
                cmd.Parameters.AddWithValue("@add_data", u.add_data);
                cmd.Parameters.AddWithValue("@add_porquem", u.add_porquem);
                cmd.Parameters.AddWithValue("@id", u.id);

                con.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucess = true;
                }
                else
                {
                    isSucess = false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();

            }
            return isSucess;
        }
        #endregion
        #region
        public bool Delete(DadosCliente u)
        {
            bool isSucess = false;
            SqlConnection con = new SqlConnection(myconstring);

            try
            {
                string sql = "Delete from tabela_usuarios where id=@id";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@id", u.id);
                con.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucess = true;
                }
                else
                {
                    isSucess = false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();

            }
            return isSucess;
        }

        #endregion
        #region
        public DataTable PesquisarUsuario(string keywords )
        {
            SqlConnection con = new SqlConnection(myconstring);
            DataTable dt = new DataTable();

            try
            {    
                // a palavra like me indica por quais campos eu quero buscar o meu usuario.
                string sql = "Select * from tabela_usuarios where id like  '%"  +keywords+ "%' or  nome like '%" + keywords + "%' or sobrenome like '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
            }catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                con.Close();
            }
            return dt;
        }
    }
    #endregion
}
