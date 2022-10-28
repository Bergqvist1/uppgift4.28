using System; 
    namespace uppgift_4_28
    {

        class Program
        {

          static void Main(string[]args )
          {

            Console.WriteLine("Skriv in en text sträng");
            string sträng = Console.ReadLine();

            Console.WriteLine("Skriv in en till sträng med 2 bokstäver");
            string Kollen = Console.ReadLine();

            char[] check = Kollen.ToCharArray();

            if (sträng.Contains(check[0]) && sträng.Contains(check[1]))
            {
                Console.WriteLine("Din text sträng innehåller båda tecekn");
            }
            else if (sträng.Contains(check[0]) || sträng.Contains(check[1]))
            {
                Console.WriteLine("Din text sträng innehåller 1 av dina 2 bokstäver");
            }
            else
            {
                Console.WriteLine("Din text sträng innehåller inga bokstäver som du har skrivit");
            }
            






          }

        }

    }