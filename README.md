CSVDepacker - Estrazione di una riga da un file CSV in base a una chiave di ricerca e un indice di colonna.

Assunzione:
    Il programma è case sensitive.

Utilizzo:
    Search <fileCSV> <indiceColonna> <chiaveRicerca>
Argomenti:
    <fileCSV>: Percorso del file CSV da cui estrarre la riga.
    <indiceColonna>: Indice della colonna su cui eseguire la ricerca (0-based).
    <chiaveRicerca>: Chiave da cercare nella colonna specificata.
 
Funzionalità:
    Il programma legge il file CSV specificato e cerca la prima riga in cui il valore nella colonna corrisponde alla chiave di ricerca.
    Quando viene trovata una corrispondenza, viene stampata la riga corrispondente.
Dipendenze:
    - CsvHelper: È necessario installare il pacchetto NuGet "CsvHelper" per la lettura e la scrittura dei file CSV.
Test:
    Per i test sul programma c'è sia l'esempio dato nella mail ma anche degli altri creati da me per verificare la validità del codice. Questi si possono trovare nella cartella test, nel file Test.bat. Per eseguire i test basta accedere alla cartella dove si ha installato il programma tramite una powershell eseguire i comandi:

    cd ./test
    ./Test.bat
