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
            Console.WriteLine("Snack 2");
            Console.Write("Inserisci la prima parola: ");
            string word1 = Console.ReadLine();
            Console.Write("Inserisci la seconda parola: ");
            string word2 = Console.ReadLine();
            if (word1.Length == word2.Length) 
            {
                Console.WriteLine($"La lunghezza della prima parola e della seconda parola sono uguali.");
            }
            string shortStr = word1.Length < word2.Length ? word1 : word2;
            string longStr = word1.Length > word2.Length ? word1 : word2;
            Console.WriteLine($"La parola più corta è: {shortStr}, la parola più lunga è: {longStr}");

            //Separatore
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            //Separatore

            // Snack 3
            Console.WriteLine("Snack 3");
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Inserisci il numero {i + 1}: ");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine($"La somma di tutti i numeri inseriti è: {sum}");

            //Separatore
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            //Separatore

            // Snack 4
            Console.WriteLine("Snack 4");
            int sumSnack4 = 0;
            int averageDividerSnack4 = 0;
            for (int i = 2;i <= 10;i++) 
            {
                sumSnack4 += i;
                averageDividerSnack4++;
            }
            Console.WriteLine($"La somma dei numeri da 2 a 10 è: {sumSnack4}");
            Console.WriteLine($"La media dei numeri da 2 a 10 è: {sumSnack4 / averageDividerSnack4}");

            //Separatore
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            //Separatore

            // Snack 5
            Console.WriteLine("Snack 5");
            Console.Write("Inserisci un numero: ");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            int outputNum = inputNum % 2 == 0 ? inputNum : inputNum + 1;
            Console.WriteLine($"Il numero stampato è: {outputNum}");

            //Separatore
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            //Separatore

            
            // Snack 6
            Console.WriteLine("Snack 6");
            string[] invitati = { "mario", "luigi", "peach", "yoshi", "toad" };
            Console.Write("Inserisci il tuo nome: ");
            string nomeUtente = Console.ReadLine().ToLower();
            bool partecipa = invitati.Contains(nomeUtente);
            Console.WriteLine(partecipa ? "Sei invitato alla festa!" : "Mi dispiace, non sei invitato.");


            //Separatore
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            //Separatore

            // Snack 7
            Console.WriteLine("\nSnack 7");
            int[] numeriDispari = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Inserisci il numero {i + 1}: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 != 0)
                {
                    numeriDispari[i] = num;
                }
            }
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
