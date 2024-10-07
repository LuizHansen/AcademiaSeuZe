using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Xceed.Wpf.Toolkit;

namespace AcademiaZe
{
    internal class Funcoes
    {
        public static void AjustaIdiomaRegiao()
        {
            // pt-BR, en-US, es-ES
            // ? indica que o valor pode ser nulo
            //string? auxIdiomaRegiao = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
            // no ternário estamos tratando para isso não acontecer
            //string idiomaRegiao = (auxIdiomaRegiao is not null) ? auxIdiomaRegiao : "";
            // Definir a cultura e ajusta o idioma/região
            // o operador ! (null-forgiving) afirma que o valor já foi tratado e não será nulo aqui
            //CultureInfo culture = new(idiomaRegiao!);
            //Thread.CurrentThread.CurrentUICulture = culture;
            //Thread.CurrentThread.CurrentCulture = culture;
        }
        public static void GanhaFoco(object sender)
        {
            
            var cor = System.Windows.Media.Brushes.LightCyan;
            if (sender is TextBox)
            {
                TextBox textBox = (TextBox)sender;
                textBox.Background = cor;
            }
            else if (sender is PasswordBox)
            {
                PasswordBox passwordBox = (PasswordBox)sender;
                passwordBox.Background = cor;
            }
            else if (sender is MaskedTextBox)
            {
                MaskedTextBox maskedTextBox= (MaskedTextBox)sender;
                maskedTextBox.Background = cor;
            }
            else if (sender is ComboBox)
            {
                ComboBox comboBox = (ComboBox)sender;
                comboBox.Background = cor;
            }

        }
        public static void PerdeFoco(object sender)
        {
            var cor = System.Windows.Media.Brushes.White;
            if (sender is TextBox)
            {
                TextBox textBox = (TextBox)sender;
                textBox.Background = cor;
            }
            else if (sender is PasswordBox)
            {
                PasswordBox passwordBox = (PasswordBox)sender;
                passwordBox.Background = cor;
            }
            else if (sender is MaskedTextBox)
            {
                MaskedTextBox maskedTextBox = (MaskedTextBox)sender;
                maskedTextBox.Background = cor;
            }
            else if (sender is ComboBox)
            {
                ComboBox comboBox = (ComboBox)sender;
                comboBox.Background = cor;
            }
            
        }
        /// <summary>
        /// Tratar eventos de teclado, no caso tecla ENTER funcionando com TAB e tecla ESC para fechar
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento</param>
        /// <param name="e">Evento que foi capturado</param>
        /// <example>No construtor do formulário:
        /// this.KeyDown += new System.Windows.Input.KeyEventHandler(ClassFuncoes.Window_KeyDown);
        ///</example>S
        public static void Window_KeyDown(object sender, KeyEventArgs e)
        {
            // Se a tecla ENTER for pressionada
            if (e.Key == Key.Enter)
            {
                // Move o foco para o próximo controle, como o TAB faria
                var focusedElement = Keyboard.FocusedElement as UIElement;
                // Move o foco para o próximo controle na ordem de tabulação
                focusedElement?.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
                e.Handled = true; // Previne comportamento padrão do ENTER (como som)
            }
            // Se a tecla ESC for pressionada
            else if (e.Key == Key.Escape)
            {
                // verifica se é window e fecha
                if (sender is Window window)
                {
                    window.Close();
                }
                // carrega uma página inicial
                else
                {
                    if (Application.Current.MainWindow is MainWindow mainWindow)
                    {
                        // precisa passar o método para public
                        mainWindow.ButtonHome_Click(sender, e);
                    }
                }
            }
        }
        public static void ValidaConexaoDB()
        {
            DbProviderFactory factory;
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string connectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            try
            {
                factory = DbProviderFactories.GetFactory(provider);
                using var conexao = factory.CreateConnection();
                conexao!.ConnectionString = connectionString;
                using var comando = factory.CreateCommand();
                comando!.Connection = conexao;
                conexao.Open();
            }
            catch (DbException ex)
            {
                System.Windows.MessageBox.Show($"{ex.Source}\n\n{ex.Message}\n\n{ex.ErrorCode}\n\n{ex.SqlState}\n\n{ex.StackTrace}");
                var auxConfig = new WindowConfig(provider);
                auxConfig.ShowDialog();
                ValidaConexaoDB();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show($"{ex.Source}\n\n{ex.Message}\n\n{ex.StackTrace}");
                var auxConfig = new WindowConfig(provider);
                auxConfig.ShowDialog();
                ValidaConexaoDB();
            }
        }
    }
}
