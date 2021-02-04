using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //müşteri ebeveyndir.Müşteriyi inherit eden herkes müşterideki özelliklere sahiptir.
    //burada yazılanlar ise sadece buraya ait.Müşteriyi inherit ettiği için bir de müşterideki özellikler var. 
    class IndividualCustomer : Customer
    {
       
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNo { get; set; }
    }
}
