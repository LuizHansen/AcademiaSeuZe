using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Windows;

namespace AcademiaZe
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
            // mantem o que já acontecia no método original
            base.OnStartup(e);

            // Define a cultura padrão
            Funcoes.AjustaIdiomaRegiao();
        }
    }

}
