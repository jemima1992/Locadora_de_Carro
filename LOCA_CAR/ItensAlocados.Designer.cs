namespace LOCA_CAR
{
    partial class ItensAlocados
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
            System.Windows.Forms.Label modeloLabel;
            this.contasReceberDataGridView = new System.Windows.Forms.DataGridView();
            this.iditemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idveiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlocaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensLocaçãoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.modeloComboBox = new System.Windows.Forms.ComboBox();
            modeloLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensLocaçãoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contasReceberDataGridView
            // 
            this.contasReceberDataGridView.AllowUserToAddRows = false;
            this.contasReceberDataGridView.AllowUserToDeleteRows = false;
            this.contasReceberDataGridView.AutoGenerateColumns = false;
            this.contasReceberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contasReceberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iditemDataGridViewTextBoxColumn,
            this.idveiculoDataGridViewTextBoxColumn,
            this.idlocaçãoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.situaçãoDataGridViewTextBoxColumn,
            this.fabricanteDataGridViewTextBoxColumn,
            this.anoDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.corDataGridViewTextBoxColumn});
            this.contasReceberDataGridView.DataSource = this.itensLocaçãoBindingSource;
            this.contasReceberDataGridView.Location = new System.Drawing.Point(128, 105);
            this.contasReceberDataGridView.Name = "contasReceberDataGridView";
            this.contasReceberDataGridView.ReadOnly = true;
            this.contasReceberDataGridView.Size = new System.Drawing.Size(1043, 220);
            this.contasReceberDataGridView.TabIndex = 11;
            // 
            // iditemDataGridViewTextBoxColumn
            // 
            this.iditemDataGridViewTextBoxColumn.DataPropertyName = "id_item";
            this.iditemDataGridViewTextBoxColumn.HeaderText = "ID Item";
            this.iditemDataGridViewTextBoxColumn.Name = "iditemDataGridViewTextBoxColumn";
            this.iditemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idveiculoDataGridViewTextBoxColumn
            // 
            this.idveiculoDataGridViewTextBoxColumn.DataPropertyName = "id_veiculo";
            this.idveiculoDataGridViewTextBoxColumn.HeaderText = "ID Veiculo";
            this.idveiculoDataGridViewTextBoxColumn.Name = "idveiculoDataGridViewTextBoxColumn";
            this.idveiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idlocaçãoDataGridViewTextBoxColumn
            // 
            this.idlocaçãoDataGridViewTextBoxColumn.DataPropertyName = "id_locação";
            this.idlocaçãoDataGridViewTextBoxColumn.HeaderText = "ID Locação";
            this.idlocaçãoDataGridViewTextBoxColumn.Name = "idlocaçãoDataGridViewTextBoxColumn";
            this.idlocaçãoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // situaçãoDataGridViewTextBoxColumn
            // 
            this.situaçãoDataGridViewTextBoxColumn.DataPropertyName = "situação";
            this.situaçãoDataGridViewTextBoxColumn.HeaderText = "Situação";
            this.situaçãoDataGridViewTextBoxColumn.Name = "situaçãoDataGridViewTextBoxColumn";
            this.situaçãoDataGridViewTextBoxColumn.ReadOnly = true;
            this.situaçãoDataGridViewTextBoxColumn.Width = 200;
            // 
            // fabricanteDataGridViewTextBoxColumn
            // 
            this.fabricanteDataGridViewTextBoxColumn.DataPropertyName = "fabricante";
            this.fabricanteDataGridViewTextBoxColumn.HeaderText = "Fabricante";
            this.fabricanteDataGridViewTextBoxColumn.Name = "fabricanteDataGridViewTextBoxColumn";
            this.fabricanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anoDataGridViewTextBoxColumn
            // 
            this.anoDataGridViewTextBoxColumn.DataPropertyName = "ano";
            this.anoDataGridViewTextBoxColumn.HeaderText = "Ano";
            this.anoDataGridViewTextBoxColumn.Name = "anoDataGridViewTextBoxColumn";
            this.anoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            this.placaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // corDataGridViewTextBoxColumn
            // 
            this.corDataGridViewTextBoxColumn.DataPropertyName = "cor";
            this.corDataGridViewTextBoxColumn.HeaderText = "Cor";
            this.corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
            this.corDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itensLocaçãoBindingSource
            // 
            this.itensLocaçãoBindingSource.DataSource = typeof(sistema.DAL.ItensLocação);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(159, 40);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(45, 13);
            modeloLabel.TabIndex = 13;
            modeloLabel.Text = "Modelo:";
            // 
            // modeloComboBox
            // 
            this.modeloComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensLocaçãoBindingSource, "modelo", true));
            this.modeloComboBox.DataSource = this.itensLocaçãoBindingSource;
            this.modeloComboBox.DisplayMember = "modelo";
            this.modeloComboBox.FormattingEnabled = true;
            this.modeloComboBox.Location = new System.Drawing.Point(221, 37);
            this.modeloComboBox.Name = "modeloComboBox";
            this.modeloComboBox.Size = new System.Drawing.Size(313, 21);
            this.modeloComboBox.TabIndex = 14;
            this.modeloComboBox.ValueMember = "situação";
            // 
            // ItensAlocados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1191, 450);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contasReceberDataGridView);
            this.Name = "ItensAlocados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItensAlocados";
            this.Load += new System.EventHandler(this.ItensAlocados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensLocaçãoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView contasReceberDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource itensLocaçãoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iditemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idveiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlocaçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situaçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox modeloComboBox;
    }
}