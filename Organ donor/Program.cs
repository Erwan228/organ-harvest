namespace Organ_donor
{
    internal class Sykehus
    {
        public class Pasient
        {
            public string Name { get; set; }
            public int SunneNyrer { get; set; }
            public Pasient(string name, int sunneNyrer)
            {
                Name = name;
                SunneNyrer = sunneNyrer;
            }
        }
        public static void Main(string[] args)
        {
            var person1 = new Pasient("Bernt", 0);
            var person2 = new Pasient("Kåre", 2);
            Console.WriteLine(person1.Name + " har " + person1.SunneNyrer + " sunne nyrer.");
            Console.WriteLine(person2.Name + " har " + person2.SunneNyrer + " sunne nyrer.");
            Console.WriteLine("Operasjonen skal starte. Vennligst aksepter denne ansvarsfraskrivelsen.");
            Console.ReadKey();
            TransferToBernt(person1, person2);
            Console.WriteLine("Operasjon utført.");
            Console.WriteLine($"{person1.Name} har nå fått en nyre fra {person2.Name}.");
            Console.WriteLine($"{person1.Name} har nå {person1.SunneNyrer} sunne nyrer. {person2.Name} har nå {person2.SunneNyrer} sunne nyrer");
        }
        public static void TransferToBernt(Pasient p1, Pasient p2)
        {
            if (p2.SunneNyrer > 0)
            {
                p2.SunneNyrer--;
                p1.SunneNyrer++;
            }
        }

    }
}