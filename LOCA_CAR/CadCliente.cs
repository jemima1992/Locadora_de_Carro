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
    public partial class CadCliente : Form
    {
        public CadCliente()
        {
            InitializeComponent();
        }

        private void CadClientes_Load(object sender, EventArgs e)
        {
            this.clienteBindingSource.DataSource = DataContextFactory.DataContext.Cliente;
            this.categoriacnhBindingSource.DataSource = DataContextFactory.DataContext.Categoriacnh;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.clienteBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.clienteBindingSource.CancelEdit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                    
            }
            else
            {
                MessageBox.Show("Falta Campos para ser preenchidos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {
                this.clienteBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Cliente Inserida com Sucesso");
            }
        }
        private bool valida()
        {
            if (textBox1.Text.Trim() == string.Empty )
            {
                MessageBox.Show("O campo Nome é obrigatorio");
                textBox1.Focus();
                return false;
            }

            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.clienteBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Cliente Excluida com sucesso");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Pesquisar((int)comboBox1.SelectedValue);
        }
        public void Pesquisar(int codigoCliente)
        {
            this.clienteBindingSource.DataSource = DataContextFactory.DataContext.Cliente.Where(x => x.Código == codigoCliente);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
