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
    public partial class ConsultaDevolução : Form
    {
        public ConsultaDevolução()
        {
            InitializeComponent();
        }

        private void ConsultaLocação_Load(object sender, EventArgs e)
        {
            this.contasReceberBindingSource.DataSource = DataContextFactory.DataContext.ContasReceber;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Pesquisar((int)dataDevoluçãoComboBox.SelectedValue);
        }

        public void Pesquisar(int Locação)
        {
            this.contasReceberBindingSource.DataSource = DataContextFactory.DataContext.ContasReceber.Where(x => x.id_locação == Locação);
        }

        private void dataDevoluçãoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
