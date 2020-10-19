namespace LOCA_CAR
{
    partial class CadastroLogin
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
            System.Windows.Forms.Label id_usuarioLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label acessoLabel;
            this.id_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acessoComboBox = new System.Windows.Forms.ComboBox();
            id_usuarioLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            acessoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_usuarioLabel
            // 
            id_usuarioLabel.AutoSize = true;
            id_usuarioLabel.Location = new System.Drawing.Point(50, 35);
            id_usuarioLabel.Name = "id_usuarioLabel";
            id_usuarioLabel.Size = new System.Drawing.Size(21, 13);
            id_usuarioLabel.TabIndex = 1;
            id_usuarioLabel.Text = "ID:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(485, 35);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(41, 13);
            senhaLabel.TabIndex = 3;
            senhaLabel.Text = "Senha:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(245, 34);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(70, 13);
            usuarioLabel.TabIndex = 5;
            usuarioLabel.Text = "Nome Login :";
            usuarioLabel.Click += new System.EventHandler(this.usuarioLabel_Click);
            // 
            // acessoLabel
            // 
            acessoLabel.AutoSize = true;
            acessoLabel.Location = new System.Drawing.Point(686, 37);
            acessoLabel.Name = "acessoLabel";
            acessoLabel.Size = new System.Drawing.Size(45, 13);
            acessoLabel.TabIndex = 34;
            acessoLabel.Text = "Acesso:";
            // 
            // id_usuarioTextBox
            // 
            this.id_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "id_usuario", true));
            this.id_usuarioTextBox.Location = new System.Drawing.Point(96, 32);
            this.id_usuarioTextBox.Name = "id_usuarioTextBox";
            this.id_usuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_usuarioTextBox.TabIndex = 2;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(532, 31);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(100, 20);
            this.senhaTextBox.TabIndex = 4;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "usuario", true));
            this.usuarioTextBox.Location = new System.Drawing.Point(321, 31);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.usuarioTextBox.TabIndex = 6;
            this.usuarioTextBox.TextChanged += new System.EventHandler(this.usuarioTextBox_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(532, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 33;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(414, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_usuarioBindingSource
            // 
            this.tb_usuarioBindingSource.DataSource = typeof(sistema.DAL.tb_usuario);
            // 
            // tb_usuarioDataGridView
            // 
            this.tb_usuarioDataGridView.AllowUserToAddRows = false;
            this.tb_usuarioDataGridView.AllowUserToDeleteRows = false;
            this.tb_usuarioDataGridView.AutoGenerateColumns = false;
            this.tb_usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.tb_usuarioDataGridView.DataSource = this.tb_usuarioBindingSource;
            this.tb_usuarioDataGridView.Location = new System.Drawing.Point(66, 157);
            this.tb_usuarioDataGridView.Name = "tb_usuarioDataGridView";
            this.tb_usuarioDataGridView.ReadOnly = true;
            this.tb_usuarioDataGridView.Size = new System.Drawing.Size(743, 220);
            this.tb_usuarioDataGridView.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_usuario";
            this.dataGridViewTextBoxColumn3.HeaderText = "Código Usuario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "usuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "senha";
            this.dataGridViewTextBoxColumn2.HeaderText = "Senha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Acesso";
            this.dataGridViewTextBoxColumn4.HeaderText = "Acesso";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // acessoComboBox
            // 
            this.acessoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "Acesso", true));
            this.acessoComboBox.FormattingEnabled = true;
            this.acessoComboBox.Items.AddRange(new object[] {
            "Gerente",
            "Funcionario"});
            this.acessoComboBox.Location = new System.Drawing.Point(737, 34);
            this.acessoComboBox.Name = "acessoComboBox";
            this.acessoComboBox.Size = new System.Drawing.Size(121, 21);
            this.acessoComboBox.TabIndex = 35;
            // 
            // CadastroLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(941, 498);
            this.Controls.Add(acessoLabel);
            this.Controls.Add(this.acessoComboBox);
            this.Controls.Add(this.tb_usuarioDataGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(id_usuarioLabel);
            this.Controls.Add(this.id_usuarioTextBox);
            this.Name = "CadastroLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Login";
            this.Load += new System.EventHandler(this.CadastroLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox id_usuarioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tb_usuarioBindingSource;
        private System.Windows.Forms.DataGridView tb_usuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox acessoComboBox;
    }
}