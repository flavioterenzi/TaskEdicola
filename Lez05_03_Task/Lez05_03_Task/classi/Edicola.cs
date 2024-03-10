using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez05_03_Task.classi
{
    internal class Edicola
    {

        //-------------------Attributi------------------


        private string? Nome { get; set; }
        private string? Indirizzo { get; set; }
        public List<Pubblicazione> Magazzino { get; set; } = new List<Pubblicazione>();

        //public  string? Ricerca { get; set; }



        //--------------------Metodi---------------------




        public Edicola(string? nome, string? indirizzo)
        {
            Nome = nome;
            Indirizzo = indirizzo;
        }

        public void aggiungi(Pubblicazione pub)
        {
            Magazzino.Add(pub);
        }


        //----------------------------------------------------



        public void rimuovi(Pubblicazione pub, string? ricerca, int num )
        {
            for (int i = 0; i < Magazzino.Count; i++)
            {
                if (Magazzino[i].Cont.Equals(num))
                {

                    if (Magazzino[i].Codice.Equals(ricerca))
                    {

                        Magazzino.RemoveAt(i);
                        Console.WriteLine("eliminazione successa");
                    }

                } else if (Magazzino[i].Cont < num)
                {
                    Console.WriteLine("stock finito");

                } else if (Magazzino[i].Cont > num)
                {
                    Magazzino[i].Cont = Magazzino[i].Cont - num;
                }





            }
        }

        //---------------------------------------------------------



            public void StampaDettaglio()
            {
                foreach (Pubblicazione pub in Magazzino)
                {
                    pub.Stampa();
                }
            }

        //---------------------------------------------------

            public void StampaEdicola()
            {
                Console.WriteLine($"[EDICOLA] {Nome}  {Indirizzo} \n -------------------------------");
            }

        //------------------------------------------------------

        public void RicercaTitolo (Pubblicazione pub, string titolo)
        {

            for(int i = 0;i < Magazzino.Count;i++)
            {

                    if (Magazzino[i].Titolo.Equals(titolo))
                    {
                        pub.Stampa();

                    } else
                {
                    Console.WriteLine("non trovato"); 
                }
                
             


            }



        }

        //------------------------------------------


        public void RicercaData(Pubblicazione pub, DateTime data)
        {

            for (int i = 0; i < Magazzino.Count; i++)
            {

                if (Magazzino[i].DataPubblicazione.Equals(data))
                {
                    pub.Stampa();

                }
                else
                {
                    Console.WriteLine("non trovato");
                }




            }



        }

        //-----------------------------------------


        public void RicercaCategoria(Pubblicazione pub, string cate)
        {

            for (int i = 0; i < Magazzino.Count; i++)
            {

                if (Magazzino[i].Categoria.Equals(cate))
                {
                    pub.Stampa();

                }
                else
                {
                    Console.WriteLine("non trovato");
                }




            }



        }





    }
}

