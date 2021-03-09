using System;
using System.Globalization;
namespace Task3
{
    class Program
    {
       
        public static void GetCultureInfo()
        {
            var dateNow = DateTime.Now;
            var france = dateNow.ToString(CultureInfo.CreateSpecificCulture("fr-FR"));
            var spain = dateNow.ToString(CultureInfo.CreateSpecificCulture("es-AR"));
            var english = dateNow.ToString(CultureInfo.CreateSpecificCulture("en-US"));
            var russia = dateNow.ToString(CultureInfo.CreateSpecificCulture("ru-RU"));

            var fra = String.Format(CultureInfo.GetCultureInfo("fr-FR"), "{0:0}, {0,4}", 6487.5464784632F);
            var spa = String.Format(CultureInfo.GetCultureInfo("es-AR"), "{0:0}, {0,4}", 6487.5464784632F);
            var eng = String.Format(CultureInfo.GetCultureInfo("en-US"), "{0:0}, {0,4}", 6487.5464784632F);
            var rus = String.Format(CultureInfo.GetCultureInfo("ru-RU"), "{0:0}, {0,4}", 6487.5464784632F);
            

            Console.WriteLine("RU\t\t\t\tEN");
            Console.WriteLine("{0}\t\t{1}", russia, english);
            Console.WriteLine("{0}\t\t\t{1}", rus, eng);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("EN\t\t\t\tFR");
            Console.WriteLine("{0}\t\t{1}", english, france);
            Console.WriteLine("{0}\t\t\t{1}", eng, fra);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("RU\t\t\t\tES");
            Console.WriteLine("{0}\t\t{1}", russia, spain);
            Console.WriteLine("{0}\t\t\t{1}", rus, spa);
            Console.WriteLine();

        }
       
        static void Main(string[] args)
        {
            GetCultureInfo();
        }
    
    }
}
