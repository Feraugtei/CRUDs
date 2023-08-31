using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityManagerTB2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            TOCC8Entities contexto;
            produto obj;
            try
            {
                
                obj = new produto();
                obj.descricao = txtDescricao.Text;
                obj.datavalidade = txtDataValidade.Value;
                obj.preco = Convert.ToDouble(txtPreco.Text);
                obj.taxalucro = Convert.ToDouble(txtTaxaLucro.Text);

                contexto = new TOCC8Entities();
                
                contexto.produto.Add(obj);
                contexto.SaveChanges();
                
                MessageBox.Show("Produto registrado\nCódigo: " + obj.codigo);
                txtDescricao.Clear();
                txtDataValidade.Value = DateTime.Today;
                txtPreco.Clear();
                txtTaxaLucro.Clear();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            TOCC8Entities contexto;
          
            try
            {
                contexto = new TOCC8Entities();
                var lista = from c in contexto.produto select c;
                
                dgvProduto.DataSource = lista.ToList();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            TOCC8Entities contexto;
            produto obj;
            int codigo;
            try
            {
                codigo = Convert.ToInt32(txtCodigo.Text);
                contexto = new TOCC8Entities();
                var lista = from h in contexto.produto where h.codigo == codigo select h;
                //obj = contexto.produto.First(c => c.codigo == codigo);//Expressão lambda
                obj = (produto)lista.ToList()[0];
                if (obj != null)
                {
                    obj.descricao = txtDescricao.Text;
                    obj.datavalidade = txtDataValidade.Value;
                    obj.preco = Convert.ToDouble(txtPreco.Text);
                    obj.taxalucro = Convert.ToDouble(txtTaxaLucro.Text);
                    contexto.SaveChanges();
                    MessageBox.Show("Alterações Salvas");
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            TOCC8Entities contexto;
            produto obj;
            int codigo;
            try
            {
                codigo = Convert.ToInt32(txtCodigo.Text);
                contexto = new TOCC8Entities();
                var lista = from h in contexto.produto where h.codigo == codigo select h;
                //obj = contexto.produto.First(c => c.codigo == codigo);//Expressão lambda
                obj = (produto)lista.ToList()[0];
                if (obj != null)
                {
                    contexto.produto.Remove(obj);
                    contexto.SaveChanges();
                    MessageBox.Show("Produto removido");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            int codigo;
            TOCC8Entities contexto;
            produto obj=null;
            try
            {
                if (txtCodigo.Text.Trim().Length > 0)
                {
                    codigo = Convert.ToInt32(txtCodigo.Text);
                    contexto = new TOCC8Entities();
                    var lista = from h in contexto.produto where h.codigo==codigo select h;
                    try {
                        //obj = contexto.produto.First(h => h.codigo == codigo);
                        obj = (produto)lista.ToList()[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    if (obj != null)
                    {
                        txtDescricao.Text = obj.descricao;
                        txtDataValidade.Value = obj.datavalidade;
                        txtPreco.Text = obj.preco.ToString();
                        txtTaxaLucro.Text = obj.taxalucro.ToString();
                    }
                    else
                    {
                        txtDescricao.Clear();
                        txtDataValidade.Value = DateTime.Today;
                        txtPreco.Clear();
                        txtTaxaLucro.Clear();
                    }
                }
                    
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtDescricaoProduto_KeyUp(object sender, KeyEventArgs e)
        {
            TOCC8Entities contexto;
            IEnumerable<produto> lista;
            try
            {
                contexto = new TOCC8Entities();
                lista = from sebastiana in contexto.produto
                        where sebastiana.descricao.Contains(txtDescricaoProduto.Text)
                        orderby sebastiana.preco descending
                        select sebastiana;
                dgvProduto.DataSource = lista.ToList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dgvProduto_DoubleClick(object sender, EventArgs e)
        {
            int linha;
            try
            {
                if (dgvProduto.Rows.Count > 0)
                {
                    linha = dgvProduto.SelectedCells[0].RowIndex;
                    if (linha >= 0)
                    {
                        txtCodigo.Text = dgvProduto.Rows[linha].Cells[0].Value.ToString();
                        txtDescricao.Text = dgvProduto.Rows[linha].Cells[1].Value.ToString();
                        txtDataValidade.Value = (DateTime) dgvProduto.Rows[linha].Cells[2].Value;
                        txtPreco.Text = dgvProduto.Rows[linha].Cells[3].Value.ToString();
                        txtTaxaLucro.Text = dgvProduto.Rows[linha].Cells[4].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
