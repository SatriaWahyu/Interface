using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismWithInterface
{
    class Epson : IPrinterWindows
    {
        public void Print(Mencetak cetak)
        {
            Console.WriteLine("Epson printer printing.......");
        }

        public void Show(Tampilkan tampil)
        {
            Console.WriteLine("Epson display dimension : 10*11 ");
        }
    }
}
