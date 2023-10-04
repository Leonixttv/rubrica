using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace corbelli.leonardo._4i.rubrica
{
    internal class contatto
    {
        private int numero;
        private string nome;
        private string cognome;

        public int Numero { get => numero; set => numero = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
    }
}
