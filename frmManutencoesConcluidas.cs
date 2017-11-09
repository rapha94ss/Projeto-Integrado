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
    public partial class frmManutencoesConcluidas : Form
    {
        public frmManutencoesConcluidas ()
        {
            InitializeComponent();
        }

        private void frmManutencoesConcluidas_Load (object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manutencaoDataSet.Manutencao' table. You can move, or remove it, as needed.
            this.manutencaoTableAdapter.FillByConcluidos(this.manutencaoDataSet.Manutencao);
            // TODO: This line of code loads data into the 'manutencaoDataSet.Manutencao' table. You can move, or remove it, as needed.
            this.manutencaoTableAdapter.FillByConcluidos(this.manutencaoDataSet.Manutencao);

        }

        private void fillByConcluidosToolStripButton_Click (object sender, EventArgs e)
        {
            try
            {
                this.manutencaoTableAdapter.FillByConcluidos(this.manutencaoDataSet.Manutencao);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByConcluidosToolStrip_ItemClicked (object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
