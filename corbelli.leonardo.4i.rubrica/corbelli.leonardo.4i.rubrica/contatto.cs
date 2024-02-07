﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace corbelli.leonardo._4i.rubrica
{
    public enum TipoContatto { nessuno, Email, Telefono, Web, Instagram, FaceBook }
    internal class Contatto
    {
        public int idPersona { get; set; }
        public TipoContatto Tipo { get; set; }
        public string Valore { get; set; }

        public Contatto()
        {
            Tipo = TipoContatto.nessuno;
        }
        // Costruisce un Contatto, partendo da una riga CSV
        public Contatto(string riga)
        {
            string[] campi = riga.Split(';');
            //tenta di interpretare una stringa, in questo caso tenta di convertire campi[0] in un int (id).
            int id = 0;
            int.TryParse(campi[0], out id);
            idPersona = id;

            TipoContatto c;
            Enum.TryParse(campi[1], out c);
            this.Tipo = c;

            this.Valore = campi[2];
        }
    }
}

