using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.DizajnPaterni;
using Terminal.Modeli.Vlak;

namespace Terminal.Modeli
{
    public class TermVlakova : ITerminal
    {
        private MaliVlak maliVlak;
        private VelikiVlak velikiVlak;
        private int UkupniProfiti;

        public TermVlakova()
        {
            maliVlak = new MaliVlak();
            velikiVlak = new VelikiVlak();
            UkupniProfiti = 0;
        }
        public void dodajNovac(int cost) => UkupniProfiti += cost;
        public void getVelikiVlakKapacitet() => velikiVlak.getTrenutniKapacitet();
        public void getMaliVlakKapacitet() => maliVlak.getTrenutniKapacitet();

        public void GetUkupniProfitTerminala() => Console.WriteLine($"Ukupni profit terminala: {UkupniProfiti} $");
        public void napuniMaliVlak()
        {
            velikiVlak.DodajVozilo();
        }

        public void napuniVelikiVlak()
        {
            maliVlak.DodajVozilo();
        }
    }
}
