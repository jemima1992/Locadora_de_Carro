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
    public partial class CadastroLogin : Form
    {
        public CadastroLogin()
        {
            InitializeComponent();
        }

        private void usuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void usuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tb_usuarioBindingSource.AddNew();
        }

        private void CadastroLogin_Load(object sender, EventArgs e)
        {
            this.tb_usuarioBindingSource.DataSource = DataContextFactory.DataContext.tb_usuario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {
                this.tb_usuarioBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Cliente Inserida com Sucesso");
            }
        
        }
        private bool valida()
        {
            if (id_usuarioTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo ID é obrigatorio");
                id_usuarioTextBox.Focus();
                return false;
            }
            if (usuarioTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Nome Login é obrigatorio");
                usuarioTextBox.Focus();
                return false;
            }
            if (senhaTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Senha é obrigatorio");
                senhaTextBox.Focus();
                return false;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.tb_usuarioBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                tb_usuarioDataGridView.Refresh();
                MessageBox.Show("Veiculo Excluida com sucesso");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tb_usuarioBindingSource.CancelEdit();
        }
    }
}
