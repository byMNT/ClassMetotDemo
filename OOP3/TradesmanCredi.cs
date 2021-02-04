using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TradesmanCredi : ICrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
