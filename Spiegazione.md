# TASK

## Creazione classi

nel mio lavoro ho creato 4 classi, quella della libreria,quella della pubblicazione, quella dei giornali e quella delle riviste.

nella classe edicola ho inserito gli attributi:
Nome, indirizzo e una lista di oggetti Della classe Pubblicazione, successivamente ho creato dei metodi per la stampa dell'edicola, per la stampa in generale, per l'aggiunta di giornali o riviste, per la rimozione dei giornali solo se la quantità è uguale a quella presente nelledicola e delle classi per la ricerca (non funzionanti ancora).

nella classe Pubblicazione (classe astratta) ho inserito gli attributi codice, prezzo, contatore, categoria, titolo, datapubblicazione e un meetodo per la stampa

la classe giornale presenta l'attributo Hasinserto e il metodo per la stampa dei giornali oltre che un costruttore personalizato

la classe riviste non presenta attributi e il metodo per la stampa delle riviste oltre che un costruttore personalizzato

all'interno del main creato delle liste di oggetti statici e successivamente ho creato tramite gli switch case dei controlli sulle scelte dell'utente per potergli permettere la visualizzazione dei giornali/riviste, permette laggiunta, la rimozione e la ricerca di giornali o riviste oltre che l'uscita