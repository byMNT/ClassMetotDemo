using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerId = "12345";
            customer1.Id = 1;
            customer1.Name = "Nurfem";
            customer1.Surname = "Taysı";
            customer1.TcNo = "11111";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.CustomerId = "54321";
            customer2.Id = 2;
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "222222";

            //gerçek ve tüzel sırf birbirine benziyor diye birbirlerinin yerine kullanılamazlar!
            //müşteri ve şirket gibi düşün 
            //SOLID in L si oluyor bu.(Yazılım geliştrime prensipleri)

            Customer customer3 = new IndividualCustomer(); //bir yerde new görüyorsan bil ki orada bir ref numarası var
            Customer customer4 = new CorporateCustomer();//customer burada hem individualcustomer ın hem de corporatecustomer ın 
                                                         //referansını tutar.şimdi customermanager instance ını oluştur.

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1); //add fonksiyonu benden bir customer istiyor.
                                            //şimdi hangisini verirsen ver sıkıntı olmaz çünkü Customer hepsinin referansını tutuyor
                                            //inheritance de işte tam bu.Base sınıfın onu inherit eden sınıfların referansını tutması
        }
    }
}
