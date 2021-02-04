using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void DoApplication(ICrediManager crediManager, List<ILoggerService> loggerServices) //Method injection
            
            //Başvuruyu hangi krediye göre yapacağımı belirleyeceğim parametremi yazarak 
            //e bütün tiplerdeki kredilerin referansını tutan base im neydi?? ICrediManager :))
            //O yüzden parametre olarak ICrediManager verdik..
        {
            //başvuran bilgilerini değerlendirme

            //eğer aşağıdaki gibi yaparsan sen bütün başvuruları konut kredisine bağımlı hale getirmiş olursun
            //bu da senin kötü bir programcı olduğunu gösterir. :(
            //MortgageCrediManager mortgageCrediManager = new MortgageCrediManager();
            //mortgageCrediManager.Calculate();

            //yukarıdakilerin yerine parametre olarak ICrediManager ı verdikten sonra aşağıdakini yazarsan daha şukella olur
            crediManager.Calculate();

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void GivePreInformation(List<ICrediManager> credies)//Listedeki her bir kredinin
        {
            foreach (var credi in credies)
            {
                credi.Calculate();//hesabını yap
            }
        }

     
    }
}
