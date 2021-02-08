using System;
using System.Threading;
using System.Windows.Forms;

namespace InterdiciplinarFinal
{
    public partial class TelaInicial2 : Form
    {
        Thread nt;
        public TelaInicial2()
        {
            InitializeComponent();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void novaReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nt = new Thread(agendarCarro);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void agendarCarro()
        {
            Application.Run(new AgendarCarro());
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nt = new Thread(relatorioReserva);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void relatorioReserva()
        {
            Application.Run(new RelatorioReserva());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TelaInicial2_Load(object sender, EventArgs e)
        {

        }
    }
}
