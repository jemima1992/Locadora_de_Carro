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
    public partial class ControleHorario : Form
    {
        public ControleHorario()
        {
            InitializeComponent();
        }

        private void dataDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ControleHorario_Load(object sender, EventArgs e)
        {
            this.funcionarioBindingSource.DataSource = DataContextFactory.DataContext.Funcionario;
            this.controleHorarioBindingSource.DataSource = DataContextFactory.DataContext.ControleHorario;
            this.carga_HorariaBindingSource.DataSource = DataContextFactory.DataContext.Carga_Horaria;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.controleHorarioBindingSource.CancelEdit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.controleHorarioBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                controleHorarioDataGridView.Refresh();
                MessageBox.Show("Horario Excluida com sucesso");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {
                this.controleHorarioBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Funcionario Inserida com Sucesso");
            }
        }
        private bool valida()
        {
            if (mêsTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Mês é obrigatorio");
                mêsTextBox.Focus();
                return false;
            }
            if (nomeComboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Nome é obrigatorio");
                nomeComboBox.Focus();
                return false;
            }
            if (cargaHorariaComboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Carga horaria é obrigatorio");
                cargaHorariaComboBox.Focus();
                return false;
            }
            if (entradaTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Entrada é obrigatorio");
                entradaTextBox.Focus();
                return false;
            }
            if (saidaTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Saída é obrigatorio");
                saidaTextBox.Focus();
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.controleHorarioBindingSource.AddNew();
        }
    }
}
