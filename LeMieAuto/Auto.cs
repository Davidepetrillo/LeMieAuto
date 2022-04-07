using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieClassi
{
    internal class Auto
    {
        public string marca;
        public string modello;
        public int annoDiProduzione;
        public string targa;
        public string colore;

        public bool accesa;

        /*
         {

        // se non voglio lasciare agli altri di accedere e modificare i miei elementi
        private string marca;
        private string modello;
        private int annoDiProduzione;
        private string targa;
        private string colore;

        private bool accesa;

        */

        //           al'interno sono variabili locali non devono avere lo stesso nome di quelle globali

        /*
        public Auto(string marcaAuto, string modelloAuto, int annoDiProduzioneAuto, string targaAuto, string coloreAuto)
        {
            marca = marcaAuto;
            modello = modelloAuto; 
            annoDiProduzione = annoDiProduzioneAuto;   
            colore = coloreAuto;
            if(targaAuto.Length == 8)
            {
                targa = targaAuto;
            } else
            {
                Console.WriteLine("Mi dispiace ma la targa non è di 8 cifre");
            }

            accesa = false;
        }
        */

        // Questo è equivalente a quello scritto sopra ma più corretto!!
        public Auto(string marca, string modello, int annoDiProduzione, string targa, string colore)
        {
            this.marca = marca;
            this.modello = modello;
            this.annoDiProduzione = annoDiProduzione;
            this.colore = colore;
            if(targa.Length == 8)
            {
                this.targa = targa;
            }

            this.accesa = false;
        }
        


        public void Accenditi()
        {
            Console.WriteLine("VROOOOOOM");
            accesa = true;
        }

        public void Spegniti()
        {
            Console.WriteLine("ZZZZZZZZZ");
            accesa = false;
        }

        public void RiverniciaAuto(string nuovoColore)
        {
            colore = nuovoColore;
        }
    }
}
