Console.WriteLine("Hello There!");

Jedi jedi1 = new Jedi();
jedi1.jediName = "Obi-Wan Kenobi";
jedi1.status = "Member of Jedi Council - Master";
jedi1.lightSaberColor = "Blue";

Jedi jedi2 = new Jedi();
jedi2.jediName = "Anakin Skywalker";
jedi2.status = "Jedi Knight - Master";
jedi2.lightSaberColor = "Blue";

Jedi jedi3 = new Jedi();
jedi3.jediName = "Master Yoda";
jedi3.status = "Member of the Jedi Council - Grand Master";
jedi3.lightSaberColor = "Green";

Jedi jedi4 = new Jedi();
jedi4.jediName = "Ahsoka Tano";
jedi4.status = "Jedi Knight - Padawan";
jedi4.lightSaberColor = "White";

Jedi jedi5 = new Jedi();
jedi5.jediName = "Kit Fisto";
jedi5.status = "Member of the Jedi Council - Master";
jedi5.lightSaberColor = "Green";

Jedi jedi6 = new Jedi();
jedi6.jediName =  "Mace Windu";
jedi6.status = "Member of the Jedi Council";
jedi6.lightSaberColor = "Purple";

Jedi jedi7 = new Jedi();
jedi7.jediName = "Plo Koon";
jedi7.status = "Member of the Jedi Council";
jedi7.lightSaberColor = "Blue";

Console.WriteLine(jedi1.jediName + " - " + jedi1.status + " - " + jedi1.lightSaberColor );

Jedi[] jedi = new Jedi[] {jedi1, jedi2, jedi3, jedi4, jedi5 ,jedi6, jedi7 };

foreach (Jedi jedies in jedi)
{
    Console.WriteLine(jedies.jediName + " - " + jedies.status + " - " + jedies.lightSaberColor);
}


class Jedi
{
    public string jediName { get; set; }
    public string status { get; set; }
    public string lightSaberColor { get; set; }
            
   
}











