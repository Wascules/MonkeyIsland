namespace MonkeyIsland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            
            Meer meer = new Meer();
            Schiff schiff = new Schiff();
            //lege Insel objekt an
            Insel insel_1 = new Insel("Mêlée Island", "Nebelsand", "Der Dreiköpfigeaffe");
            Insel insel_2 = new Insel("Monkey Island", "Affenstrand", "Bar");
            Insel insel_3 = new Insel("Skullisland", "Karninchen-Strand", "Piraten Poker");
            //lege Spielfigur an
            Spielfigur guybrush = new Spielfigur();
            guybrush.SetName("Guybrush Threepwood");

            meer.AddInsel(insel_1);
            meer.AddInsel(insel_2);
            meer.AddInsel(insel_3);
            
            
            //hiermit gehen wir über Insel und die Spielfigur weiß nicht wo sie ist 
            //insel.GetStrand().SetSfpp(guybrush);
            //insel.GetKneipe().SetSfpp(guybrush) = guybrush; //einfacher weg reicht aber nicht
            //insel.GetStrand().SetSfpp(null);                //so wird die spielfigur nicht immer verdoppelt
            
            guybrush.SetStrandPosition(guybrush.GetStrandPosition());

            
            //Pirat leChuck = new Pirat();

            meer.SetSchiff(schiff);
            Console.WriteLine(meer.GetSchiff().GetHashCode());
            

            Console.ReadKey();

        }
    }
}