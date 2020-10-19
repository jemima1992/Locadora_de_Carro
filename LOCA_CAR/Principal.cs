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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }

       
        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VeiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadVeiculos frmcl = new CadVeiculos();
            frmcl.Show();
        }

        private void LocátarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadCliente frm = new CadCliente();
            frm.Show();
        }

        

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void CategoriaCNHToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CategoriaCNH frmfunc = new CategoriaCNH();
            frmfunc.Show();
        }

        private void veiculosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void locaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            locação loca = new locação();
            loca.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroLogin cad = new CadastroLogin();
            cad.Show();
        }

        private void consultaLocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaDevolução cada = new ConsultaDevolução();
            cada.Show();
        }

      
        private void consultaLocaçãoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            ItensAlocados itens = new ItensAlocados();
            itens.Show();
        }

      
        private void funcionariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Cadfuncionarios fun = new Cadfuncionarios();
            fun.Show();

        }

        private void controleDeFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHorario fun = new ControleHorario();
            fun.Show();
        }

        private void relatoriosPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioAluguel fun = new RelatorioAluguel();
            fun.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void cargaHorariaFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargaHoraria fun = new CargaHoraria();
            fun.Show();
        }

        private void sairToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Login fo = new Login();
            fo.Show();
            this.Visible = false;
        }
    }
}
