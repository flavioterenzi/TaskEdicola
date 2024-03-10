using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez05_03_Task.classi
{
    internal abstract class Pubblicazione
    {
        //-------------------Attributi------------------
        public string? Codice { get; set; }
        protected float? Prezzo {  get; set; }

       public int? Cont {  get; set; }
        public string? Categoria {get; set; }

        public string? Titolo { get; set; }


        public DateTime? DataPubblicazione { get; set; }

        //--------------------Metodi---------------------

        public abstract void Stampa();
    }

   
}
