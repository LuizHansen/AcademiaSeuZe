﻿using System;
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
    /// Interação lógica para PageCadastrarColaborador.xam
    /// </summary>
    public partial class PageCadastrarColaborador : Page
    {
        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="PageCadastrarColaborador"/>.
        /// </summary>
        public PageCadastrarColaborador()
        {
            InitializeComponent();
            textBoxID.Focus();
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
