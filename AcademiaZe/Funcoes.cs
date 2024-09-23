using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AcademiaZe
{
    internal class Funcoes
    {
        public static void AjustaIdiomaRegiao()
        {
            // pt-BR, en-US, es-ES
            // ? indica que o valor pode ser nulo
            string? auxIdiomaRegiao = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
            // no ternário estamos tratando para isso não acontecer
            string idiomaRegiao = (auxIdiomaRegiao is not null) ? auxIdiomaRegiao : "";
            // Definir a cultura e ajusta o idioma/região
            // o operador ! (null-forgiving) afirma que o valor já foi tratado e não será nulo aqui
            CultureInfo culture = new(idiomaRegiao!);
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
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
            else if (sender is DatePicker)
            {
                DatePicker datePicker = (DatePicker)sender;
                datePicker.Background = cor;
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
            else if (sender is DatePicker)
            {
                DatePicker datePicker = (DatePicker)sender;
                datePicker.Background = cor;
            }
            else if (sender is ComboBox)
            {
                ComboBox comboBox = (ComboBox)sender;
                comboBox.Background = cor;
            }
        }
    }
}
