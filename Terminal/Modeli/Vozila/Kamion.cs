using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Enumi;

namespace TrainTerminal.Models
{
    public class Kamion : Vozilo
    {
        public Kamion() : base(90, VrsteVozila.KAMION, VelicineVozila.VELIKI)
        {
        }
    }
}

