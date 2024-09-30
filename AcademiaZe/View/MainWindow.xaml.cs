using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AcademiaZe
{
    /// <summary>
    /// Lógica interna para MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        public string ConnectionString { get; set; }
        public string ProviderName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Funcoes.ValidaConexaoDB();
            ProviderName = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            ConnectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            this.Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
                // Exemplo: Confirmar se o usuário realmente deseja fechar a janela
                MessageBoxResult result = MessageBox.Show("Deseja realmente fechar a aplicação?", "Confirmação", MessageBoxButton.YesNo, MessageBoxImage.Question);
            
            if (result == MessageBoxResult.No)
            {
                // Cancela o fechamento da janela
                e.Cancel = true;
            }
        }
        public void ButtonHome_Click(object sender, RoutedEventArgs e)
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

        private void buttonConfig_Click(object sender, RoutedEventArgs e)
        {
            WindowConfig windowConfig = new WindowConfig(ProviderName);
            windowConfig.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            windowConfig.ShowDialog();

            var newWindow = new MainWindow();
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            Close();

        }

    }
}
