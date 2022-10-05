namespace classMethodDemo
{
	class bankDatabase
	{
		static void Main(string[] agrs)
		{
			Customer c1 = new Customer();
			c1.customerId = 01;
			c1.Name = "Boran";
			c1.Surname = "Kumlu";
			c1.bday = "12/07/2004";
			c1.joinDate = "05/08/2019";
			c1.accountType = "Personal Account";

			Customer c2 = new Customer();
			c2.customerId = 02;
			c2.Name = "Ali Can";
			c2.Surname = "Deus";
			c2.bday = "15/09/2000";
			c2.joinDate = "27 / 02 / 2012";
			c2.accountType = "Student Account";

			Customer c3 = new Customer();
			c3.customerId = 03;
			c3.Name = "Enis Efe";
			c3.Surname = "Kumlu";
			c3.bday = "18 / 12 / 2004";
			c3.joinDate = "18 / 12 / 2016";
			c3.accountType = "Student Account";

			Customer c4 = new Customer();
			c4.customerId = 04;
			c4.Name = "Ahiflksh Holding";
			c4.Surname = "Corp";
			c4.bday = "24 / 06 / 2020";
			c4.joinDate = "25 / 06 / 2020";
			c4.accountType = "Corporation Account";

			Customer c5 = new Customer();
			c5.customerId = 05;
			c5.Name = "Ozan";
			c5.Surname = "Cansız";
			c5.bday = "03 / 03 / 2003";
			c5.joinDate = "31 / 01 / 2021";
			c5.accountType = "Personal Account";

            Customer[] customers = new Customer[] { c1, c2, c3, c4, c5 };
			foreach (Customer customerss in	customers)
			{
				Console.WriteLine(customerss.customerId + " " +"Adı: " + customerss.Name + " " +"Soyadı: " + customerss.Surname + " " +"Doğum Tarihi: " + customerss.bday + " " +"Kayıt Tarihi: " + customerss.joinDate +  " " +"Hesap Türü: " + customerss.accountType);
			}

			customerManager cman = new customerManager();
			cman.save(c1);

			customerManager cust = new customerManager();
			cust.del(c4);



        }
	}
}
