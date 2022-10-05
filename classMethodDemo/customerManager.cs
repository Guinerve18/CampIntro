using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethodDemo
{
    internal class customerManager
    {
        public void save(Customer customerss)
        {
            Console.WriteLine("Yeni Üye Eklendi!" + " " + customerss.customerId + " " + customerss.Name + " " + customerss.Surname + " " + customerss.bday + " " + customerss.accountType + " " + customerss.joinDate);
        }

        public void del(Customer customerss)
        {
            Console.WriteLine("Kaydın Silindi!"+ customerss.Name + " " + "Aramızdan ayrıldığın İçin Çok Üzgünüz! :(");
        }
    }
}
