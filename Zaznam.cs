using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence
{
    internal class Zaznam
    {/// <summary>
     /// Jméno pojištěného
     /// </summary>
        public string jmeno { get; set; }
        /// <summary>
        /// Příjmení pojištěného
        /// </summary>
        public string prijmeni { get; set; }
        /// <summary>
        /// Telefonní číslo
        /// </summary>
        public string telefon { get; set; }
        /// <summary>
        /// Věk
        /// </summary>
        public byte vek { get; set; }

        //Konstruktor, this = rozlišení
        public Zaznam (string jmeno, string prijmeni, string telefon, byte vek)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.telefon = telefon;
            this.vek = vek;
        }
        public override string ToString()
        {
            return string.Format(jmeno.PadRight(20,' ') + prijmeni.PadRight(20, ' ') +"Tel: " + telefon.PadRight(20, ' ') + vek + " let");
        }
    }
}
