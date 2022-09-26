Console.WriteLine("Envanter");

starWarsInventory z1 = new starWarsInventory();
z1.esya = "Blue Lightsaber";
z1.fiyat = 600;
z1.stok = 300;

starWarsInventory z2 = new starWarsInventory();
z2.esya = "Green Lightsaber";
z2.fiyat = 600;
z2.stok = 200;

starWarsInventory z3 = new starWarsInventory();
z3.esya = "Purple Lightsaber";
z3.fiyat = 500;
z3.stok = 190;

starWarsInventory z4 = new starWarsInventory();
z4.esya = "White Lightsaber - Ahsoka Tano Special Edition";
z4.fiyat = 1000;
z4.stok = 50;

starWarsInventory z5 = new starWarsInventory();
z5.esya = "Blue Lightsaber - Anakin Skywalker Special Edition";
z5.fiyat = 1500;
z5.stok = 50;

starWarsInventory z6 = new starWarsInventory();
z6.esya = "Blue Lightsaber - Obi-Wan Kenobi Special Edition";
z6.fiyat = 1500;
z6.stok = 50;

starWarsInventory z7 = new starWarsInventory();
z7.esya = "Green Lightsaber - Master Yoda Special Edition";
z7.fiyat = 2000;
z7.stok = 30;

starWarsInventory z8 = new starWarsInventory();
z8.esya = "Red Lightsaber";
z8.fiyat = 600;
z8.stok = 100;

starWarsInventory z9 = new starWarsInventory();
z9.esya = "Red Lightsaber - Darth Vader Special Edition";
z9.fiyat = 2000;
z9.stok = 50;

starWarsInventory z10 = new starWarsInventory();
z10.esya = "Red Lightsaber - Darth Maul Speial Edition";
z10.fiyat = 1000;
z10.stok = 50;

starWarsInventory z11 = new starWarsInventory();
z11.esya = "Red Lightsaber - Count Dooku Speial Edition";
z11.fiyat = 1000;
z11.stok = 50;

starWarsInventory z12 = new starWarsInventory();
z12.esya = "Red Lightsaber - Darth Sidious Speial Edition";
z12.fiyat = 1000;
z12.stok = 50;

starWarsInventory z13 = new starWarsInventory();
z13.esya = "Darth Vader Costume";
z13.fiyat = 2500;
z13.stok = 100;

starWarsInventory z14 = new starWarsInventory();
z14.esya = "Lego X-Wings";
z14.fiyat = 600;
z14.stok = 1000;

starWarsInventory z15 = new starWarsInventory();
z15.esya = "Blaster";
z15.fiyat = 300;
z15.stok = 900;

starWarsInventory z16 = new starWarsInventory();
z16.esya = "Lego Millenium Falcon";
z16.fiyat = 2000;
z16.stok = 10;

starWarsInventory z17 = new starWarsInventory();
z17.esya = "Chewbacca Costume";
z17.fiyat = 2000;
z17.stok = 20;

starWarsInventory z18 = new starWarsInventory();
z18.esya = "Lego Stormtroper";
z18.fiyat = 100;
z18.stok = 5000;

starWarsInventory z19 = new starWarsInventory();
z19.esya = "Stormtroper Costume";
z19.fiyat = 3000;
z19.stok = 50;

starWarsInventory z20 = new starWarsInventory();
z20.esya = "Lego Clones";
z20.fiyat = 100;
z20.stok = 5000;

starWarsInventory z21 = new starWarsInventory();
z21.esya = "CloneCostume";
z21.fiyat = 4000;
z21.stok = 70;

starWarsInventory z22 = new starWarsInventory();
z22.esya = "General Grevious Costume";
z22.fiyat = 9000;
z22.stok = 5;

starWarsInventory[] things = new starWarsInventory[] { z1, z2, z3, z4, z5, z6, z7, z8, z9, z10, z11, z12, z13, z14, z15, z16, z17, z18, z19, z20, z21, z22};

foreach (starWarsInventory thing in things)
{
    Console.WriteLine(thing.esya + ": " + thing.fiyat + "TL : " + thing.stok + "Tane" );
}

Console.WriteLine("-------------------------------------------------------------------------");
Console.WriteLine("-------------------------------------------------------------------------");
Console.WriteLine("-------------------------------------------------------------------------");

class starWarsInventory
{
    public string esya { get; set; }
    public int fiyat { get; set; }
    public int stok { get; set; }
}