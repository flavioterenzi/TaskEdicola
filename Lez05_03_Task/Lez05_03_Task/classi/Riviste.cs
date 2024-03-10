using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez05_03_Task.classi
{
    internal class Riviste: Pubblicazione
    {

        //-------------------Attributi------------------
        //public string? Titolo {  get; set; }
       // public string? Categoria {  get; set; }
       

        //--------------------Metodi---------------------

        public Riviste()
        {

        }
        public Riviste(string? titolo, string? categoria,DateTime data, float? prezzo, string? codice, int? cont) 
        
        {
            Titolo = titolo;
            Categoria = categoria;
            DataPubblicazione=data;
            Prezzo = prezzo;
            Codice = codice;
            Cont = cont;
        }

        public override void Stampa()
        {
            Console.WriteLine($"[RIVISTA] il titolo è: {Titolo}, La sua categoria è: {Categoria},la sua data di pubblicazione è: {DataPubblicazione} ,il suo prezzo è: {Prezzo}, il suo codice è: {Codice}, il numero di copie è: {Cont}\n -------------------------------");

        }

    }
}
