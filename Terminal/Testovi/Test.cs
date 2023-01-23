using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Modeli.Vlak;
using TrainTerminal.Models;

namespace Terminal.Testovi
{
	public class Test
    {
        [Test]

        public void TestVlakaKapacitet()
        {
            MaliVlak maliVlak=new MaliVlak();
            maliVlak.MaxKapacitet = 8;
            Assert.AreEqual(8, maliVlak.MaxKapacitet);
            Console.WriteLine("Test 1 je prošao");

            VelikiVlak velikiVlak = new VelikiVlak();
            velikiVlak.MaxKapacitet = 6;
            Assert.AreEqual(6, velikiVlak.MaxKapacitet);
            Console.WriteLine("Test 2 je prošao");
        }
       
        
    }


}

