namespace InterdiciplinarFinal
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrosCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuárioToolStripMenuItem,
            this.cadastroCarroToolStripMenuItem,
            this.reservaCarroToolStripMenuItem,
            this.sAIRToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(729, 48);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            this.cadastrarUsuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroUsuáriosToolStripMenuItem,
            this.relatórioDeUsuáriosToolStripMenuItem});
            this.cadastrarUsuárioToolStripMenuItem.Image = global::InterdiciplinarFinal.Properties.Resources.usuario;
            this.cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            this.cadastrarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(188, 44);
            this.cadastrarUsuárioToolStripMenuItem.Text = "CADASTRO DE USUÁRIO";
            this.cadastrarUsuárioToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cadastrarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsuárioToolStripMenuItem_Click);
            // 
            // cadastroUsuáriosToolStripMenuItem
            // 
            this.cadastroUsuáriosToolStripMenuItem.Image = global::InterdiciplinarFinal.Properties.Resources.adicionar;
            this.cadastroUsuáriosToolStripMenuItem.Name = "cadastroUsuáriosToolStripMenuItem";
            this.cadastroUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.cadastroUsuáriosToolStripMenuItem.Text = "Cadastro Usuários";
            this.cadastroUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.cadastroUsuáriosToolStripMenuItem_Click);
            // 
            // relatórioDeUsuáriosToolStripMenuItem
            // 
            this.relatórioDeUsuáriosToolStripMenuItem.Image = global::InterdiciplinarFinal.Properties.Resources.lista_usuario;
            this.relatórioDeUsuáriosToolStripMenuItem.Name = "relatórioDeUsuáriosToolStripMenuItem";
            this.relatórioDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.relatórioDeUsuáriosToolStripMenuItem.Text = "Relatório de Usuários";
            this.relatórioDeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeUsuáriosToolStripMenuItem_Click);
            // 
            // cadastroCarroToolStripMenuItem
            // 
            this.cadastroCarroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeCarroToolStripMenuItem,
            this.carrosCadastradosToolStripMenuItem});
            this.cadastroCarroToolStripMenuItem.Image = global::InterdiciplinarFinal.Properties.Resources.carro;
            this.cadastroCarroToolStripMenuItem.Name = "cadastroCarroToolStripMenuItem";
            this.cadastroCarroToolStripMenuItem.Size = new System.Drawing.Size(174, 44);
            this.cadastroCarroToolStripMenuItem.Text = "CADASTRO DE CARRO";
            this.cadastroCarroToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cadastroCarroToolStripMenuItem.Click += new System.EventHandler(this.cadastroCarroToolStripMenuItem_Click);
            // 
            // cadastroDeCarroToolStripMenuItem
            // 
            this.cadastroDeCarroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroDeCarroToolStripMenuItem.Image")));
            this.cadastroDeCarroToolStripMenuItem.Name = "cadastroDeCarroToolStripMenuItem";
            this.cadastroDeCarroToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cadastroDeCarroToolStripMenuItem.Text = "Cadastrar Carros";
            this.cadastroDeCarroToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCarroToolStripMenuItem_Click);
            // 
            // carrosCadastradosToolStripMenuItem
            // 
            this.carrosCadastradosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("carrosCadastradosToolStripMenuItem.Image")));
            this.carrosCadastradosToolStripMenuItem.Name = "carrosCadastradosToolStripMenuItem";
            this.carrosCadastradosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.carrosCadastradosToolStripMenuItem.Text = "Relatório de Carros";
            this.carrosCadastradosToolStripMenuItem.Click += new System.EventHandler(this.carrosCadastradosToolStripMenuItem_Click);
            // 
            // reservaCarroToolStripMenuItem
            // 
            this.reservaCarroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaReservaToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.reservaCarroToolStripMenuItem.Image = global::InterdiciplinarFinal.Properties.Resources.reserva;
            this.reservaCarroToolStripMenuItem.Name = "reservaCarroToolStripMenuItem";
            this.reservaCarroToolStripMenuItem.Size = new System.Drawing.Size(166, 44);
            this.reservaCarroToolStripMenuItem.Text = "RESERVA DE CARROS";
            this.reservaCarroToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // novaReservaToolStripMenuItem
            // 
            this.novaReservaToolStripMenuItem.Image = global::InterdiciplinarFinal.Properties.Resources.novo;
            this.novaReservaToolStripMenuItem.Name = "novaReservaToolStripMenuItem";
            this.novaReservaToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.novaReservaToolStripMenuItem.Text = "Agendar Carro";
            this.novaReservaToolStripMenuItem.Click += new System.EventHandler(this.NovaReservaToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = global::InterdiciplinarFinal.Properties.Resources.editar;
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.consultarToolStripMenuItem.Text = "Relatório de Reservas";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Image = global::InterdiciplinarFinal.Properties.Resources.sair;
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(54, 44);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 44);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(14, 44);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(14, 44);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(14, 44);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 443);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroCarroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaCarroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem cadastroUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeCarroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrosCadastradosToolStripMenuItem;
    }
}