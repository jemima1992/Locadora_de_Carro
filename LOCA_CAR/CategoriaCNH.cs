using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema.DAL;

namespace LOCA_CAR
{
    public partial class CategoriaCNH : Form
    {
        public CategoriaCNH()
        {
            InitializeComponent();
        }

        private void CategoriaCNH_Load(object sender, EventArgs e)
        {
            this.categoriacnhBindingSource.DataSource  = DataContextFactory.DataContext.Categoriacnh;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.categoriacnhBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {
                this.categoriacnhBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Categoria Inserida com Sucesso");
            }
           
        } 

        private bool valida()
        {
            if(textBox1.Text.Trim() == string.Empty && textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo categoria é obrigatorio");
                textBox1.Focus();
                textBox2.Focus();
                return false;
            }
            return true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                    this.categoriacnhBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Categoria Excluida com sucesso");
            }
        }

        private bool CategoriaPossuiProduto(CategoriaCNH categotiaAtual)
        {
            throw new NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.categoriacnhBindingSource.CancelEdit();
        }


        private bool CategoriaPossuiProduto(Categoriacnh categoria)
        {

            var clientes = DataContextFactory.DataContext.Cliente.Where(x => x.categoriacnh == categoria.CNH);
            if (clientes.Count() > 0)
                return true;
            else
                return false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
