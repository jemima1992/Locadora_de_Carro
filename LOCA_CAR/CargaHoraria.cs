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
    public partial class CargaHoraria : Form
    {
        public CargaHoraria()
        {
            InitializeComponent();
        }

        private void CargaHoraria_Load(object sender, EventArgs e)
        {
            this.carga_HorariaBindingSource.DataSource = DataContextFactory.DataContext.Carga_Horaria;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.carga_HorariaBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {
                this.carga_HorariaBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Carga Horaria  Inserida com Sucesso");
            }
        }
        private bool valida()
        {
            if (cargaHorariaTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Descrição Carga Horaria é obrigatorio");
                cargaHorariaTextBox.Focus();
                return false;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.carga_HorariaBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Carga Horaria Excluida com sucesso");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.carga_HorariaBindingSource.CancelEdit();
        }
    }
    
}
