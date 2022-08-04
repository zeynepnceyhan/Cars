namespace ConsoleApp5
{
    class Program
    {
        public class araba
        {
            public int KapiSayisi;
            public string arabaModeli;
            public string arabaRengi;


            public araba(int _KapiSayisi, string _arabaModeli, string _arabaRengi)
            {
                KapiSayisi = _KapiSayisi;
                arabaModeli = _arabaModeli;
                arabaRengi = _arabaRengi;

            }
            public void MotorCalistir()
            {
                Console.WriteLine("motor çalışıyor!");
            }

            public void KapilariKilitle()
            {
                Console.WriteLine("kapılar kilitleniyor!");
            }
        }

        static void Main(string[] args)
        {
            araba car = new araba(4, "BMW", "Black");

            

            car.MotorCalistir();
            car.KapilariKilitle();

            Console.WriteLine("Arabanın kapı sayısı: " + car.KapiSayisi);
            Console.WriteLine("Arabanın modeli: " + car.arabaModeli);
            Console.WriteLine("Arabanın rengi: " + car.arabaRengi);
            Console.ReadLine();
        }

    }
}
