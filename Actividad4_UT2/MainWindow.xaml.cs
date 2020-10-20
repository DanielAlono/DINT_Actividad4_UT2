using System;
using System.Windows;

namespace Actividad4_UT2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textoTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

            if (textoTextBox.Text.Length == 140)
            {
                textoTextBox.IsReadOnly = true;
                textoTextBox.AcceptsReturn = false; //Qué raro, permite saltos de línea aunque se cumplan los 140 caracteres sin poner esta propiedad en false.
            }
            contadorLabel.Content = textoTextBox.Text.Length + "/140";
        }
    }
}
