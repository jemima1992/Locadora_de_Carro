namespace LOCA_CAR
{
    partial class ConsultaDevolução
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
            System.Windows.Forms.Label dataDevoluçãoLabel;
            this.contasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contasReceberDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataDevoluçãoComboBox = new System.Windows.Forms.ComboBox();
            dataDevoluçãoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contasReceberBindingSource
            // 
            this.contasReceberBindingSource.DataSource = typeof(sistema.DAL.ContasReceber);
            // 
            // contasReceberDataGridView
            // 
            this.contasReceberDataGridView.AllowUserToAddRows = false;
            this.contasReceberDataGridView.AllowUserToDeleteRows = false;
            this.contasReceberDataGridView.AutoGenerateColumns = false;
            this.contasReceberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contasReceberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.contasReceberDataGridView.DataSource = this.contasReceberBindingSource;
            this.contasReceberDataGridView.Location = new System.Drawing.Point(40, 128);
            this.contasReceberDataGridView.Name = "contasReceberDataGridView";
            this.contasReceberDataGridView.ReadOnly = true;
            this.contasReceberDataGridView.Size = new System.Drawing.Size(844, 220);
            this.contasReceberDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CódigoConta";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Conta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DataLocação";
            this.dataGridViewTextBoxColumn2.HeaderText = "Data Locação";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DataDevolução";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data Devolução";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_locação";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID Locação";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CódigoSatus";
            this.dataGridViewTextBoxColumn6.HeaderText = "Forma de Pagamento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(707, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Forma de Pagamento \r\n1 - Dinehiro\r\n2 - Cartão\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataDevoluçãoComboBox
            // 
            this.dataDevoluçãoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "DataDevolução", true));
            this.dataDevoluçãoComboBox.DataSource = this.contasReceberBindingSource;
            this.dataDevoluçãoComboBox.DisplayMember = "DataDevolução";
            this.dataDevoluçãoComboBox.FormattingEnabled = true;
            this.dataDevoluçãoComboBox.Location = new System.Drawing.Point(164, 67);
            this.dataDevoluçãoComboBox.Name = "dataDevoluçãoComboBox";
            this.dataDevoluçãoComboBox.Size = new System.Drawing.Size(249, 21);
            this.dataDevoluçãoComboBox.TabIndex = 9;
            this.dataDevoluçãoComboBox.ValueMember = "DataDevolução";
            this.dataDevoluçãoComboBox.SelectedIndexChanged += new System.EventHandler(this.dataDevoluçãoComboBox_SelectedIndexChanged);
            // 
            // dataDevoluçãoLabel
            // 
            dataDevoluçãoLabel.AutoSize = true;
            dataDevoluçãoLabel.Location = new System.Drawing.Point(70, 75);
            dataDevoluçãoLabel.Name = "dataDevoluçãoLabel";
            dataDevoluçãoLabel.Size = new System.Drawing.Size(88, 13);
            dataDevoluçãoLabel.TabIndex = 8;
            dataDevoluçãoLabel.Text = "Data Devolução:";
            // 
            // ConsultaDevolução
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(924, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contasReceberDataGridView);
            this.Controls.Add(dataDevoluçãoLabel);
            this.Controls.Add(this.dataDevoluçãoComboBox);
            this.Controls.Add(this.button1);
            this.Name = "ConsultaDevolução";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Devolução";
            this.Load += new System.EventHandler(this.ConsultaLocação_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource contasReceberBindingSource;
        private System.Windows.Forms.DataGridView contasReceberDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox dataDevoluçãoComboBox;
    }
}