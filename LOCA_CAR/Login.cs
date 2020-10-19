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
    public partial class Login : Form
    {
        public bool logado = false;
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EfetuarLogin()
        {
            var user = DataContextFactory.DataContext.tb_usuario.Count(
                x => x.usuario == usuarioTextBox.Text && x.senha == senhaTextBox.Text  );

                if (user > 0)
                {
                    Principal frmp = new Principal();
                    frmp.Show();
                    this.Visible = false;
                    /*this.logado = true;
                    this.Dispose();*/
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos");
                }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {

            EfetuarLogin();
           
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
