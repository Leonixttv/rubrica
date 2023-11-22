using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace corbelli.leonardo._4i.rubrica
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                const int MAX = 100;

                Contatto[] Contatti = new Contatto[100];

                for (int i = 0; i < Contatti.Length; i++)
                {
                    Contatti[i] = new Contatto();
                }

                int idx = 0;

                StreamReader fin = new StreamReader("Dati.csv");
                fin.ReadLine();

                while (!fin.EndOfStream)
                {
                    if (idx < MAX)
                    {
                        string riga = fin.ReadLine();
                        Contatto c = new Contatto(riga);
                        Contatti[idx++] = c;
                    }
                    else
                        break;
                }

                for (; idx < MAX; idx++)
                {
                    Contatti[idx] = new Contatto();
                }

                dgDati.ItemsSource = Contatti;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No no!!\n" + ex.Message);
            }

        }

        private void daDati_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            Contatto C = e.Row.Item as Contatto;
            if (C != null)
            {
                if (C.Numero == 0)
                {
                    e.Row.Background = Brushes.Red;
                    e.Row.Foreground = Brushes.Blue;
                }
            }
        }
    }
}
