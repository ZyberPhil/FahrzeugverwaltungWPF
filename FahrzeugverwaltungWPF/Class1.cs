using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrzeugverwaltungWPF
{
    public class Fahrzeug
    {
        public string Marke { get; set; }
        public string Modell { get; set; }
        public int Baujahr { get; set; }
        public string Farbe { get; set; }

        public virtual void Anzeigen()
        {
            Console.WriteLine($"Marke: {Marke}, Modell: {Modell}, Baujahr: {Baujahr}, Farbe: {Farbe}");
        }
    }

    public class Auto : Fahrzeug
    {
        public int AnzahlDerTüren { get; set; }

        public override void Anzeigen()
        {
            base.Anzeigen();
            Console.WriteLine($"Anzahl der Türen: {AnzahlDerTüren}");
        }
    }

    public class Motorrad : Fahrzeug
    {
        public int Hubraum { get; set; }

        public override void Anzeigen()
        {
            base.Anzeigen();
            Console.WriteLine($"Hubraum: {Hubraum} ccm");
        }
    }

    public class Lastwagen : Fahrzeug
    {
        public int MaximaleLadung { get; set; }

        public override void Anzeigen()
        {
            base.Anzeigen();
            Console.WriteLine($"Maximale Ladung: {MaximaleLadung} kg");
        }
    }
}