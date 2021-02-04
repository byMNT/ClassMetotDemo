using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalFinanceCrediManager personalFinanceCrediManager = new PersonalFinanceCrediManager();
            //ICrediManager personalFinanceManager = new PersonalFinanceCrediManager(); //böyle yazsan da olurdu yukarıdakiyle aynı
            //bu şu demek tıpkı inheritance da ki base class gibi
            //interface lerde onu implemente eden sınıfın referanslarını tutabiliyormuş.BU HAYATİ BİR BİLGİ UNUTMA!
            TransportCrediManager transportCrediManager = new TransportCrediManager();
            MortgageCrediManager mortgageCrediManager = new MortgageCrediManager();

            //yukarıdakiler bankacının ana ekranında görünenlermiş gibi düşün.

            ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.DoApplication(mortgageCrediManager, new DataBaseLoggerService());
            //ICrediManager i kim impelemente etmi ise biz yularıdaki parametreye onu yazabiliriz
            //applicationManager.DoApplication(new TradesmanCredi(), new SmsLoggerService());

            //peki hem veritabanına logglayıp hem sms gönderilmesini istiyorsam ne yaparım?
            //applicationmanager da doapplication nin logger parametresini listeye çeviririm.

            applicationManager.DoApplication(mortgageCrediManager,
                new List<ILoggerService> {new DataBaseLoggerService(), new SmsLoggerService(), new FileLoggerService()});

            List<ICrediManager> credies = new List<ICrediManager>() {personalFinanceCrediManager, transportCrediManager, mortgageCrediManager};

            //applicationManager.GivePreInformation(credies);

        }
    }
}
