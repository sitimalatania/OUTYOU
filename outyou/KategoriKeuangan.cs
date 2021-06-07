using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_dunno_what_im_doing
{
    class KategoriKeuangan
    {
        public void Kategori()
        {
            Console.WriteLine("Kategori Keuangan anda minggu ini");

            TotalPengeluaran tp = new TotalPengeluaran();
            uang money = new uang();
            //K.masukkanbatasT();
            int bts = money.Tu = tp.TotalUang;
            Console.WriteLine(tp.TotalUang.ToString());
            if (bts <= 5)
            {
                Console.Write("Anda Hemat");
            }
            else
            {
                Console.Write("Anda Boros");
            }
            Console.ReadKey();
            Console.Clear();
            PilihanTampilan p = new PilihanTampilan();
            p.setpilihan();
        }
    }
}
