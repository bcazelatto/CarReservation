namespace InterdiciplinarFinal
{
    partial class AgendarCarro
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
            System.Windows.Forms.Label lblCarroDisponivel;
            System.Windows.Forms.Label lblNome;
            System.Windows.Forms.Label lblDataInicial;
            System.Windows.Forms.Label lblDataFinal;
            System.Windows.Forms.Label lblId;
            System.Windows.Forms.Label label1;
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.sistema_de_ReservaDataSet = new InterdiciplinarFinal.Sistema_de_ReservaDataSet();
            this.carrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrosTableAdapter = new InterdiciplinarFinal.Sistema_de_ReservaDataSet1TableAdapters.carrosTableAdapter();
            this.tableAdapterManager = new InterdiciplinarFinal.Sistema_de_ReservaDataSet1TableAdapters.TableAdapterManager();
            this.cboCarroDisponivel = new System.Windows.Forms.ListBox();
            this.sistema_de_ReservaDataSet1 = new InterdiciplinarFinal.Sistema_de_ReservaDataSet();
            this.sistemadeReservaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemadeReservaDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.txtDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.txtUltimoID = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.sistema_de_ReservaDataSet2 = new InterdiciplinarFinal.Sistema_de_ReservaDataSet();
            this.sistema_de_ReservaDataSet3 = new InterdiciplinarFinal.Sistema_de_ReservaDataSet();
            lblCarroDisponivel = new System.Windows.Forms.Label();
            lblNome = new System.Windows.Forms.Label();
            lblDataInicial = new System.Windows.Forms.Label();
            lblDataFinal = new System.Windows.Forms.Label();
            lblId = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_ReservaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_ReservaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeReservaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeReservaDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_ReservaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_ReservaDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarroDisponivel
            // 
            lblCarroDisponivel.AutoSize = true;
            lblCarroDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCarroDisponivel.Location = new System.Drawing.Point(69, 123);
            lblCarroDisponivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCarroDisponivel.Name = "lblCarroDisponivel";
            lblCarroDisponivel.Size = new System.Drawing.Size(157, 18);
            lblCarroDisponivel.TabIndex = 21;
            lblCarroDisponivel.Text = "Carros Disponíveis:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNome.Location = new System.Drawing.Point(75, 46);
            lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new System.Drawing.Size(58, 18);
            lblNome.TabIndex = 23;
            lblNome.Text = "Nome:";
            // 
            // lblDataInicial
            // 
            lblDataInicial.AutoSize = true;
            lblDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDataInicial.Location = new System.Drawing.Point(28, 82);
            lblDataInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDataInicial.Name = "lblDataInicial";
            lblDataInicial.Size = new System.Drawing.Size(96, 18);
            lblDataInicial.TabIndex = 23;
            lblDataInicial.Text = "Data Inicial:";
            // 
            // lblDataFinal
            // 
            lblDataFinal.AutoSize = true;
            lblDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDataFinal.Location = new System.Drawing.Point(369, 86);
            lblDataFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDataFinal.Name = "lblDataFinal";
            lblDataFinal.Size = new System.Drawing.Size(89, 18);
            lblDataFinal.TabIndex = 27;
            lblDataFinal.Text = "Data Final:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblId.Location = new System.Drawing.Point(59, 11);
            lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new System.Drawing.Size(74, 18);
            lblId.TabIndex = 23;
            lblId.Text = "Novo ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(401, 10);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(175, 18);
            label1.TabIndex = 30;
            label1.Text = "Último ID Cadastrado:";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(471, 318);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(159, 53);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(255, 318);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(159, 53);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(32, 318);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(159, 53);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(471, 231);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(159, 53);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "LIMPAR CAMPOS";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(252, 231);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(159, 53);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(32, 231);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(159, 53);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // sistema_de_ReservaDataSet
            // 
            this.sistema_de_ReservaDataSet.DataSetName = "Sistema_de_ReservaDataSet";
            this.sistema_de_ReservaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carrosBindingSource
            // 
            this.carrosBindingSource.DataMember = "carros";
            this.carrosBindingSource.DataSource = this.sistema_de_ReservaDataSet;
            // 
            // carrosTableAdapter
            // 
            this.carrosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carrosTableAdapter = null;
            this.tableAdapterManager.colaboradorTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.reservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = InterdiciplinarFinal.Sistema_de_ReservaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cboCarroDisponivel
            // 
            this.cboCarroDisponivel.DataSource = this.carrosBindingSource;
            this.cboCarroDisponivel.DisplayMember = "modelo_carro";
            this.cboCarroDisponivel.FormattingEnabled = true;
            this.cboCarroDisponivel.ItemHeight = 16;
            this.cboCarroDisponivel.Location = new System.Drawing.Point(252, 123);
            this.cboCarroDisponivel.Margin = new System.Windows.Forms.Padding(4);
            this.cboCarroDisponivel.Name = "cboCarroDisponivel";
            this.cboCarroDisponivel.Size = new System.Drawing.Size(255, 84);
            this.cboCarroDisponivel.TabIndex = 5;
            // 
            // sistema_de_ReservaDataSet1
            // 
            this.sistema_de_ReservaDataSet1.DataSetName = "Sistema_de_ReservaDataSet";
            this.sistema_de_ReservaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemadeReservaDataSet1BindingSource
            // 
            this.sistemadeReservaDataSet1BindingSource.DataSource = this.sistema_de_ReservaDataSet1;
            this.sistemadeReservaDataSet1BindingSource.Position = 0;
            // 
            // sistemadeReservaDataSet1BindingSource1
            // 
            this.sistemadeReservaDataSet1BindingSource1.DataSource = this.sistema_de_ReservaDataSet1;
            this.sistemadeReservaDataSet1BindingSource1.Position = 0;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(148, 44);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(313, 24);
            this.txtNome.TabIndex = 2;
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInicial.Location = new System.Drawing.Point(148, 82);
            this.txtDataInicial.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataInicial.Mask = "00/00/0000 90:00";
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(148, 24);
            this.txtDataInicial.TabIndex = 3;
            this.txtDataInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataInicial.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFinal.Location = new System.Drawing.Point(480, 82);
            this.txtDataFinal.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataFinal.Mask = "00/00/0000 90:00";
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(148, 24);
            this.txtDataFinal.TabIndex = 4;
            this.txtDataFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataFinal.ValidatingType = typeof(System.DateTime);
            // 
            // txtUltimoID
            // 
            this.txtUltimoID.BackColor = System.Drawing.SystemColors.Info;
            this.txtUltimoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUltimoID.ForeColor = System.Drawing.Color.Red;
            this.txtUltimoID.Location = new System.Drawing.Point(607, 6);
            this.txtUltimoID.Margin = new System.Windows.Forms.Padding(4);
            this.txtUltimoID.Name = "txtUltimoID";
            this.txtUltimoID.ReadOnly = true;
            this.txtUltimoID.Size = new System.Drawing.Size(43, 24);
            this.txtUltimoID.TabIndex = 29;
            this.txtUltimoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUltimoID.TextChanged += new System.EventHandler(this.txtUltimoID_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(148, 10);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(55, 22);
            this.txtId.TabIndex = 1;
            // 
            // sistema_de_ReservaDataSet2
            // 
            this.sistema_de_ReservaDataSet2.DataSetName = "Sistema_de_ReservaDataSet";
            this.sistema_de_ReservaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistema_de_ReservaDataSet3
            // 
            this.sistema_de_ReservaDataSet3.DataSetName = "Sistema_de_ReservaDataSet";
            this.sistema_de_ReservaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AgendarCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 394);
            this.ControlBox = false;
            this.Controls.Add(this.txtId);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtUltimoID);
            this.Controls.Add(this.txtDataFinal);
            this.Controls.Add(lblDataFinal);
            this.Controls.Add(this.txtDataInicial);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(lblDataInicial);
            this.Controls.Add(lblId);
            this.Controls.Add(lblNome);
            this.Controls.Add(lblCarroDisponivel);
            this.Controls.Add(this.cboCarroDisponivel);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AgendarCarro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar Carro";
            this.Load += new System.EventHandler(this.AgendarCarro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_ReservaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_ReservaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeReservaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeReservaDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_ReservaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_ReservaDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAdicionar;
        private Sistema_de_ReservaDataSet sistema_de_ReservaDataSet;
        private System.Windows.Forms.BindingSource carrosBindingSource;
        //private Sistema_de_ReservaDataSetTableAdapters.carrosTableAdapter carrosTableAdapter;
        private Sistema_de_ReservaDataSet1TableAdapters.carrosTableAdapter carrosTableAdapter;
        //private Sistema_de_ReservaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Sistema_de_ReservaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox cboCarroDisponivel;
        private Sistema_de_ReservaDataSet sistema_de_ReservaDataSet1;
        private System.Windows.Forms.BindingSource sistemadeReservaDataSet1BindingSource;
        private System.Windows.Forms.BindingSource sistemadeReservaDataSet1BindingSource1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtDataInicial;
        private System.Windows.Forms.MaskedTextBox txtDataFinal;
        public System.Windows.Forms.TextBox txtUltimoID;
        private System.Windows.Forms.TextBox txtId;
        private Sistema_de_ReservaDataSet sistema_de_ReservaDataSet2;
        private Sistema_de_ReservaDataSet sistema_de_ReservaDataSet3;
    }
}