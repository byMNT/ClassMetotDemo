using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Business classes- İş sınıfları
    //burada yapacağım işleri her tarzdaki müşteri için yapmak istiyoruz
    //O yüzden bu sınıfa customer sınıfını inherit ediyoruz.Herkes için aynı özellikleri kullanabilmek için
    //müşteride var olan özellikler inheritance dan sonra artık tüzelde de, bireyselde de var kabul edilir.
    class CorporateCustomer : Customer
    {
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}
