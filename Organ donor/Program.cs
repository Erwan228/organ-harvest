namespace Organ_donor
{
    internal class Sykehus
    {
        public class Pasient
        {
            public string Name { get; private set; }
            public int SunneNyrer { get; private set; }
            public Pasient(string name, int sunneNyrer)
            {
                Name = name;
                SunneNyrer = sunneNyrer;
            }
        }
        public static void Main(string[] args)
        {
            var person1 = new Pasient("Bernt", 0);
            var person2 = new Pasient("kåte Kåre", 2);
            Console.WriteLine(person1.Name + " har " + person1.SunneNyrer + " sunne nyrer.");
            Console.WriteLine(person2.Name + " har " + person2.SunneNyrer + " sunne nyrer.");

        }

    }
}