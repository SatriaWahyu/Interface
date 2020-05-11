using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismWithInterface
{
    class LaserJet : IPrinterWindows
    {
        public void Print(Mencetak cetak)
        {
            Console.WriteLine("LaserJet printer printing.......");
        }

        public void Show(Tampilkan tampil)
        {
            Console.WriteLine("LaserJet display dimension : 12*12 ");
        }
    }
}
