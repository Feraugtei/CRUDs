using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    //DAO Data Acess Object
    internal class ClienteDAO
    {
        public int gravar(Cliente obj)
        {
            Banco banco;
            int qtde = 0;
            try
            {
                banco = new Banco();
                banco.comando.CommandText = "Insert into produto(descricao,datavalidade,preco,taxalucro) values(@d,@v,@p,@l);";
                banco.comando.Parameters.Add("@d", NpgsqlTypes.NpgsqlDbType.Varchar).Value = obj.descricao;
                banco.comando.Parameters.Add("@v", NpgsqlTypes.NpgsqlDbType.Date).Value = obj.validade;
                banco.comando.Parameters.Add("@p", NpgsqlTypes.NpgsqlDbType.Double).Value = obj.preco;
                banco.comando.Parameters.Add("@l", NpgsqlTypes.NpgsqlDbType.Double).Value = obj.lucro;
                banco.comando.Prepare();
                qtde = banco.comando.ExecuteNonQuery();
                Banco.conexao.Close();
                return (qtde);
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao gravar cliente: " + ex.Message);
            }
        }
        public int atualizar(Cliente obj)
        {
            Banco banco;
            int flag = 0;
            try
            {
                banco = new Banco();
                banco.comando.CommandText = "UPDATE produto SET descricao = @d,datavalidade = @v,preco = @p,taxalucro = @l WHERE codigo = @c";
                banco.comando.Parameters.Add("@d", NpgsqlTypes.NpgsqlDbType.Varchar).Value = obj.descricao;
                banco.comando.Parameters.Add("@v", NpgsqlTypes.NpgsqlDbType.Date).Value = obj.validade;
                banco.comando.Parameters.Add("@p", NpgsqlTypes.NpgsqlDbType.Double).Value = obj.preco;
                banco.comando.Parameters.Add("@l", NpgsqlTypes.NpgsqlDbType.Double).Value = obj.lucro;
                banco.comando.Parameters.Add("@c", NpgsqlTypes.NpgsqlDbType.Integer).Value = obj.codigo;
                banco.comando.Prepare();
                flag = banco.comando.ExecuteNonQuery();
                Banco.conexao.Close();
                return (flag);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar cliente: " + ex.Message);
            }
        }
        public void gravarGetCodigo(Cliente obj)
        {
            Banco banco;
            int qtde = 0;
            int codigo;
            try
            {
                banco = new Banco();
                banco.comando.CommandText = "Insert into produto(descricao,datavalidade,preco,taxalucro) values(@d,@v,@p,@l) returning codigo;";
                banco.comando.Parameters.Add("@d", NpgsqlTypes.NpgsqlDbType.Varchar).Value = obj.descricao;
                banco.comando.Parameters.Add("@v", NpgsqlTypes.NpgsqlDbType.Date).Value = obj.validade;
                banco.comando.Parameters.Add("@p", NpgsqlTypes.NpgsqlDbType.Double).Value = obj.preco;
                banco.comando.Parameters.Add("@l", NpgsqlTypes.NpgsqlDbType.Double).Value = obj.lucro;
                banco.comando.Prepare();
                //qtde = banco.comando.ExecuteNonQuery();
                codigo = (int)banco.comando.ExecuteScalar(); // Devolve um valor
                obj.setCodigo(codigo);
                Banco.conexao.Close();
              
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar cliente com código: " + ex.Message);
            }
        }
        public DataTable listar()
        {
            Banco banco;
            try
            {
                banco = new Banco();
                banco.comando.CommandText = "Select codigo,descricao,datavalidade,preco,taxalucro from produto order by 1;";
                banco.reader = banco.comando.ExecuteReader();// Retorna uma tabela postgres
                banco.tabela = new DataTable();
                banco.tabela.Load(banco.reader);
                Banco.conexao.Close();
                return (banco.tabela);
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao listar cliente: " + ex.Message);
            }
        }

        public DataTable pesquisar(string descricao)
        {
            Banco banco;
            try
            {
                banco = new Banco();
                banco.comando.CommandText = "Select codigo,descricao,datavalidade,preco,taxalucro from produto WHERE descricao LIKE @d order by 1;";
                banco.comando.Parameters.Add("@d", NpgsqlTypes.NpgsqlDbType.Varchar).Value = "%" + descricao + "%";
                banco.reader = banco.comando.ExecuteReader();// Retorna uma tabela postgres
                banco.tabela = new DataTable();
                banco.tabela.Load(banco.reader);
                Banco.conexao.Close();
                return (banco.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar cliente: " + ex.Message);
            }
        }

        public Cliente preencher(int codigo)
        {
            Banco banco;
            Cliente cliente = null;
            try
            {
                banco = new Banco();
                banco.comando.CommandText = "SELECT codigo,descricao,datavalidade,preco,taxalucro FROM produto WHERE codigo = @c;";
                banco.comando.Parameters.Add("@c", NpgsqlTypes.NpgsqlDbType.Integer).Value = codigo;
                banco.comando.Prepare();
                banco.reader = banco.comando.ExecuteReader();
                if (banco.reader.Read())
                {
                    cliente = new Cliente();
                    cliente.setCodigo((int)banco.reader[0]);
                    cliente.setDescricao((String)banco.reader[1]);
                    cliente.setValidade((DateTime)banco.reader[2]);
                    cliente.setPreco((double)banco.reader[3]);
                    cliente.setLucro((double)banco.reader[4]);
                }
                Banco.conexao.Close();
                return (cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao preencher cliente: " + ex.Message);
            }
        }
        public int deletar(int codigo)
        {
            Banco banco;
            int flag = 0;
            try
            {
                banco = new Banco();
                banco.comando.CommandText = "DELETE FROM produto WHERE codigo = @c";
                banco.comando.Parameters.Add("@c", NpgsqlTypes.NpgsqlDbType.Integer).Value = codigo;
                banco.comando.Prepare();
                flag = banco.comando.ExecuteNonQuery();
                Banco.conexao.Close();
                return (flag);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar cliente: " + ex.Message);
            }
        }
    }
}
