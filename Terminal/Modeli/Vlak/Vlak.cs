using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Modeli.Vlak
{
    public class Vlak 
    {
        public Vlak(int kapacitet)
        {
            TrenutniKapacitet = 0;
            MaxKapacitet = kapacitet;
        }

        public int TrenutniKapacitet { get;set;}
        public int MaxKapacitet { get;set;}

        public void getTrenutniKapacitet()=> Console.WriteLine($"Trenutni kapacitet je: {TrenutniKapacitet}");
        public bool DodajVozilo()
        {
            if (TrenutniKapacitet <=MaxKapacitet)
            {
                TrenutniKapacitet++;
                return true;
            }
            else
            {
                Console.WriteLine("Nije moguće utovariti, vlak je pun!");
                return false;
            }
        }
                            




    }
}
