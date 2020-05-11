using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismWithInterface
{
    class Canon : IPrinterWindows
    {
        public void Print(Mencetak cetak)
        {
            Console.WriteLine("Canon printer printing.......");

        }

        public void Show(Tampilkan tampil)
        {
            Console.WriteLine("Canon display dimension : 9.5*12 ");
        }
    }
}
