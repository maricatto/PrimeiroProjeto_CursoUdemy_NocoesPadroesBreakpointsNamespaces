using System;
using System.Windows.Forms;

namespace PrimeiroProjeto_CursoUdemy_NocoesPadroesBreakpointsNamespaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSimples(object sender, EventArgs e)
        {

            // Adicionar uma mensagem no botão
            MessageBox.Show("Hello world");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Criar uma variavel e mostrar ela no click do botão
            string nome = "Vinicius Maricatto de Barros";
            MessageBox.Show(nome);
        }

        private void btnNamespace(object sender, EventArgs e)
        {
            // Instanciando o namespace e mostrando o conteudo do namespace no click do botão
            minhaBiblioteca.minhaClasse minhaClasse = new minhaBiblioteca.minhaClasse();
            MessageBox.Show(minhaClasse.texto);
        }
    }
}

// Criando o namespace
namespace minhaBiblioteca
{
    public class minhaClasse
    {
        public string texto = "Olá eu vim de um namespace externo";
    }
}