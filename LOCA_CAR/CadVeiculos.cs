using sistema.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOCA_CAR
{
    public partial class CadVeiculos : Form
    {
        public CadVeiculos()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CadVeiculos_Load(object sender, EventArgs e)
        {
            this.veiculoBindingSource.DataSource = DataContextFactory.DataContext.Veiculo;
            this.situacaoBindingSource1.DataSource = DataContextFactory.DataContext.Situacao;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.veiculoBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {
                this.veiculoBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Cliente Inserida com Sucesso");
            }
        }
        private bool valida()
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Fabricante é obrigatorio");
                textBox1.Focus();
                return false;
            }

            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.veiculoBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Veiculo Excluida com sucesso");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.veiculoBindingSource.CancelEdit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Pesquisar((int)comboBox1.SelectedValue);
        }

        public void Pesquisar(int codigoVeiculo)
        {
            this.veiculoBindingSource.DataSource = DataContextFactory.DataContext.Veiculo.Where(x => x.Código == codigoVeiculo);
        }
    }
}
