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
                banco.comando.CommandText = "Insert into cliente(nome,idade) values(@n,@i);";
                banco.comando.Parameters.Add("@n", NpgsqlTypes.NpgsqlDbType.Varchar).Value = obj.nome;
                banco.comando.Parameters.Add("@i", NpgsqlTypes.NpgsqlDbType.Integer).Value = obj.idade;
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

        public void gravarGetCodigo(Cliente obj)
        {
            Banco banco;
            int qtde = 0;
            int codigo;
            try
            {
                banco = new Banco();
                banco.comando.CommandText = "Insert into cliente(nome,idade) values(@n,@i) returning codigo;";
                banco.comando.Parameters.Add("@n", NpgsqlTypes.NpgsqlDbType.Varchar).Value = obj.nome;
                banco.comando.Parameters.Add("@i", NpgsqlTypes.NpgsqlDbType.Integer).Value = obj.idade;
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
                banco.comando.CommandText = "Select codigo,nome, idade from cliente order by 1;";
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

        public Cliente preencher(int codigo)
        {
            Banco banco;
            Cliente cliente = null;
            try
            {
                banco = new Banco();
                banco.comando.CommandText = "Select codigo,nome, idade from cliente where codigo= @c;";
                banco.comando.Parameters.Add("@c", NpgsqlTypes.NpgsqlDbType.Integer).Value = codigo;
                banco.comando.Prepare();
                banco.reader = banco.comando.ExecuteReader();
                if (banco.reader.Read())
                {
                    cliente = new Cliente();
                    cliente.setCodigo((int)banco.reader[0]);
                    cliente.setNome((String)banco.reader[1]);
                    cliente.setIdade((int)banco.reader[2]);
                }
                Banco.conexao.Close();
                return (cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao preencher cliente: " + ex.Message);
            }
        }
    }
}
