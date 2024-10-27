using System;
using System.Collections.Generic;
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
    /// Interação lógica para PageCadastrarLogradouro.xam
    /// </summary>
    /// 
    public partial class PageCadastrarLogradouro : Page
    {
        private string _connectionString { get; set; }
        private string _providerName { get; set; }
        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="PageCadastrarLogradouro"/>.
        /// </summary>
        public PageCadastrarLogradouro(string providerName, string connectionString)
        {
            InitializeComponent();
            this.Loaded += PageCadastrarLogradouro_Loaded;
            _connectionString = connectionString;
            _providerName = providerName;
        }

        private void PageCadastrarLogradouro_Loaded(object sender, RoutedEventArgs e)
        {
            var UCLogradouro = this.FindName("UCLogradouro") as UIElement;
            if (UCLogradouro != null)
            {
                UCLogradouro.Focus();
            }
        }

        private void Box_KeyDown(object sender, KeyEventArgs e)
        {
            Funcoes.Window_KeyDown(sender, e);
        }
    }
}
