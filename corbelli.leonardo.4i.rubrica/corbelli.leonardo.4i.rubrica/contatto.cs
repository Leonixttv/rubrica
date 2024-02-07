using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace corbelli.leonardo._4i.rubrica
{
    public enum TipoContatto { nessuno, Email, Telefono, Web, Instagram, celluare }

    public class contatto
    {
        public int idPersona { get; set; }

        public TipoContatto Tipo { get; set; }

        public string Valore { get; set; }

        public contatto()
        {
            Tipo = TipoContatto.nessuno;
        }

        public contatto(string riga)
        {

            string[] campi = riga.Split(';');

            int id = 0;
            int.TryParse(campi[0], out id);
            idPersona = id;

            TipoContatto c;
            Enum.TryParse(campi[1], out c);
            this.Tipo = campi[1];

            this.Valore = campi[2];


        }
    }
}

