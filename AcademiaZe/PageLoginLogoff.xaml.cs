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

namespace AcademiaZe
{
    /// <summary>
    /// Interação lógica para PageLoginLogoff.xam
    /// </summary>
    public partial class PageLoginLogoff : Page
    {
        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="PageLoginLogoff"/>.
        /// </summary>
        public PageLoginLogoff()
        {
            InitializeComponent();
            textBoxCPF.Focus();
        }

        private void Box_GotFocus(object sender, RoutedEventArgs e)
        {
            Funcoes.GanhaFoco(sender);
        }

        private void Box_LostFocus(object sender, RoutedEventArgs e)
        {
            Funcoes.PerdeFoco(sender);
        }
    }
}
