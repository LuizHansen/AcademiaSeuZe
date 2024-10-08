using AcademiaZe.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AcademiaZe.View
{
    /// <summary>
    /// Interação lógica para PageListaLogradouro.xam
    /// </summary>
    public partial class PageListaLogradouro : Page
    {
        private string _connectionString { get; set; }
        private string _providerName { get; set; }
        private LogradouroViewModel ViewModelLogradouro;
        public PageListaLogradouro(string providerName, string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            _providerName = providerName;

            try
            {
                ViewModelLogradouro = new LogradouroViewModel(_providerName, _connectionString);

                ViewModelLogradouro.Load();

                DataContext = ViewModelLogradouro;
            }
            catch
            {
                MessageBox.Show("Erro ao carregar a lista de logradouros!");
            }
        }


        private void cadastrarLogradouro_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new PageCadastrarLogradouro(_providerName, _connectionString));

        }
    }
}
