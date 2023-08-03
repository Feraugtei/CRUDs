using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Cliente cliente;
            ClienteDAO clienteDAO;
            try
            {
                cliente = new Cliente();
                cliente.setNome(txtBoxNome.Text);
                cliente.setIdade(txtBoxIdade.Text);

                clienteDAO = new ClienteDAO();
                if(clienteDAO.gravar(cliente) > 0)
                {
                    MessageBox.Show("Salvo com sucesso.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO;
            try
            {
                clienteDAO = new ClienteDAO();
                dgvDados.DataSource = clienteDAO.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO;
            Cliente cliente;
            int codigo;
            try
            {
                if(txtBoxCodigo.Text.Trim().Length > 0)
                {
                    codigo = Convert.ToInt32(txtBoxCodigo.Text);
                    clienteDAO = new ClienteDAO();
                    cliente = clienteDAO.preencher(codigo);
                    if(cliente != null)
                    {
                        txtBoxCodigo.Text = cliente.codigo.ToString();
                        txtNome.Text = cliente.nome;
                        txtIdade.Text = cliente.idade.ToString();
                    }
                    else
                    {
                        txtBoxNome.Clear();
                        txtBoxIdade.Clear();
                        txtBoxNome.Focus();
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
