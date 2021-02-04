using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalFinanceCrediManager : ICrediManager //credimanager ın fonksiyonlarını implemente ettikten sonra
                                                      //artık herkes fonksiyonları kendi ihtiyacına göre yazabilir.
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }

        public void DoSomething()
        {
            
        }
    }
}
