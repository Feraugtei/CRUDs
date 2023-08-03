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

        public string nome { get; private set; }

        public int idade { get; private set; }

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

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public void setIdade(int i)
        {
            if (i < 0)
                throw new Exception("Idade Inválida");
            else
                this.idade = i;
        }

        public void setIdade(string i)
        {
            this.setIdade(Convert.ToInt32(i));
        }
    }
}
