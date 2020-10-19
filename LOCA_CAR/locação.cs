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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace LOCA_CAR
{
    public partial class locação : Form
    {
        public locação()
        {
            InitializeComponent();
        }

        private void locação_Load(object sender, EventArgs e)
        {
            this.Size = new Size(874, 118);
            this.clienteBindingSource.DataSource = DataContextFactory.DataContext.Cliente;
            this.locaçãoBindingSource.DataSource = DataContextFactory.DataContext.Locação;
            this.veiculoBindingSource.DataSource = DataContextFactory.DataContext.Veiculo;
            this.itensLocaçãoBindingSource1.DataSource = DataContextFactory.DataContext.ItensLocação;
            this.situacaoBindingSource.DataSource = DataContextFactory.DataContext.Situacao;
            this.statusPagamentoBindingSource.DataSource = DataContextFactory.DataContext.StatusPagamento;
            this.contasReceberBindingSource.DataSource = DataContextFactory.DataContext.ContasReceber;
            
            this.locaçãoBindingSource.AddNew();
        }

        public Locação LocaçãoCorrente
        {
            get
            {
                return (Locação)this.locaçãoBindingSource.Current;
            }
        }

        public ItensLocação ItemCorrente
        {
            get
            {
                return (ItensLocação)this.itensLocaçãoBindingSource1.Current;
            }
        }
        public ContasReceber ContaCorrente
        {
            get
            {
                return (ContasReceber)this.contasReceberBindingSource.Current;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1350,676);
            this.locaçãoBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            groupBox1.Visible = true;
            button1.Enabled = false;

            this.itensLocaçãoBindingSource1.DataSource = DataContextFactory.DataContext.ItensLocação.Where(x => x.id_veiculo == this.LocaçãoCorrente.id_locação);
            Novoitem();
            id_clienteComboBox.Enabled = false;
        }

        private void Novoitem()
        {
            this.itensLocaçãoBindingSource1.AddNew();
            this.ItemCorrente.id_locação = this.LocaçãoCorrente.id_locação;
            this.ItemCorrente.quantidade = 1 ;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.itensLocaçãoBindingSource1.EndEdit();
            itensLocaçãoDataGridView.Refresh();
            DataContextFactory.DataContext.SubmitChanges();
            MostraSomaValores();
            Novoitem();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void situaçãoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void itensLocaçãoDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
                e.Value = ((Veiculo)e.Value).modelo;



        }

        private void id_veiculoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (id_veiculoComboBox.SelectedItem != null)
            {
                var pro = (Veiculo)id_veiculoComboBox.SelectedItem;
                this.ItemCorrente.id_veiculo = (int)pro.Código;
                this.ItemCorrente.valor = (decimal)pro.valor;
                this.ItemCorrente.modelo = (string)pro.modelo;
                this.ItemCorrente.fabricante = (string)pro.fabricante;
                this.ItemCorrente.ano = (decimal)pro.ano;
                this.ItemCorrente.situação = (string)pro.situação;
                this.ItemCorrente.placa = (string)pro.placa;
                this.ItemCorrente.cor = (string)pro.cor;
                
            }
        }
        private void MostraSomaValores()
        {
            decimal total = 0 ;
            foreach (DataGridViewRow dg in itensLocaçãoDataGridView.Rows)
            {
                decimal v1 = Convert.ToDecimal(dg.Cells[7].Value);
                decimal subtotal = v1 ;
                dg.Cells[8].Value = subtotal;
                total = total + subtotal;
            }
            this.LocaçãoCorrente.valor = total;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar o pedido ", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.itensLocaçãoBindingSource1.CancelEdit();
                DataContextFactory.DataContext.SubmitChanges();
                this.LocaçãoCorrente.desconto = 0;
                button2.Enabled = false;
                id_clienteComboBox.Enabled = false;
                situaçãoComboBox.Enabled = false;    
                textBox2.ReadOnly = false;
                textBox2.Focus();
                button3.Enabled = false;
                button4.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.LocaçãoCorrente.desconto = Convert.ToDecimal(textBox2.Text);
            this.LocaçãoCorrente.valor_pago = (decimal)(this.LocaçãoCorrente.valor - this.LocaçãoCorrente.desconto);
            this.locaçãoBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            textBox2.Enabled = false;
            button4.Enabled = false;
            
            códigoSatusComboBox.Enabled = true;
            this.contasReceberBindingSource.AddNew();
            this.ContaCorrente.id_locação = this.LocaçãoCorrente.id_locação;
            this.ContaCorrente.DataLocação = DateTime.Now;
            this.ContaCorrente.DataDevolução = DateTime.Now;

        }

        private void códigoSatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataDevoluçãoLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataDevoluçãoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void códigoSatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (códigoSatusComboBox.SelectedItem != null)
            {

                var status = (StatusPagamento)códigoSatusComboBox.SelectedItem;
                if (status.CódigoStatus == 1)
                {
                    this.ContaCorrente.CódigoSatus = (int)status.CódigoStatus;
                    this.ContaCorrente.DataDevolução = DateTime.Now;
                    button6.Enabled = true;
                    dataDevoluçãoDateTimePicker.Enabled = true;
                }
                else if (status.CódigoStatus == 2)
                {
                    this.ContaCorrente.CódigoSatus = (int)status.CódigoStatus;
                    this.ContaCorrente.DataDevolução = DateTime.Now;
                    dataDevoluçãoDateTimePicker.Enabled = true;
                    button6.Enabled = true;
                    dataDevoluçãoDateTimePicker.Enabled = true;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.contasReceberBindingSource.EndEdit();
            dataDevoluçãoDateTimePicker.Enabled = false;
            button6.Enabled = false;
            códigoSatusComboBox.Enabled = false;
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Locação finalizada com sucesso");
        }

        private void itensLocaçãoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
