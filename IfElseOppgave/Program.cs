namespace IfElseOppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oppgave 1 = True hvis tallene er like");
            Console.WriteLine("Skriv første tall:");
            string Tall1 = Console.ReadLine();
            Console.WriteLine("Nice! Skriv så andre tall:");
            string Tall2 = Console.ReadLine();
            Console.WriteLine(Tall1 + " og " + Tall2 + "? La meg sjekke:");

            int Tall11 = Int32.Parse(Tall1);
            int Tall22 = Int32.Parse(Tall2);

            if (Tall1 == Tall2)
            {
                Console.WriteLine("Dette er samme tall, altså TRUE");
            }
            else
            {
                Console.WriteLine("Dette er ikke samme tall, dette er da FALSE");

            }
            Console.WriteLine("Vil du fortsette til oppgave 2?");
            string Oppg2 = Console.ReadLine();
            if (Oppg2 == "ja")
            {
                Console.WriteLine("Dette er oppgave 2");
                Console.WriteLine("Nå skal vi multiplisere tall");
                Console.WriteLine("Skriv første tall:");
                string Tall3 = Console.ReadLine();
                Console.WriteLine("Nice! Skriv så andre tall:");
                string Tall4 = Console.ReadLine();

                    int Tall33 = Int32.Parse(Tall3);
                    int Tall44 = Int32.Parse(Tall4);

                Console.WriteLine(Tall3 + " og " + Tall4);
                Console.WriteLine("Multiplisert, så blir det:");
                Console.WriteLine(Tall33 * Tall44);


            }
            else {
                Console.WriteLine("Den er grei, ha det bra!");

                    }

            


        }
    }
}