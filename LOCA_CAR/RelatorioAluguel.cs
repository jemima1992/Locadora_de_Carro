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
    public partial class RelatorioAluguel : Form
    {
        public RelatorioAluguel()
        {
            InitializeComponent();
        }

        private void RelatorioAluguel_Load(object sender, EventArgs e)
        {

        }

        private void RelatorioAluguel_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'Loca_CarDataSet.tb_locação'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_locaçãoTableAdapter.Fill(this.Loca_CarDataSet.tb_locação);

            this.reportViewer1.RefreshReport();
        }
    }
}
