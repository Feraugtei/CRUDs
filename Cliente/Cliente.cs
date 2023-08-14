using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    public class Cliente
    {
        public int codigo { get; private set; }

        public string descricao { get; private set; }

        public DateTime validade { get; private set; }

        public double preco { get; private set; }

        public double lucro { get; private set; }

        public void setCodigo(int c)
        {
            if (c < 0)
                throw new Exception("Código Inválido");
            else
                this.codigo = c;
        }

        public void setCodigo(string c)
        {
            this.setCodigo(Convert.ToInt32(c));
        }

        public void setDescricao(String descricao)
        {
            this.descricao = descricao;
        }

        public void setValidade(DateTime validade)
        {
            this.validade = validade;
        }

        public void setValidade(String validade)
        {
            this.setValidade(Convert.ToDateTime(validade));
        }

        public void setPreco(double preco)
        {
            this.preco = preco;
        }
        public void setPreco(String preco)
        {
            this.setPreco(Convert.ToDouble(preco));
        }

        public void setLucro(double lucro)
        {
            this.lucro = lucro;
        }
        public void setLucro(String lucro)
        {
            this.setLucro(Convert.ToDouble(lucro));
        }
    }
}
