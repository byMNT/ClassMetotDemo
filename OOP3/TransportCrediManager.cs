using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TransportCrediManager : ICrediManager //credimanager ın fonksiyonlarını implemente ettikten sonra
                                                //artık herkes fonksiyonları kendi ihtiyacına göre yazabilir.
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
        }

        public void DoSomething()
        {
           
        }
    }
}
