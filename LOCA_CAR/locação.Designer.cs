namespace LOCA_CAR
{
    partial class locação
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label id_veiculoLabel;
            System.Windows.Forms.Label situaçãoLabel;
            System.Windows.Forms.Label valorLabel1;
            System.Windows.Forms.Label descontoLabel;
            System.Windows.Forms.Label valor_pagoLabel;
            System.Windows.Forms.Label códigoSatusLabel;
            System.Windows.Forms.Label dataDevoluçãoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.locaçãoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_clienteComboBox = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.dataDevoluçãoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.códigoSatusComboBox = new System.Windows.Forms.ComboBox();
            this.statusPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.itensLocaçãoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensLocaçãoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.situaçãoComboBox = new System.Windows.Forms.ComboBox();
            this.veiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.situacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.id_veiculoComboBox = new System.Windows.Forms.ComboBox();
            id_clienteLabel = new System.Windows.Forms.Label();
            id_veiculoLabel = new System.Windows.Forms.Label();
            situaçãoLabel = new System.Windows.Forms.Label();
            valorLabel1 = new System.Windows.Forms.Label();
            descontoLabel = new System.Windows.Forms.Label();
            valor_pagoLabel = new System.Windows.Forms.Label();
            códigoSatusLabel = new System.Windows.Forms.Label();
            dataDevoluçãoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.locaçãoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensLocaçãoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensLocaçãoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.situacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_clienteLabel.Location = new System.Drawing.Point(170, 40);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(49, 16);
            id_clienteLabel.TabIndex = 1;
            id_clienteLabel.Text = "Cliente";
            // 
            // id_veiculoLabel
            // 
            id_veiculoLabel.AutoSize = true;
            id_veiculoLabel.Location = new System.Drawing.Point(34, 26);
            id_veiculoLabel.Name = "id_veiculoLabel";
            id_veiculoLabel.Size = new System.Drawing.Size(86, 13);
            id_veiculoLabel.TabIndex = 8;
            id_veiculoLabel.Text = "Veiculo Modelo :";
            // 
            // situaçãoLabel
            // 
            situaçãoLabel.AutoSize = true;
            situaçãoLabel.Location = new System.Drawing.Point(440, 21);
            situaçãoLabel.Name = "situaçãoLabel";
            situaçãoLabel.Size = new System.Drawing.Size(52, 13);
            situaçãoLabel.TabIndex = 16;
            situaçãoLabel.Text = "Situação:";
            // 
            // valorLabel1
            // 
            valorLabel1.AutoSize = true;
            valorLabel1.Location = new System.Drawing.Point(251, 323);
            valorLabel1.Name = "valorLabel1";
            valorLabel1.Size = new System.Drawing.Size(34, 13);
            valorLabel1.TabIndex = 18;
            valorLabel1.Text = "Valor:";
            // 
            // descontoLabel
            // 
            descontoLabel.AutoSize = true;
            descontoLabel.Location = new System.Drawing.Point(229, 369);
            descontoLabel.Name = "descontoLabel";
            descontoLabel.Size = new System.Drawing.Size(56, 13);
            descontoLabel.TabIndex = 20;
            descontoLabel.Text = "Desconto:";
            // 
            // valor_pagoLabel
            // 
            valor_pagoLabel.AutoSize = true;
            valor_pagoLabel.Location = new System.Drawing.Point(224, 411);
            valor_pagoLabel.Name = "valor_pagoLabel";
            valor_pagoLabel.Size = new System.Drawing.Size(61, 13);
            valor_pagoLabel.TabIndex = 22;
            valor_pagoLabel.Text = "Valor Total:";
            // 
            // códigoSatusLabel
            // 
            códigoSatusLabel.AutoSize = true;
            códigoSatusLabel.Location = new System.Drawing.Point(726, 318);
            códigoSatusLabel.Name = "códigoSatusLabel";
            códigoSatusLabel.Size = new System.Drawing.Size(111, 13);
            códigoSatusLabel.TabIndex = 28;
            códigoSatusLabel.Text = "Forma de Pagamento:";
            códigoSatusLabel.Click += new System.EventHandler(this.códigoSatusLabel_Click);
            // 
            // dataDevoluçãoLabel
            // 
            dataDevoluçãoLabel.AutoSize = true;
            dataDevoluçãoLabel.Location = new System.Drawing.Point(749, 373);
            dataDevoluçãoLabel.Name = "dataDevoluçãoLabel";
            dataDevoluçãoLabel.Size = new System.Drawing.Size(88, 13);
            dataDevoluçãoLabel.TabIndex = 29;
            dataDevoluçãoLabel.Text = "Data Devolução:";
            dataDevoluçãoLabel.Click += new System.EventHandler(this.dataDevoluçãoLabel_Click);
            // 
            // locaçãoBindingSource
            // 
            this.locaçãoBindingSource.DataSource = typeof(sistema.DAL.Locação);
            // 
            // id_clienteComboBox
            // 
            this.id_clienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.locaçãoBindingSource, "id_cliente", true));
            this.id_clienteComboBox.DataSource = this.clienteBindingSource;
            this.id_clienteComboBox.DisplayMember = "nome";
            this.id_clienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_clienteComboBox.FormattingEnabled = true;
            this.id_clienteComboBox.Location = new System.Drawing.Point(239, 40);
            this.id_clienteComboBox.Name = "id_clienteComboBox";
            this.id_clienteComboBox.Size = new System.Drawing.Size(220, 21);
            this.id_clienteComboBox.TabIndex = 2;
            this.id_clienteComboBox.ValueMember = "Código";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(sistema.DAL.Cliente);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nova Locação";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(dataDevoluçãoLabel);
            this.groupBox1.Controls.Add(this.dataDevoluçãoDateTimePicker);
            this.groupBox1.Controls.Add(códigoSatusLabel);
            this.groupBox1.Controls.Add(this.códigoSatusComboBox);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(valor_pagoLabel);
            this.groupBox1.Controls.Add(descontoLabel);
            this.groupBox1.Controls.Add(valorLabel1);
            this.groupBox1.Controls.Add(this.itensLocaçãoDataGridView);
            this.groupBox1.Controls.Add(this.situaçãoComboBox);
            this.groupBox1.Controls.Add(situaçãoLabel);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(id_veiculoLabel);
            this.groupBox1.Controls.Add(this.id_veiculoComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1310, 503);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova Locação";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(843, 423);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 23);
            this.button6.TabIndex = 31;
            this.button6.Text = "Finalizar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataDevoluçãoDateTimePicker
            // 
            this.dataDevoluçãoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasReceberBindingSource, "DataDevolução", true));
            this.dataDevoluçãoDateTimePicker.Enabled = false;
            this.dataDevoluçãoDateTimePicker.Location = new System.Drawing.Point(843, 373);
            this.dataDevoluçãoDateTimePicker.Name = "dataDevoluçãoDateTimePicker";
            this.dataDevoluçãoDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.dataDevoluçãoDateTimePicker.TabIndex = 30;
            this.dataDevoluçãoDateTimePicker.ValueChanged += new System.EventHandler(this.dataDevoluçãoDateTimePicker_ValueChanged);
            // 
            // contasReceberBindingSource
            // 
            this.contasReceberBindingSource.DataSource = typeof(sistema.DAL.ContasReceber);
            // 
            // códigoSatusComboBox
            // 
            this.códigoSatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contasReceberBindingSource, "CódigoSatus", true));
            this.códigoSatusComboBox.DataSource = this.statusPagamentoBindingSource;
            this.códigoSatusComboBox.DisplayMember = "Status";
            this.códigoSatusComboBox.Enabled = false;
            this.códigoSatusComboBox.FormattingEnabled = true;
            this.códigoSatusComboBox.Location = new System.Drawing.Point(843, 315);
            this.códigoSatusComboBox.Name = "códigoSatusComboBox";
            this.códigoSatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.códigoSatusComboBox.TabIndex = 29;
            this.códigoSatusComboBox.ValueMember = "CódigoStatus";
            this.códigoSatusComboBox.SelectedIndexChanged += new System.EventHandler(this.códigoSatusComboBox_SelectedIndexChanged);
            // 
            // statusPagamentoBindingSource
            // 
            this.statusPagamentoBindingSource.DataSource = typeof(sistema.DAL.StatusPagamento);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(66, 359);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Finalizar Locação";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(66, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Finalizar Pedido";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locaçãoBindingSource, "valor_pago", true));
            this.textBox3.Location = new System.Drawing.Point(291, 408);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locaçãoBindingSource, "desconto", true));
            this.textBox2.Location = new System.Drawing.Point(291, 366);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locaçãoBindingSource, "valor", true));
            this.textBox1.Location = new System.Drawing.Point(291, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 23;
            // 
            // itensLocaçãoDataGridView
            // 
            this.itensLocaçãoDataGridView.AllowUserToAddRows = false;
            this.itensLocaçãoDataGridView.AllowUserToDeleteRows = false;
            this.itensLocaçãoDataGridView.AutoGenerateColumns = false;
            this.itensLocaçãoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itensLocaçãoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn11,
            this.fabricante,
            this.ano,
            this.placa,
            this.cor,
            this.situação,
            this.dataGridViewTextBoxColumn8,
            this.Column1});
            this.itensLocaçãoDataGridView.DataSource = this.itensLocaçãoBindingSource1;
            this.itensLocaçãoDataGridView.Location = new System.Drawing.Point(6, 71);
            this.itensLocaçãoDataGridView.Name = "itensLocaçãoDataGridView";
            this.itensLocaçãoDataGridView.ReadOnly = true;
            this.itensLocaçãoDataGridView.Size = new System.Drawing.Size(1255, 220);
            this.itensLocaçãoDataGridView.TabIndex = 18;
            this.itensLocaçãoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itensLocaçãoDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_locação";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cód Locação";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 130;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "modelo";
            this.dataGridViewTextBoxColumn11.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 120;
            // 
            // fabricante
            // 
            this.fabricante.DataPropertyName = "fabricante";
            this.fabricante.HeaderText = "Fabricante";
            this.fabricante.Name = "fabricante";
            this.fabricante.ReadOnly = true;
            this.fabricante.Width = 120;
            // 
            // ano
            // 
            this.ano.DataPropertyName = "ano";
            this.ano.HeaderText = "Ano";
            this.ano.Name = "ano";
            this.ano.ReadOnly = true;
            this.ano.Width = 120;
            // 
            // placa
            // 
            this.placa.DataPropertyName = "placa";
            this.placa.HeaderText = "Placa";
            this.placa.Name = "placa";
            this.placa.ReadOnly = true;
            this.placa.Width = 140;
            // 
            // cor
            // 
            this.cor.DataPropertyName = "cor";
            this.cor.HeaderText = "Cor";
            this.cor.Name = "cor";
            this.cor.ReadOnly = true;
            this.cor.Width = 120;
            // 
            // situação
            // 
            this.situação.DataPropertyName = "situação";
            this.situação.HeaderText = "Situação";
            this.situação.Name = "situação";
            this.situação.ReadOnly = true;
            this.situação.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "valor";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn8.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 130;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Valor Total";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // itensLocaçãoBindingSource1
            // 
            this.itensLocaçãoBindingSource1.DataSource = typeof(sistema.DAL.ItensLocação);
            // 
            // situaçãoComboBox
            // 
            this.situaçãoComboBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.situaçãoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.veiculoBindingSource, "situação", true));
            this.situaçãoComboBox.DataSource = this.situacaoBindingSource;
            this.situaçãoComboBox.DisplayMember = "codigo";
            this.situaçãoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.situaçãoComboBox.FormattingEnabled = true;
            this.situaçãoComboBox.Location = new System.Drawing.Point(510, 18);
            this.situaçãoComboBox.Name = "situaçãoComboBox";
            this.situaçãoComboBox.Size = new System.Drawing.Size(150, 21);
            this.situaçãoComboBox.TabIndex = 18;
            this.situaçãoComboBox.ValueMember = "situação";
            this.situaçãoComboBox.SelectedIndexChanged += new System.EventHandler(this.situaçãoComboBox_SelectedIndexChanged);
            // 
            // veiculoBindingSource
            // 
            this.veiculoBindingSource.DataSource = typeof(sistema.DAL.Veiculo);
            // 
            // situacaoBindingSource
            // 
            this.situacaoBindingSource.DataSource = typeof(sistema.DAL.Situacao);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(729, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "Nova Item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // id_veiculoComboBox
            // 
            this.id_veiculoComboBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.id_veiculoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itensLocaçãoBindingSource1, "modelo", true));
            this.id_veiculoComboBox.DataSource = this.veiculoBindingSource;
            this.id_veiculoComboBox.DisplayMember = "modelo";
            this.id_veiculoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_veiculoComboBox.FormattingEnabled = true;
            this.id_veiculoComboBox.Location = new System.Drawing.Point(147, 25);
            this.id_veiculoComboBox.Name = "id_veiculoComboBox";
            this.id_veiculoComboBox.Size = new System.Drawing.Size(150, 21);
            this.id_veiculoComboBox.TabIndex = 9;
            this.id_veiculoComboBox.ValueMember = "Código";
            this.id_veiculoComboBox.SelectedIndexChanged += new System.EventHandler(this.id_veiculoComboBox_SelectedIndexChanged);
            // 
            // locação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1334, 575);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(this.id_clienteComboBox);
            this.Name = "locação";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Locação";
            this.Load += new System.EventHandler(this.locação_Load);
            ((System.ComponentModel.ISupportInitialize)(this.locaçãoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensLocaçãoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensLocaçãoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.situacaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource locaçãoBindingSource;
        private System.Windows.Forms.ComboBox id_clienteComboBox;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox id_veiculoComboBox;
        private System.Windows.Forms.BindingSource veiculoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox situaçãoComboBox;
        private System.Windows.Forms.BindingSource situacaoBindingSource;
        private System.Windows.Forms.BindingSource itensLocaçãoBindingSource1;
        private System.Windows.Forms.DataGridView itensLocaçãoDataGridView;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox códigoSatusComboBox;
        private System.Windows.Forms.BindingSource contasReceberBindingSource;
        private System.Windows.Forms.DateTimePicker dataDevoluçãoDateTimePicker;
        private System.Windows.Forms.BindingSource statusPagamentoBindingSource;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn situação;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}