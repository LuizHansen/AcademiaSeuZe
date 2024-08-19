using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AcademiaZe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            if (framePrincipal.Content is not null)
            {
                framePrincipal.Content = null;
            }
        }
        private void ButtonColaborador_Click(object sender, RoutedEventArgs e)
        {
            if (framePrincipal.Content is not PageCadastrarColaborador)
            {
                framePrincipal.Content = new PageCadastrarColaborador();
            }
        }
        private void ButtonAluno_Click(object sender, RoutedEventArgs e)
        {
            if (framePrincipal.Content is not PageCadastrarAluno)
            {
                framePrincipal.Content = new PageCadastrarAluno();
            }
        }
        private void ButtonMatricula_Click(object sender, RoutedEventArgs e)
        {
            if (framePrincipal.Content is not PageCadastrarMatricula)
            {
                framePrincipal.Content = new PageCadastrarMatricula();
            }
        }
        private void ButtonFrequencia_Click(object sender, RoutedEventArgs e)
        {
            if (framePrincipal.Content is not PageCadastrarFrequencia)
            {
                framePrincipal.Content = new PageCadastrarFrequencia();
            }
        }
        private void ButtonAvaliacao_Click(object sender, RoutedEventArgs e)
        {
            if (framePrincipal.Content is not PageCadastrarAvaliacao)
            {
                framePrincipal.Content = new PageCadastrarAvaliacao();
            }
        }

        private void ButtonLogradouro_Click(object sender, RoutedEventArgs e)
        {
            if (framePrincipal.Content is not PageCadastrarLogradouro)
            {
                framePrincipal.Content = new PageCadastrarLogradouro();
            }
        }
        private void ButtonSenha_Click(object sender, RoutedEventArgs e)
        {
            if (framePrincipal.Content is not PageCadastrarSenha)
            {
                framePrincipal.Content = new PageCadastrarSenha();
            }
        }

        private void ButtonLoginLogoff_Click(object sender, RoutedEventArgs e)
        {
            if (framePrincipal.Content is not PageLoginLogoff)
            {
                framePrincipal.Content = new PageLoginLogoff();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CultureInfo culture = new CultureInfo("en-US");

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            var oldWindow = this;
            var newWindow = new MainWindow();
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }
    }
}