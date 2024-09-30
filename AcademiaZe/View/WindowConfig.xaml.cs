using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Shapes;

namespace AcademiaZe
{
    /// <summary>
    /// Lógica interna para WindowConfig.xaml
    /// </summary>
    public partial class WindowConfig : Window
    {
        public WindowConfig(string provider)
        {
            InitializeComponent();
            comboBoxIdioma.SelectedItem = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
            comboBoxIdioma.Focus();
        }
        private void TxtSalvar_Click(object sender, RoutedEventArgs e)
        {
            //abre o arquivo local como leitura/escrita e salva as alterações em AcademiaDoZe_WPF.dll.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");
            config.AppSettings.Settings.Add("IdiomaRegiao", comboBoxIdioma.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            //atualiza a cultura corrente
            Funcoes.AjustaIdiomaRegiao();
            Close();
        }
        private void Box_GotFocus(object sender, RoutedEventArgs e)
        {
            Funcoes.GanhaFoco(sender);
        }
        private void Box_LostFocus(object sender, RoutedEventArgs e)
        {
            Funcoes.PerdeFoco(sender);
        }
        private void Box_KeyDown(object sender, KeyEventArgs e)
        {
            Funcoes.Window_KeyDown(sender, e);
        }
    }
}
