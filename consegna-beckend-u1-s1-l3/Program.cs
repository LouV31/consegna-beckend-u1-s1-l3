using System;
using System.Linq;

namespace consegna_beckend_u1_s1_l3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Esercizio n°1

            /*Console.WriteLine("Benvenuto, puoi creare il tuo nuovo conto. \nInserisci il tuo nome: ");
            string name = Console.ReadLine();
            Console.WriteLine("Inserisci il tuo cognome: ");
            string surname = Console.ReadLine();
            Console.WriteLine($"Per aprire il conto devi versare almeno 1000 euro");

            bool open = false;
            do
            {
                int money;
                do
                {
                    Console.WriteLine("Inserisci l'importo: ");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out money))
                    {
                        Console.WriteLine("Input non valido. Inserisci un valore numerico.");
                    }
                    else if (money < 1000)
                    {
                        Console.WriteLine("Con questo importo non puoi aprire un conto. Devi depositare almeno 1000 Euro. Vuoi continuare ed inserire l'importo? Digita y/n");
                        string scelta;
                        do
                        {
                            scelta = Console.ReadLine().ToLower();
                            if (scelta != "y" && scelta != "n")
                            {
                                Console.WriteLine("Input non valido. Digita y/n.");
                            }
                        } while (scelta != "y" && scelta != "n");

                        if (scelta == "n")
                        {
                            Console.WriteLine("Grazie, ciao.");
                            return;
                        }
                    }
                } while (money < 1000);

                open = true;
                Console.WriteLine("Congratulazioni, hai aperto il tuo conto corrente.");
                ContoCorrente conto1 = new ContoCorrente(name, surname, money, open);
                conto1.GetInfo();
                bool ripeti = false;

                do
                {

                    Console.WriteLine("Desideri effettuare delle operazioni? y/n");
                    string scelta2;

                    do
                    {
                        scelta2 = Console.ReadLine().ToLower();
                        if (scelta2 != "y" && scelta2 != "n")
                        {
                            Console.WriteLine("Input non valido. Digita y/n.");
                        }
                    } while (scelta2 != "y" && scelta2 != "n");

                    if (scelta2 == "n")
                    {

                        Console.WriteLine("Grazie, ciao.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Scegli 1 per effettuare un VERSAMENTO oppure 2 per effettuare un prelievo");
                        string scelta3 = Console.ReadLine();
                        switch (scelta3)
                        {
                            case "1":
                                Console.WriteLine("Inserisci l'importo che vuoi depositare: ");
                                double deposito;
                                while (!double.TryParse(Console.ReadLine(), out deposito))
                                {
                                    Console.WriteLine("Importo non valido");
                                }
                                string messaggio = conto1.Payment(deposito);
                                Console.WriteLine(messaggio);
                                ripeti = false;
                                break;

                            case "2":
                                Console.WriteLine("Inserisci l'importo che desideri prelevare: ");
                                double prelevato;
                                while (!double.TryParse(Console.ReadLine(), out prelevato))
                                {
                                    Console.WriteLine("Importo non valido");
                                }
                                string messaggio2 = conto1.Withdrawal(prelevato);
                                Console.WriteLine(messaggio2);

                                ripeti = false;
                                break;
                            default:
                                break;
                        }
                    }

                } while (!ripeti);


            } while (!open);*/


            // Esercizio n°2

            /* Console.WriteLine("Inserisci il valore di lunghezza che desideri dare all'array");
             bool esci = false;
             int arrLength;
             while (!int.TryParse(Console.ReadLine(), out arrLength))
             {
                 Console.WriteLine("Inserisci una lunghezza numerica valida");
             }
             string[] arrNomi = new string[arrLength];

             for (int i = 0; i < arrNomi.Length; i++)
             {
                 Console.WriteLine($"Inserisci il nome numero {i + 1}");
                 arrNomi[i] = Console.ReadLine();
             }
             while (!esci)
             {

                 Console.WriteLine("Inserisci il nome da cercare");
                 string nomeCercato = Console.ReadLine();
                 bool trovato = false;
                 foreach (string nome in arrNomi)
                 {
                     if (nome.Equals(nomeCercato, StringComparison.OrdinalIgnoreCase))
                     {
                         trovato = true;
                         break;
                     }

                 }
                 if (trovato)
                 {
                     Console.WriteLine($"{nomeCercato} è presente nell'array");
                 }
                 else
                 {

                     Console.WriteLine($"{nomeCercato} non è presente nell'array");
                 }

                 Console.WriteLine("Vuoi cercare un altro nome? \nDigita y per continuare a cercare oppure n per uscire dal programma.");
                 string scelta = Console.ReadLine();
                 while (scelta != "y" && scelta != "n")
                 {
                     Console.WriteLine("input non valido.");
                 }
                 if (scelta == "n")
                 {
                     esci = true;
                 }

             } */

            // Esercizio n°3

            Console.WriteLine("Inserisci il valore di lunghezza che desideri dare all'array");
            int arrLength;
            while (!int.TryParse(Console.ReadLine(), out arrLength))
            {
                Console.WriteLine("Inserisci una lunghezza numerica valida");
            }

            int[] arrNum = new int[arrLength];

            for (int i = 0; i < arrNum.Length; i++)
            {
                Console.WriteLine($"Inserisci il numero {i + 1} di {arrNum.Length}");
                arrNum[i] = Convert.ToInt16(Console.ReadLine());
            }

            int somma = arrNum.Sum(i => i);
            int media = somma / arrLength;

            Console.WriteLine($"La somma di tutti i numeri inseriti nell'array è: {somma}");
            Console.WriteLine($"La media aritmetica dei numeri inseriti nell'array è: {media}");






            Console.ReadLine();

        }
    }
}
