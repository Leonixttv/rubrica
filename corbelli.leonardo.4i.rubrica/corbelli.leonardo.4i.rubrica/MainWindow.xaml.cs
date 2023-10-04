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

namespace corbelli.leonardo._4i.rubrica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            contatto c = new contatto();
            c.Numero = 1;
            c.Nome = "leonardo";
            c.Cognome = "corbelli";

            contatto[] Contatti = new contatto[100];
            Contatti[0] = c;

            Contatti[0].Nome = "bho";
            Contatti[0].Cognome = "non so";
        }
    }
}
