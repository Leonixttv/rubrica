using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace corbelli.leonardo._4i.rubrica
{
    internal class Contatto
    {
        private int _numero;
        private string _cognome;

        public int Numero
        {
            get
            {
                return _numero;
            }

            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException();

                _numero = value;
            }
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Citta { get; set; }
        public string Cap { get; set; }

        public string Cognome { get => _cognome; set => _cognome = value; }

        public Contatto() { }

        public Contatto( string riga)
        {

            string[] campi = riga.Split(';');
            if (campi.Length >= 5){
                int pk = 0;
                if (int.TryParse(campi[0], out pk))
                {
                    
                    int.TryParse(campi[0], out pk);
                    this.Numero = pk;
                    this.Nome = campi[1];
                    this.Cognome = campi[2];
                    this.Telefono = campi[3];
                    this.Email = campi[4];

                    
                }
                else
                {
                    throw new ArgumentOutOfRangeException("il campo pk non è un numero!!");
                }
            }
            
        }

        public Contatto(int numero, string nome, string cognome)
        {
            Numero = numero;
            Nome = nome;
            Cognome = cognome;
        }
    }
}
