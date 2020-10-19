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
    public partial class Cadfuncionarios : Form
    {
        public Cadfuncionarios()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.funcionarioBindingSource.AddNew();
        }

        private void Cadfuncionario_Load(object sender, EventArgs e)
        {
            this.funcionarioBindingSource.DataSource = DataContextFactory.DataContext.Funcionario;
            this.carga_HorariaBindingSource.DataSource = DataContextFactory.DataContext.Carga_Horaria;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {
                this.funcionarioBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Funcionario Inserida com Sucesso");
            }
        }

        private bool valida()
        {
            if (nomeTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Nome é obrigatorio");
                nomeTextBox.Focus();
                return false;
            }
            if (enderecoTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Endereço é obrigatorio");
                enderecoTextBox.Focus();
                return false;
            }
            if (telefoneTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Telefone é obrigatorio");
                telefoneTextBox.Focus();
                return false;
            }
            if (datadeNascimentoDateTimePicker.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Data de Nascimento é obrigatorio");
                datadeNascimentoDateTimePicker.Focus();
                return false;
            }
            if (salarioTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Salario é obrigatorio");
                salarioTextBox.Focus();
                return false;
            }
            if (situacaoComboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Situação é obrigatorio");
                situacaoComboBox.Focus();
                return false;
            }
            if (funcaoTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo função é obrigatorio");
                funcaoTextBox.Focus();
                return false;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.funcionarioBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                funcionarioDataGridView.Refresh();
                MessageBox.Show("Funcionario Excluida com sucesso");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.funcionarioBindingSource.CancelEdit();
        }

        private void funcionarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datadeNascimentoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Pesquisar((int)nomeComboBox.SelectedValue);
        }
        public void Pesquisar(int codigo)
        {
            this.funcionarioBindingSource.DataSource = DataContextFactory.DataContext.Funcionario.Where(x => x.ID_Funcionario == codigo);
        }

        private void situacaoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void funcionarioDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void horarioEntradaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void horarioEntradaLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
