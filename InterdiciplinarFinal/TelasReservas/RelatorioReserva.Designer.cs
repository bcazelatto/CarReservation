namespace InterdiciplinarFinal
{
    partial class RelatorioReserva
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
            this.btnSair = new System.Windows.Forms.Button();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_de_ReservaDataSet = new InterdiciplinarFinal.Sistema_de_ReservaDataSet();
            this.carrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrosTableAdapter = new InterdiciplinarFinal.Sistema_de_ReservaDataSet1TableAdapters.carrosTableAdapter();
            this.tableAdapterManager = new InterdiciplinarFinal.Sistema_de_ReservaDataSet1TableAdapters.TableAdapterManager();
            this.reservaTableAdapter = new InterdiciplinarFinal.Sistema_de_ReservaDataSet1TableAdapters.reservaTableAdapter();
            this.carrosTableAdapter1 = new InterdiciplinarFinal.Sistema_de_ReservaDataSet1TableAdapters.carrosTableAdapter();
            this.tableAdapterManager1 = new InterdiciplinarFinal.Sistema_de_ReservaDataSet1TableAdapters.TableAdapterManager();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_ReservaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(783, 385);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(159, 53);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataMember = "reserva";
            this.reservaBindingSource.DataSource = this.sistema_de_ReservaDataSet;
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
            // reservaTableAdapter
            // 
            this.reservaTableAdapter.ClearBeforeFill = true;
            // 
            // carrosTableAdapter1
            // 
            this.carrosTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.carrosTableAdapter = null;
            this.tableAdapterManager1.colaboradorTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.reservaTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = InterdiciplinarFinal.Sistema_de_ReservaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 15);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(925, 358);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(616, 385);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(159, 53);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // RelatorioReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 453);
            this.ControlBox = false;
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnSair);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RelatorioReserva";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório das Reservas";
            this.Load += new System.EventHandler(this.RelatorioReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_ReservaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sistema_de_ReservaDataSet sistema_de_ReservaDataSet;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.BindingSource carrosBindingSource;
        private InterdiciplinarFinal.Sistema_de_ReservaDataSet1TableAdapters.carrosTableAdapter carrosTableAdapter;
        private InterdiciplinarFinal.Sistema_de_ReservaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private Sistema_de_ReservaDataSet1TableAdapters.reservaTableAdapter reservaTableAdapter;
        private InterdiciplinarFinal.Sistema_de_ReservaDataSet1TableAdapters.carrosTableAdapter carrosTableAdapter1;
        private InterdiciplinarFinal.Sistema_de_ReservaDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnPesquisar;
    }
}