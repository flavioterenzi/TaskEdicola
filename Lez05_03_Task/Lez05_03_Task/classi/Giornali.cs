using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez05_03_Task.classi
{
    internal class Giornali: Pubblicazione
    {


        //-------------------Attributi------------------

        //private string? Redazione {  get; set; }
        private bool? HasInsert { get; set; }




        //--------------------Metodi---------------------


       
        public Giornali()
        {

        }

        public Giornali(string redazione, bool hasinsert,DateTime datapub ,float prezzo, string? codice, int? cont)
        {
            Titolo = redazione;
            HasInsert = hasinsert;
            DataPubblicazione = datapub;
            Prezzo = prezzo;
            Codice = codice;
            Cont = cont;
        }

        public override void Stampa()
        {
            Console.WriteLine($"[GIORNALE]  Redazione: {Titolo}, presenta l'inserto {HasInsert},la data di pubblicazione é: {DataPubblicazione}, il suo prezzo è di : {Prezzo}, il uo codice è: {Codice}, il numero di giornali rimasto è: {Cont}\n -------------------------------");
        }
        

    }
}
