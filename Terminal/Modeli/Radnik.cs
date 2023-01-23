using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Enumi;
using TrainTerminal.Models;

namespace Terminal.Modeli
{
    public class Radnik
    {
        public Radnik(string Ime, double Postotak)
        {
            this.Ime = Ime;
            this.Postotak = Postotak;
            this.Zarada = 0;
        }

        public string Ime { get; set; }
        public double Zarada { get; set; }
        public double Postotak { get; set; }

        public void ukrcajVozila(Vozilo vehicle, TermVlakova terminal)
        {
            Zarada += vehicle.getCijena() * Postotak;

            switch (vehicle.getVelicinuVozila())
            {
                case VelicineVozila.MALI:
                    terminal.napuniMaliVlak();
                    break;
                case VelicineVozila.VELIKI:
                    terminal.napuniVelikiVlak();
                    break;
            }

            terminal.dodajNovac(vehicle.getCijena());
        }
        public void getZaradu() => Console.WriteLine($"{Ime} je zaradio: " + Zarada + "$");
    }
}
