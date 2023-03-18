using Evidence;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;

namespace Evidence
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //instance evidence
            Evidence evidence = new Evidence();
            evidence.VypisUvodniObrazovku();
            char volba = '0';
            //hlavní cyklus
            while (volba != '4')
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Evidence pojištěných");
                Console.WriteLine("-----------------------------");

                Console.WriteLine("Vyberte si akci:");
                Console.WriteLine("1 - Přidat nového pojištěného");
                Console.WriteLine("2 - Vypsat všechny pojištěné");
                Console.WriteLine("3 - Vyhledat pojištěného");
                Console.WriteLine("4 - Konec");
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();
                //reakce na volbu

                switch (volba)
                {
                    case '1':
                        evidence.PridejZaznam();
                        break;
                    case '2':
                        evidence.VypisZaznam();
                        break;
                    case '3':
                        evidence.VyhledejZaznam();
                        break;
                    case '4':
                        Console.WriteLine("Děkuji za použití aplikace, aplikaci ukončíte libovolnou klávesou.");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba - opakujte volbu.");
                        break;

                }
            }
        }
    }
}