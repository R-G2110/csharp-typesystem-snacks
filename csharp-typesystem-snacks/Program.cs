namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Snack 1
            Console.WriteLine("Snack 1:");
            Console.WriteLine("Il software stampa il numero maggiore tra i 2 numeri inseriti.");
            Console.WriteLine();

            //Inserimento del primo numero
            Console.Write("Inserisci il primo numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //Inserimento del secondo numero
            Console.Write("Inserisci il secondo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Definizione della variabile max tramite la funzione Math.Max(a, b)
            int max = Math.Max(num1, num2);

            //Stampa il numero maggiore tra i 2 numeri inseriti dalla tastiera
            Console.WriteLine($"Il numero maggiore è: {max}");

            //Separatore
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            //Separatore

            // Snack 2
            Console.WriteLine("Snack 2:");
            Console.WriteLine("Il software stampa prima la parola più corta, poi la parola più lunga.");
            Console.WriteLine();

            //Inserimento della prima parola
            Console.Write("Inserisci la prima parola: ");
            string word1 = Console.ReadLine().Trim();
            Console.Write("Inserisci la seconda parola: ");

            //Inserimento della seconda parola
            string word2 = Console.ReadLine().Trim();

            //Stampa se la lunghezza delle 2 parole inserite sono uguali 
            if (word1.Length == word2.Length) 
            {
                Console.WriteLine($"La lunghezza della prima parola e della seconda parola sono uguali.");
            }

            //Assegnazione della parola corta e parola lunga
            string shortStr = word1.Length < word2.Length ? word1 : word2;
            string longStr = word1.Length > word2.Length ? word1 : word2;

            //Stampa della parola corta e parola lunga
            Console.WriteLine($"La parola più corta è: {shortStr}, la parola più lunga è: {longStr}");

            //Separatore
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            //Separatore

            // Snack 3
            Console.WriteLine("Snack 3:");
            Console.WriteLine("Il software chiede per 10 volte di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.");
            Console.WriteLine();

            //Dichiarazione ed assegnazione della variabile somma
            int sum = 0;

            //Ciclo for per l'inserimento di 10 numeri
            for (int i = 0; i < 10; i++)
            {
                //Inserimento del numero
                Console.Write($"Inserisci il numero {i + 1}: ");
                int num = Convert.ToInt32(Console.ReadLine());

                //Somma il numero inserito nella variabile somma
                sum += num;
            }

            //Stampa della variabile somma
            Console.WriteLine($"La somma di tutti i numeri inseriti è: {sum}");

            //Separatore
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            //Separatore

            // Snack 4
            Console.WriteLine("Snack 4:");
            Console.WriteLine("Calcola la somma e la media dei numeri da 2 a 10.");

            //Dichiarazione ed assegnazione delle variabili somma e divisore per la media
            int sumSnack4 = 0;
            int averageDividerSnack4 = 0;

            //Ciclo partendo da 2 fino a 10 (compresso)
            for (int i = 2; i <= 10; i++) 
            {
                //Somma la variabile i nella variabile somma
                sumSnack4 += i;

                //Aumento della variabile divisore per la media
                averageDividerSnack4++;
            }

            //Stampa della variabile somma
            Console.WriteLine($"La somma dei numeri da 2 a 10 è: {sumSnack4}");

            //Stampa la media 
            Console.WriteLine($"La media dei numeri da 2 a 10 è: {sumSnack4 / averageDividerSnack4}");

            //Separatore
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            //Separatore

            // Snack 5
            Console.WriteLine("Snack 5:");
            Console.WriteLine("Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.");

            //Inserimento del numero
            Console.Write("Inserisci un numero: ");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            //Dichiarazione ed assegnazione con il controllo se pari o dispari
            int outputNum = inputNum % 2 == 0 ? inputNum : inputNum + 1;

            //Stampa del numero
            Console.WriteLine($"Il numero stampato è: {outputNum}");

            //Separatore
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            //Separatore

            
            // Snack 6
            Console.WriteLine("Snack 6:");
            Console.WriteLine("In una lista sono contenuti i nomi degli invitati alla festa del grande Gatsby. il software chiede  il nome dell’utente e comunica se può partecipare o meno alla festa.");
            
            //Dichiarazione e definizione dell'array
            string[] invitati = { "mario", "luigi", "peach", "yoshi", "toad" };

            //Inserimento del nome
            Console.Write("Inserisci il tuo nome: ");
            string nomeUtente = Console.ReadLine().ToLower();

            //Dichiarazione e definizione di una variabile booleana con una funzione Contains
            bool partecipa = invitati.Contains(nomeUtente);

            //Stampa del messaggio se l'utente può partecipare alla festa
            Console.WriteLine(partecipa ? "Sei invitato alla festa!" : "Mi dispiace, non sei invitato.");
            Console.WriteLine();

            //Lista dei partecipanti
            Console.WriteLine("Lista dei partecipanti: ");

            //Ciclo per stampare l'array 
            for (int i = 0; i <= invitati.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {invitati[i]} ");
            }


            //Separatore
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            //Separatore

            // Snack 7
            Console.WriteLine("Snack 7:");
            Console.WriteLine("Il software chiede per 6 volte all’utente di inserire un numero, se è dispari lo inserisce nell’array.");

            //Dichiarazione e definizione dell'array
            int[] numeriDispari = new int[6];

            //Ciclo for per l'inserimento di 6 numeri
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Inserisci il numero {i + 1}: ");
                int num = Convert.ToInt32(Console.ReadLine());

                //Controllo se il numero inserito è pari o dispari
                if (num % 2 != 0)
                {
                    //Inserimento del numero nell'array
                    numeriDispari[i] = num;
                }
            }

            //Stampa dell'array
            Console.WriteLine("Numeri dispari inseriti:");
            foreach (int num in numeriDispari)
            {
                if (num != 0)
                {
                    Console.WriteLine(num);
                }
            }

            //Separatore
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            //Separatore

            // Snack 8
            Console.WriteLine("Snack 8");
            int[] numeri = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int sumPosizioniDispari = 0;
            for (int i = 1; i < numeri.Length; i += 2)
            {
                sumPosizioniDispari += numeri[i];
            }
            Console.WriteLine($"La somma degli elementi in posizioni dispari è: {sumPosizioniDispari}");

            //Separatore
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            //Separatore

            // Snack 9
            Console.WriteLine("\nSnack 9");
            int[] numeriArray = new int[10];
            int sommaArray = 0;
            int index = 0;
            while (sommaArray < 50 && index < 10)
            {
                Console.Write("Inserisci un numero: ");
                int num = Convert.ToInt32(Console.ReadLine());
                numeriArray[index] = num;
                sommaArray += num;
                index++;
            }
            Console.WriteLine("Array completo:");
            foreach (int num in numeriArray)
            {
                Console.Write(num + " ");
            }

            //Separatore
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            //Separatore

            // Snack 10
            Console.WriteLine("\nSnack 10");
            Console.Write("Inserisci un numero (N): ");
            int N = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                int[] arrayCasuale = new int[10];
                Console.WriteLine($"Array {i + 1}:");
                for (int j = 0; j < 10; j++)
                {
                    arrayCasuale[j] = random.Next(1, 101);
                    Console.Write(arrayCasuale[j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
