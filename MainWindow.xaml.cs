using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
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

namespace DarioAuguri
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Dario esecutore = new Dario();
            esecutore.RiempiLista();
            string selezionato = esecutore.Seleziona(esecutore.SelectRandom());

            Process proc = new Process();
            proc.StartInfo.FileName = selezionato;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();

            //SoundPlayer darioVoice = new SoundPlayer(selezionato);
            //darioVoice.Play();
        }
    }
}
