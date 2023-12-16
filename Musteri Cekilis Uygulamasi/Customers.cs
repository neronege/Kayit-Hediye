using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musteri_Cekilis_Uygulamasi
{
    public class Customers
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
       
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public string TCKimlikNo { get; set; }
        public string Gender { get; set; }
        public string Job { get; set; }

    }
}
