namespace LOCA_CAR
{
    partial class CargaHoraria
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
            System.Windows.Forms.Label cargaHorariaLabel;
            this.carga_HorariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carga_HorariaDataGridView = new System.Windows.Forms.DataGridView();
            this.cargaHorariaTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cargaHorariaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carga_HorariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carga_HorariaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // carga_HorariaBindingSource
            // 
            this.carga_HorariaBindingSource.DataSource = typeof(sistema.DAL.Carga_Horaria);
            // 
            // carga_HorariaDataGridView
            // 
            this.carga_HorariaDataGridView.AllowUserToAddRows = false;
            this.carga_HorariaDataGridView.AllowUserToDeleteRows = false;
            this.carga_HorariaDataGridView.AutoGenerateColumns = false;
            this.carga_HorariaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carga_HorariaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.carga_HorariaDataGridView.DataSource = this.carga_HorariaBindingSource;
            this.carga_HorariaDataGridView.Location = new System.Drawing.Point(80, 181);
            this.carga_HorariaDataGridView.Name = "carga_HorariaDataGridView";
            this.carga_HorariaDataGridView.ReadOnly = true;
            this.carga_HorariaDataGridView.Size = new System.Drawing.Size(464, 236);
            this.carga_HorariaDataGridView.TabIndex = 1;
            // 
            // cargaHorariaLabel
            // 
            cargaHorariaLabel.AutoSize = true;
            cargaHorariaLabel.Location = new System.Drawing.Point(56, 79);
            cargaHorariaLabel.Name = "cargaHorariaLabel";
            cargaHorariaLabel.Size = new System.Drawing.Size(126, 13);
            cargaHorariaLabel.TabIndex = 1;
            cargaHorariaLabel.Text = "Descrição Carga Horaria:";
            // 
            // cargaHorariaTextBox
            // 
            this.cargaHorariaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carga_HorariaBindingSource, "CargaHoraria", true));
            this.cargaHorariaTextBox.Location = new System.Drawing.Point(188, 76);
            this.cargaHorariaTextBox.Name = "cargaHorariaTextBox";
            this.cargaHorariaTextBox.Size = new System.Drawing.Size(269, 20);
            this.cargaHorariaTextBox.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(388, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 23);
            this.button4.TabIndex = 101;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(275, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 100;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 99;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 98;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_CargaHoraria";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CargaHoraria";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição  Carga Horaria";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // CargaHoraria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(cargaHorariaLabel);
            this.Controls.Add(this.cargaHorariaTextBox);
            this.Controls.Add(this.carga_HorariaDataGridView);
            this.Name = "CargaHoraria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CargaHoraria";
            this.Load += new System.EventHandler(this.CargaHoraria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carga_HorariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carga_HorariaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource carga_HorariaBindingSource;
        private System.Windows.Forms.DataGridView carga_HorariaDataGridView;
        private System.Windows.Forms.TextBox cargaHorariaTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}