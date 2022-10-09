using Methods;

namespace Methods
{
	class Program
	{
		static void Main(string[] agrs)
		{
			Product product1 = new Product();
			product1.Id = 01;
			product1.Name = "Blaster";
			product1.Fiyat = 300;
			product1.Aciklama = "Star Wars Replika Blaster!";

			Product product2 = new Product();
			product2.Id = 02;
			product2.Name = "Lightsaber";
			product2.Fiyat = 400;
			product2.Aciklama = "Star Wars Mavi Işın Kılıcı!";

			Product[] products = new Product[] { product1, product2 };

			foreach (Product product in products)
			{
				Console.WriteLine(product.Id + " - " + product.Name + " - " + product.Fiyat + "TL - " + product.Aciklama);
			}

			Console.WriteLine("-----------METHODS------------");

			//instans - örnek 
			//encapsulation = Kapsülleme - Kümeleme
			SepetManager sepetManager = new SepetManager();
			sepetManager.Ekle(product2);

			//sepetManager.Ekle2("Lightsaber", "Star Wars Mav ışın Kılıcı", 400, 3);
			sepetManager.Ekle2("Blaster", "Star Wars Replika Blaster", 300, 10);
		}
	}
}

