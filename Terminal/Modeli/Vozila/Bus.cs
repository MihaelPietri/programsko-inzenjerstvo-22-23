using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Enumi;

namespace TrainTerminal.Models
{
    public class Bus : Vozilo
    {
        public Bus() : base(70, VrsteVozila.BUS, VelicineVozila.VELIKI)
        {
        }
    }
}

