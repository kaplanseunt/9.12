using System;
using System.Collections.Generic;

namespace P3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();                                              
            IKrediManager konutKrediManager = new KonutKrediManager();        
            IKrediManager tasitKrediManager = new TasitKrediManager();
            //interfaceler de ona implement eden classın referans numarasını tutabilir

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };
            basvuruManager.KrediOnBilgilendirme(krediler);

            

        }
    }
}
