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
    public partial class ItensAlocados : Form
    {
        public ItensAlocados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Pesquisar((string)modeloComboBox.SelectedValue);
        }

        private void ItensAlocados_Load(object sender, EventArgs e)
        {;
            this.itensLocaçãoBindingSource.DataSource = DataContextFactory.DataContext.ItensLocação;
        }
        public void Pesquisar(string Locação)
        {
            this.itensLocaçãoBindingSource.DataSource = DataContextFactory.DataContext.ItensLocação.Where(x => x.modelo  == Locação);
        }
    }
}
