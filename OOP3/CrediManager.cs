using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //aynı imzalı fonksiyonlarda kimi zaman farklı işler yapmak durumunda kalabiliriz.
    //interfaceler burada devreye giriyor.
    //birbirlerinin alternatifi olacak methotları bir araya toplayıp ihtiyaca göre metodu düzenleriz.
    interface ICrediManager //interface şablon görevi görür
                            //biri interface kullanırsa içindeki metodlardı kullanmak zorundadır
                            //okunurluğu artırması açısından interface olduğunu belli etmek için başına I harfi koyarız
                            //burada olan fonksiyonlar her kredide olmak zorundadır.O yüzden interface olarak tanımladık
                            //bankada oluşacak yeni krediler buradaki şablona uymak zorundalar.
    {
        void Calculate();        //oluşturduğumuz bütün kredi sınıfları hesaplama işlerini yapar ama herkes için aynı şekilde olmaz bu hesaplama.
                                 //o yüzden tek başına buradaki hesapla fonksiyonu yeterli değildir
                                 //fonksiyon imzası aynı olup işlem şekilleri farklı ise
                                 //biz artık base imizi(bu durumda class CrediManager) class olarak değil 
                                 //interface olarak kullanırız.
        void DoSomething();
    }
}
