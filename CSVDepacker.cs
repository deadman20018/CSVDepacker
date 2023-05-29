using System;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;

namespace CSVDepacker
{
    class CSVDepacker
    {
        static void Main(string[] args)
        {
            try
            {
                // Questa variabile è il percorso del file CSV passato come argomento
                string csvFile = args[0];
                // Questo sarà l'indice di colonna convertito in un intero utilizzando int.Parse
                int columnIndex = int.Parse(args[1]);
                // Questa è la chiave di ricerca
                string key = args[2];

                // Apri il file CSV in lettura utilizzando StreamReader
                using (var reader = new StreamReader(csvFile))
                {
                    // Creiamo l'istanza di CSV Reader utilizzando CsvHelper
                    using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        Delimiter = ",",
                        HasHeaderRecord = false
                    }))
                    {
                        // Iteriamo su ogni riga del file CSV
                        while (csv.Read())
                        {
                            // Ottieni i dati del record corrente e li convertiamo in un dizionario
                            var record = csv.GetRecord<dynamic>() as IDictionary<string, object>;

                            // Verifichiamo se la chiave di ricerca corrisponde alla colonna specificata
                            if (IsKeyMatch(record, columnIndex, key))
                            {
                                // Ottieni i valori del record e li unisci in una stringa utilizzando la virgola come delimitatore
                                var values = new List<string>();
                                foreach (var item in record)
                                {
                                    values.Add(item.Value.ToString());
                                }
                                var line = string.Join(",", values);

                                // Stampa la riga corrispondente
                                Console.WriteLine(line);
                                break; // Esci dal loop dopo aver trovato la corrispondenza
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }

        static bool IsKeyMatch(IDictionary<string, object> record, int columnIndex, string key)
        {
            // Verifica se l'indice di colonna è valido
            if (columnIndex >= 0 && columnIndex < record.Count)
            {
                // Ottieni i valori del record
                var values = new List<object>(record.Values);

                // Verifica se il valore nella colonna corrisponde alla chiave di ricerca
                var value = values[columnIndex];
                if (value != null && value.ToString() == key)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
