namespace Esercizio2
{
    internal class Persona

    {
        public string Nome { get; set; }

        public string Cognome { get; set; }
        public int Eta { get; set; }
        // di seguiot ho inserito tutti campi 0 perchè facenti parti di metodi diversi
        public void getnome()
        {
            Console.WriteLine("nome {0}", Nome);
        }
        public void getcognome()
        {
            Console.WriteLine("cognome {0}", Cognome);
        }
        public void geteta()
        {
            Console.WriteLine("età {0}", Eta);
        }
        // qui ho inserito 0,1,2, perchè tutti appartententi allo stesso metodo 
        public void Dettagli()

        {
            Console.WriteLine("Questi sono i dettagli della persona {0} {1} {2}", Nome, Cognome, Eta);
        }
        static void Main(string[] args)
        {
            Persona andrea = new Persona();
            andrea.Nome = "Andrea";
            andrea.Cognome = "Andrei";
            andrea.Eta = 22;

            Persona lorenzo = new Persona();
            lorenzo.Nome = "Lorenzo";
            lorenzo.Cognome = "Scritto";
            lorenzo.Eta = 23;


        }
    }
}