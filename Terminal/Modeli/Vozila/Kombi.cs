using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Enumi;

namespace TrainTerminal.Models
{
    public class Kombi : Vozilo
    {
        public Kombi() : base(80, VrsteVozila.KOMBI, VelicineVozila.MALI)
        {
        }
    }
}

