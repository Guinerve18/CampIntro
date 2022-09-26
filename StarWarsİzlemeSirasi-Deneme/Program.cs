Console.WriteLine("Star Wars İzleme Sırası Tarihsel");

starWarsizlemetarihsel firstfilm = new starWarsizlemetarihsel();
firstfilm.sira = 1;
firstfilm.name = "Star Wars Episode IV - A New Hope";

starWarsizlemetarihsel second = new starWarsizlemetarihsel();
second.sira = 2;
second.name = "Star Wars Episode V - Empire Strikes Back";

starWarsizlemetarihsel third = new starWarsizlemetarihsel();
third.sira = 3;
third.name = "Star Wars Episıde VI - Return of the Jedi";

starWarsizlemetarihsel fourth = new starWarsizlemetarihsel();
fourth.sira = 4;
fourth.name = "Star Wars Episode I - Phantom Menance";

starWarsizlemetarihsel fifth = new starWarsizlemetarihsel();
fifth.sira = 5;
fifth.name = "Star Wars Episode II - Attack of the Clones";

starWarsizlemetarihsel sixth = new starWarsizlemetarihsel();
sixth.sira = 6;
sixth.name = "Star Wars Episode III - Revenge Of The Sith";

starWarsizlemetarihsel seventh = new starWarsizlemetarihsel();
seventh.sira = 7;
seventh.name = "Star Wars - Clone Wars (Film)";

starWarsizlemetarihsel eight = new starWarsizlemetarihsel();
eight.sira = 8;
eight.name = "Star Warc Clone Wars (series)";

starWarsizlemetarihsel ninth = new starWarsizlemetarihsel();
ninth.sira = 9;
ninth.name = "Star Wars - Rebels";

starWarsizlemetarihsel ten = new starWarsizlemetarihsel();
ten.sira = 10;
ten.name = "Star Wars Episode VII - Force Awaken";

starWarsizlemetarihsel eleven = new starWarsizlemetarihsel();
eleven.sira = 11;
eleven.name = "Star Wars - Resistance";

starWarsizlemetarihsel twelve = new starWarsizlemetarihsel();
twelve.sira = 12;
twelve.name = "Star Wars Episode VIII - The Last Jedi";

starWarsizlemetarihsel thirten = new starWarsizlemetarihsel();
thirten.sira = 13;
thirten.name = "The Mandolorian";

starWarsizlemetarihsel fourten = new starWarsizlemetarihsel();
fourten.sira = 14;
fourten.name = "Star Wars Episode IX - Rise of the Skywalker";

starWarsizlemetarihsel fifthten = new starWarsizlemetarihsel();
fifthten.sira = 15;
fifthten.name = "The Bad Batch";

starWarsizlemetarihsel sixten = new starWarsizlemetarihsel();
sixten.sira = 16;
sixten.name = "The Book of Boba Fett";

starWarsizlemetarihsel seventen = new starWarsizlemetarihsel();
seventen.sira = 17;
seventen.name = "Obi-Wan Kenobi";

starWarsizlemetarihsel eightten = new starWarsizlemetarihsel();
eightten.sira = 18;
eightten.name = "Andor";

starWarsizlemetarihsel[] content = new starWarsizlemetarihsel[] {firstfilm, second, third, fourth, fifth, sixth, seventh, eight, ninth, ten, eleven, twelve, thirten, fourten, fifthten, sixten, seventen, eightten};

foreach (starWarsizlemetarihsel contents in content)
{
    Console.WriteLine(contents.sira + ". " + contents.name);
}

class starWarsizlemetarihsel
{
    public int sira { get; set; }
    public string name { get; set; }
}