using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEntity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TOCC8Entities contexto;
            try
            {
                contexto = new TOCC8Entities();
                var lista = from m in contexto.mensagem orderby m.codigo descending select new { m.usuario, m.msg };//LINQ
                dgvMsg.DataSource = lista.ToList();
                dgvMsg.Columns[0].Width = 100;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            TOCC8Entities contexto;
            mensagem msg;
            try
            {
                if(txtUser.Text.Trim().Length > 2)
                {
                    txtUser.ReadOnly = true;
                    if(txtMsg.Text.Trim().Length > 2)
                    {
                        msg = new mensagem();
                        msg.usuario = txtUser.Text;
                        msg.msg = txtMsg.Text;

                        contexto = new TOCC8Entities();

                        contexto.mensagem.Add(msg);
                        contexto.SaveChanges();
                    }
                }
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
