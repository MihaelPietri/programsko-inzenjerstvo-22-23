using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Enumi;

namespace TrainTerminal.Models
{
    public class Auto : Vozilo
    {
        public Auto() : base(50, VrsteVozila.AUTO, VelicineVozila.MALI)
        {
        }
    }
}

