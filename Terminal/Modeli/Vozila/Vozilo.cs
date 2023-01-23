using System;
using Terminal.Enumi;
using Terminal.Interface;
using Terminal.Modeli;

namespace TrainTerminal.Models
{
    public class Vozilo :IPunjenje
    {
        private int snagaBaterije;
        private int postotakGoriva;
        private int cijena;
        VrsteVozila vrsteVozila;
        VelicineVozila velicineVozila;

        public Vozilo( int cijena, VrsteVozila vrsteVozila, VelicineVozila velicineVozila)
        {
            Random random = new Random();
            this.snagaBaterije = random.Next(0,100);
            this.postotakGoriva = random.Next(0,100);
            this.cijena = cijena;
            this.vrsteVozila = vrsteVozila;
            this.velicineVozila = velicineVozila;
            Console.WriteLine(vrsteVozila+" baterija:" + snagaBaterije +" postotak goriva: " + postotakGoriva);
            Provjeri();
        }

       
            public void Provjeri()
            {
            if (postotakGoriva< 10)
            {
                Console.WriteLine(vrsteVozila + " postotak goriva vozila je ispod 10%. Punjenje u procesu");
                postotakGoriva= 100;
            }
            if (snagaBaterije<10)
            {
                Console.WriteLine(vrsteVozila + " postotak baterije je ispod 10%. Punjenje u procesu!");

                snagaBaterije= 100; 
            }
           
            }

        public void getSnagaBaterije() => Console.WriteLine("Postotak baterije: " + snagaBaterije);
        public void getGasPercentage() => Console.WriteLine("Postotak goriva: " + postotakGoriva);
        public int getCijena() => cijena;

        public int getGorivo() => postotakGoriva;

        public VelicineVozila getVelicinuVozila() => velicineVozila;
        public VrsteVozila getVrstuVozila() => vrsteVozila;

    }
}