﻿using System;
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
        public string myconstring =( @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = CsharpVenda; Integrated Security = True");
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
            bool isSucesso = false;
            SqlConnection con = new SqlConnection(myconstring);
          
            try
            {
                string sql = "insert into tabela_usuarios (nome, sobrenome, email, usuario, senha , contato, endereco, sexo, usuario_tipo, add_data, add_porquem) values" +
                    " (@nome, @sobrenome,@email, @usuario, @senha , @contato, @endereco, @sexo, @usuario_tipo, @add_data, @add_porquem) ";
                SqlCommand cmd = new SqlCommand(sql, con);
                
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@sobrenome",u.sobrenome);
                cmd.Parameters.AddWithValue("@email",u.email);
                cmd.Parameters.AddWithValue("@usuario", u.usuario);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@contato", u.contato);
                cmd.Parameters.AddWithValue("@endereco", u.endereco);
                cmd.Parameters.AddWithValue("@sexo", u.sexo);
                cmd.Parameters.AddWithValue("@usuario_tipo", u.usuario_tipo);
                cmd.Parameters.AddWithValue("@add_data", u.add_data);
                cmd.Parameters.AddWithValue("@add_porquem", u.add_porquem);
              
                con.Open();
                
                int rows = cmd.ExecuteNonQuery();
                 
                    if ( rows > 0 )
                    {
                       isSucesso = true;
                 
                    }
                    else
                    {
                        isSucesso = false;
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
            return isSucesso;
        } 
    }
    #endregion
}