using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmVendasRealizadas : Form
    {
        public frmVendasRealizadas ()
        {
            InitializeComponent();
        }

        private void frmVendasRealizadas_Load (object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendaEstoqueDataSet.Venda' table. You can move, or remove it, as needed.
            this.vendaTableAdapter1.Fill(this.vendaEstoqueDataSet.Venda);
            // TODO: This line of code loads data into the 'vendasDataSet.Venda' table. You can move, or remove it, as needed.
            this.vendaTableAdapter.Fill(this.vendasDataSet.Venda);

        }
    }
}
