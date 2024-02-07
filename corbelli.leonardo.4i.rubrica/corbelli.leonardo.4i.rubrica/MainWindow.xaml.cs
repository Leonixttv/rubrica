using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
        List<Persona> Persone = new List<Persona>();
        List<Contatto> Contatti = new List<Contatto>();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Torsani_Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                //legge le persone
                StreamReader fin = new StreamReader("Persone.csv");
                fin.ReadLine();

                while (!fin.EndOfStream)
                {
                    string riga = fin.ReadLine();
                    Persona p = new Persona(riga);
                    Persone.Add(p);
                }
                dgPersone.ItemsSource = Persone;

                // le righe lette sono idx
                statusbar.Text = $"Ho letto {Persone.Count} righe";

                StreamReader fino = new StreamReader("Contatti.csv");
                fino.ReadLine();

                while (!fino.EndOfStream)
                {
                    string riga = fino.ReadLine();
                    Contatto c = new Contatto(riga);
                    Contatti.Add(c);
                }
                dgContatti.ItemsSource = Contatti;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgDati_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // "e" è un oggetto con "as" lo trasformiamo nell'oggetto Contatto che spostiamo in "c"
            Persona p = e.AddedItems[0] as Persona;
            List<Contatto> contattiFiltrati = new List<Contatto>();
            if (p != null)
            {
                statusbar.Text = $"Il contatto selezionato: {p.Nome}";
                foreach (Contatto item in Contatti)
                {
                    if (item.idPersona == p.idPersona)
                    {
                        contattiFiltrati.Add(item);
                    }
                }
            }
            dgContatti.ItemsSource = contattiFiltrati;
        }
    }
}
