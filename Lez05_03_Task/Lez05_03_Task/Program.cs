using Lez05_03_Task.classi;
using System.Security.Cryptography;

namespace Lez05_03_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //--------------Liste--------------------
            Giornali gio = new Giornali();

            Giornali gioUno = new Giornali("Corriere della sera", false, new DateTime(2024,10,25) ,1.0f, "AA123", 3);

            Riviste rivUno = new Riviste("tutto sera", "gossip", new DateTime(2023,4,25),2.5f, "BB123", 4);
            Riviste riv =new Riviste();

            Edicola edi = new Edicola("New edicola", "via da qui, 24");



            //-------------------------------

            Console.WriteLine($"Benvenuti nella libreria");
            edi.StampaEdicola();

            edi.aggiungi(gioUno);
            edi.aggiungi(rivUno);

            //------------variabili-----------

            string nome;
            bool Has;
            float costo;
            string? codice;
            int numero;
            string? ris;
            string? Categoria;
            string? Ricerca;
            DateTime data;
            string path = "Users\\utente\\desktop\\task\\task.txt"; ;
          
            do
            {
                bool bo = true;
                Console.WriteLine("0 per visualizzare tutti i giornali e riviste \n inserire 1 per aggiungere\n 2 per rimuovere\n 3 per cercare\n 4 per vendere \n Q per uscire");
                ris = Console.ReadLine();
                

                while (bo==true)



                {
                    switch (ris)
                    {
                        case "0":

                            edi.StampaDettaglio();
                            //ris = "";
                            bo = false;
                            break;


                        case "1":

                            Console.WriteLine("vuoi aggiungere un giornale o una rivista?");
                            string scelta = Console.ReadLine();
                            if (scelta == "giornale")
                            {
                                Console.WriteLine("inserire Nome giornale: ");
                                nome = Console.ReadLine();

                                Console.WriteLine("inserire se ha un inserto true, se non lo ha false: ");
                                Has = Convert.ToBoolean(Console.ReadLine());

                                Console.WriteLine("inserire data pubblicazione");
                                data=Convert.ToDateTime(Console.ReadLine());

                                Console.WriteLine("inserire prezzo giornale: ");
                                costo = float.Parse(Console.ReadLine());

                                Console.WriteLine("inserire codice giornale: ");
                                codice = Console.ReadLine();

                                Console.WriteLine("inserire numero di copie da inserire giornale: ");
                                numero = Convert.ToInt32(Console.ReadLine());

                                 gio = new Giornali(nome, Has,data, costo, codice, numero);

                                edi.aggiungi(gio);


                                //edi.StampaDettaglio();

                                //ris = "";
                                bo = false;
                                break;
                            } else
                            {
                                Console.WriteLine("inserire Nome rivista: ");
                                nome = Console.ReadLine();


                                Console.WriteLine("inserire prezzo rivista: ");
                                costo = float.Parse(Console.ReadLine());

                                Console.WriteLine("inserire Caegoria rivista: ");
                                Categoria = Console.ReadLine();
                                Console.WriteLine("inserire data di pubblicazione");
                                data= Convert.ToDateTime(Console.ReadLine());

                                Console.WriteLine("inserire Codice rivista : ");
                                codice = Console.ReadLine();

                                Console.WriteLine("inserire numero di copie da inserire rivista: ");
                                numero = Convert.ToInt32(Console.ReadLine());

                                 riv = new Riviste(nome, Categoria,data, costo, codice, numero);

                                edi.aggiungi(riv);


                                

                                //ris = "";
                                bo = false;
                                break;
                            }
                        //-----------------------------------------------
                        case "2":

                            Console.WriteLine("vuoi selezionare giornali o riviste");
                            Ricerca=Console.ReadLine();


                            try
                            {
                                if (Ricerca.Equals("giornale"))
                                {
                                    Console.WriteLine("inserisci codice a eliminare di un giornale");
                                    codice = Console.ReadLine();

                                    Console.WriteLine("quante copie vuoi eliminare?");
                                    numero = Convert.ToInt32(Console.ReadLine());

                                    

                                    edi.rimuovi(gio,codice, numero);
                                    
                                }
                                else
                                {
                                    Console.WriteLine("inserisci codice a eliminare di un giornale");
                                    codice = Console.ReadLine();

                                    Console.WriteLine("quante copie vuoi eliminare?");
                                    numero = Convert.ToInt32(Console.ReadLine());



                                    edi.rimuovi(riv, codice, numero);

                                }
                            } catch (Exception e)
                            {
                                Console.WriteLine("Errore");
                            }



                            bo = false;
                            break;


                        //-------------------------------------------------
                        case "3":
                            Console.WriteLine("per cosa vuoi effettiare la ricerca cercare?\n -------------");
                            Console.WriteLine("1 per titolo -------- 2 per la data --------- 3 per la categoria");
                            Ricerca = Console.ReadLine();

                            switch (Ricerca)
                            {
                                case "1":
                                    Console.WriteLine("inserisci titolo da cercare");
                                    nome = Console.ReadLine();

                                    edi.RicercaTitolo(gio, nome);

                                    break;

                                    case "2":
                                    Console.WriteLine("inserisci data da cercare");
                                    data = Convert.ToDateTime(Console.ReadLine());

                                    edi.RicercaData(gio, data);
                                    break;

                                    case "3":
                                    Console.WriteLine("inserisci Categoria da cercare");
                                    Categoria = Console.ReadLine();

                                    edi.RicercaTitolo(gio, Categoria);
                                    break;


                            }


                            bo =false;
                            break;
                            






                        //------------------------------------------------
                        case "4":
                            break;




                        //------------------------------------------------

                        case "Q":
                            bo = false;
                            ris = "";
                            break;


                    }
                }


            } while ( ris!="");
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    edi.StampaDettaglio();
                }
            } catch(Exception ex)
            {

            }
            Console.WriteLine("Arrivederci");


        }
    }
}
