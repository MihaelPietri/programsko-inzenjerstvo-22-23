using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Terminal.DizajnPaterni;
using Terminal.Modeli;
using TrainTerminal.Models;

namespace Terminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TermVlakova terminal = TerminalFaktori.napraviTerminal();


            Radnik mihovil = new Radnik("Mihovil", 0.1);
            Radnik ante = new Radnik("Ante", 0.11);

            Auto auto = new Auto();
            Thread.Sleep(1);
            Kombi kombi = new Kombi();
            Thread.Sleep(1);
            Bus bus = new Bus();
            Thread.Sleep(1);
            Kamion kamion = new Kamion();


            mihovil.ukrcajVozila(auto, terminal);
            ante.ukrcajVozila(kombi, terminal);

            mihovil.ukrcajVozila(bus, terminal);
            ante.ukrcajVozila(kamion, terminal);
            //Zarada radnika
            mihovil.getZaradu();
            ante.getZaradu();

            //Zarada terminala
            terminal.GetUkupniProfitTerminala();

        }
    }
    }

