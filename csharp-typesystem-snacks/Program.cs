namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Snack 1
            Console.WriteLine("Snack 1:");

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
            string shortStr;
            string longStr;
            Console.Write("Inserisci la prima parola: ");
            string word1 = Console.ReadLine();
            Console.Write("Inserisci la seconda parola: ");
            string word2 = Console.ReadLine();
            if (word1.Length == word2.Length) 
            {
                Console.WriteLine($"La lunghezza della prima parola e della seconda parola sono uguali.");
            } else if (word1.Length > word2.Length)
            {
                longStr = word1;
                shortStr = word2;
                Console.WriteLine($"La parola più corta è: {shortStr}, la parola più lunga è: {longStr}");
            }
            else
            {
                longStr = word2;
                shortStr = word1;
                Console.WriteLine($"La parola più corta è: {shortStr}, la parola più lunga è: {longStr}");
            }
            
        }
    }
}
