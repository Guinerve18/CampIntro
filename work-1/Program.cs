Console.WriteLine("Hello There!");

starWarsThings pm = new starWarsThings();
pm.Films = "Star Wars 1 - Phantom Menance";
pm.Series = "Mandolorian";
pm.Animations = "Star Wars - Clone Wars";

starWarsThings aotc = new starWarsThings();
aotc.Films = "Star Wars 2 - Attack of the Clones";
aotc.Series = "The Book of Boba Fett";
aotc.Animations = "The Bad Batch";

starWarsThings rots = new starWarsThings();
rots.Films = "Star Wars 4 - Revenge of the Sith";
rots.Series = "Obi- Wan Kenobi";
rots.Animations = "Star Wars - Rebels ";

starWarsThings anh = new starWarsThings();
anh.Films = "Star Wars 4 - A New Hope";
anh.Animations = "Star Wars The Resistance";

starWarsThings[] things = new starWarsThings[] { pm, aotc, rots, anh };
foreach (starWarsThings envanter in things)
{
    Console.WriteLine(envanter.Films + ", " + envanter.Series + ", " + envanter.Animations);
}

class starWarsThings
{
    public string Films { get; set; }
    public string Series { get; set; }
    public string Animations { get; set; }
}