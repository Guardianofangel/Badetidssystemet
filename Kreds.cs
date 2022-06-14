using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    public class Kreds
    {
        // opgave 1
        private string iD;
        private string navn;
        private string adresse;
        private int antalDeltager;


        public Kreds(string iD, string navn, string adresse, int antalDeltager)
        {
            this.iD = iD;
            this.navn = navn;
            this.adresse = adresse;
            this.antalDeltager = antalDeltager;

            if (antalDeltager <= 0)
               Console.WriteLine("Mindst 1 person er påkrævet for at starte aktiviteten");
        }
        public string ID
        {
            get { return iD; }
            set { this.iD = value; }
        }
        public string Navn
        {
            get { return navn; }
            set { this.navn = value; }
        }
        public string Adresse
        {
            get { return adresse; }
            set { this.adresse = value; }
        }
        public int AntalDeltager
        {
            get { return antalDeltager; }
            set { this.antalDeltager = value; }
        }
        
        public override string ToString()
        {
            return $"Aktivitet : {iD} \nAktivitetsnavn : {navn} \nAdresse : {adresse} \nAntal Deltager : {antalDeltager} \n";
        }
    }
}