using System;
using System.Windows.Forms;
using System.Threading;
using InterdiciplinarFinal.TelasCarros;

namespace InterdiciplinarFinal
{
    public partial class TelaInicial : System.Windows.Forms.Form
    {
        Thread nt; //DEFINI UM THREAD PARA USAR NOS REFERENCIAMENTOS DE NOVAS PAGINAS

        public TelaInicial()
        {
            InitializeComponent();
        }

        //ABA CADASTRO DE USUÁRIO
        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //ABA CADASTRO DE CARRO
        private void cadastroCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoUsuario()
        {
            Application.Run(new CadastroUsuario());
        }


        //AÇÃO ABA SAIR
        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void NovaReservaToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void cadastroUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nt = new Thread(novoUsuario);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void relatórioDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nt = new Thread(relatorioUsuario);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void relatorioUsuario()
        {
            Application.Run(new RelatorioUsuarios());
        }

        private void cadastroDeCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nt = new Thread(novoCarro);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void novoCarro()
        {
            Application.Run(new CadastroCarro());
        }

        private void carrosCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nt = new Thread(relatorioCarro);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void relatorioCarro()
        {
            Application.Run(new relatorioCarro());
        }
    }
}
