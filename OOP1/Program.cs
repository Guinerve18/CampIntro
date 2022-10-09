namespace OOP1
{
	class Program
	{
		static void Main(string[] agrs)
		{
			Product product1 = new Product();
			product1.id = 1;
			product1.categoryId = 1;
			product1.ProductName = "Masa";
			product1.unitPrice = 500;
			product1.unitsInStock = 3;

			Product product2 = new Product{id = 2, categoryId = 5, ProductName = "Kalem", unitPrice =35, unitsInStock = 5  };

			ProductManager productManager = new ProductManager();
			productManager.Add(product1);
		}
	}
}
