for (int i = 0; i <3; i++)
{
    Console.WriteLine(i);
}

string[] objects = new string[] { "Lightsaber", "Blaster", "Space Ship", "X-Wings", "Clone Suit", "Storm Trooper Suit", "Walkers", "Speeders", "Jedi Clothes", "Sith Clothes", "Hello There Wallpaper", "General Grevious Suit", "Darth Vader Suit"};

for (int i = 0; i < objects.Length; i++)
{
    Console.WriteLine(objects[i]);
}
Console.WriteLine("For Bitti!");

foreach (string objective in objects) //foreach dizidek elemanları tek tek dolaşır.
{
    Console.WriteLine(objective);
}

