using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class SepetManager
    {
        // naming convention - isimlendirme Kuralı
        //Syntax / Python def
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete Eklendi! : " + product.Name + " " + product.Aciklama);
        }

        public void Ekle2(string Name, string Aciklama, double Fiyat, int stokAdedi)
        {

        }
    }
}
