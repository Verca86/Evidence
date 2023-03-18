using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Evidence
{
    internal class Evidence
    {
        /// <summary>
        /// Privátní instance databáze vytvořená v konstruktoru
        /// </summary>
        private Databaze databaze;

        public Evidence()
        {
            databaze = new Databaze();
        }
        /// <summary>
        /// Přidání
        /// </summary>
        public void PridejZaznam()
        {
            Console.WriteLine("Zadejte jméno pojištěného: ");
            string jmeno = Console.ReadLine();
            jmeno = jmeno.Trim().ToUpper();
            Console.WriteLine("Zadejte příjmení pojištěného: ");
            string prijmeni = Console.ReadLine();
            prijmeni = prijmeni.Trim().ToUpper();
            Console.WriteLine("Zadejte telefonní číslo pojištěného: ");
            string telefon = Console.ReadLine();
            telefon = telefon.Trim();
            Console.WriteLine("Zadejte věk pojištěného: ");
            byte vek;
            while (!byte.TryParse(Console.ReadLine(), out vek))
                Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");
            Console.WriteLine("Data byla uložena, pokračujte libovolnou klávesou...");
            databaze.Pridej(jmeno, prijmeni, telefon, vek);
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Výpis
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="cislo"></param>
        /// <param name="vek"></param>
        public void VypisZaznam()
        {
            databaze.Vypis();
            Console.WriteLine("pokračujte libovolnou klávesou...");
            Console.ReadKey();
            Console.Clear();

        }
        /// <summary>
        /// Vyhledej záznam
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        public void VyhledejZaznam()
        {

            Console.WriteLine("Zadejte jméno pojištěného: ");
            string jmeno = Console.ReadLine();
            jmeno = jmeno.Trim().ToUpper();
            Console.WriteLine("Zadejte příjmení pojištěného: ");
            string prijmeni = Console.ReadLine();
            prijmeni = prijmeni.Trim().ToUpper();
            Console.WriteLine("Nalezeny tyto záznamy: ");
            databaze.Vyhledej(jmeno, prijmeni, true);
            Console.WriteLine("pokračujte libovolnou klávesou...");
            Console.ReadKey();
            Console.Clear();
            
        }
        public void VypisUvodniObrazovku()
            {
                Console.WriteLine("\r\n _____ _     _  ____  _____ _      ____  _____\r\n/  __// \\ |\\/ \\/  _ \\/  __// \\  /|/   _\\/  __/\r\n|  \\  | | //| || | \\||  \\  | |\\ |||  /  |  \\  \r\n|  /_ | \\// | || |_/||  /_ | | \\|||  \\_ |  /_ \r\n\\____\\\\__/  \\_/\\____/\\____\\\\_/  \\|\\____/\\____\\\r\n                                              \r\n");

            }
        }
    }
