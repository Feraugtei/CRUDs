using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Cliente
{
    public partial class fGraficos : Form
    {
        public fGraficos()
        {
            InitializeComponent();
            mostrarGrafico();
        }

        public void mostrarGrafico()
        {
            DataTable tabela;
            ClienteDAO clienteDAO;
            int i;
            double valor = 0;
            try
            {
                clienteDAO = new ClienteDAO();
                tabela = clienteDAO.listar();
                chart1.ChartAreas[0].AxisX.Title = "Descrição";
                chart1.ChartAreas[0].AxisY.Title = "Lucro";
                chart1.Titles.Add(" Lucros e Validades");

                chart1.Series[0].Name = "Lucro";
                chart1.Series[0].IsVisibleInLegend = true;

                chart1.Series.Add(new Series()); //inclui uma serie nova
                chart1.Series[1].Name = "Validade";
                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();

                for (i=0; i<tabela.Rows.Count; i++)
                {
                    if  (! ((tabela.Rows[i][4] != DBNull.Value) && (Double.TryParse(tabela.Rows[i][4].ToString(), out valor))))
                    {
                        valor = 0;
                    }

                    chart1.Series[0].Points.AddXY((string)tabela.Rows[i][1],
                        Convert.ToDouble(tabela.Rows[i][4]));
                    chart1.Series[1].Points.Add(Convert.ToDouble(((DateTime)tabela.Rows[i][2] - DateTime.Today).Days));
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void fGraficos_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
