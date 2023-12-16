using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musteri_Cekilis_Uygulamasi
{
    public static class Database
    {
        public static List<User> users = new List<User>()
        {
         new User()
         {
             Id = new Guid(),
             UserName = "neron",
             Password = "1234",
         }
        };

        public static List<Customers> customers = new List<Customers>();

        public static List<PromosyonUrun> Urun = new List<PromosyonUrun>()
        {
            new PromosyonUrun()
            {
                First = "%10 İndirim",
                Second = "%15 indirim",
                Third = "%20 İndirim",
                Fourth = "%30 İndirim",
                Fiveth = "%50 İndirim"
            }
        };

    }
}
