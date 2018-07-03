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

using WindowsForm = System.Windows.Forms;

namespace sassex.Views
{
    /// <summary>
    /// Lógica de interacción para Configuracion.xaml
    /// </summary>
    public partial class Configuracion : UserControl
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        public void Save()
        {
            configViewModel.Save();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            using (var dirDialog = new WindowsForm.FolderBrowserDialog())
            {
                var result = dirDialog.ShowDialog();
                switch (result)
                {
                    case WindowsForm.DialogResult.OK:
                        configViewModel.InputDirectory = dirDialog.SelectedPath;
                        break;
                }
            }
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Save();
        }
    }
}
