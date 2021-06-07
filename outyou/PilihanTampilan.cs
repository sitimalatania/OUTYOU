using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_dunno_what_im_doing
{
    class PilihanTampilan
    {
        TotalPengeluaran j = new TotalPengeluaran();
        KategoriKeuangan k = new KategoriKeuangan();


        public void setpilihan()
        {
            Console.WriteLine("Pilih yang ingin anda Tampilkan: ");
            Console.WriteLine("1. Melihat total pengeluaran minggu ini: ");
            Console.WriteLine("2. Tingkat pengeluaran anda: ");
            Console.WriteLine("3. Keluar");
            //pilih = Convert.ToInt32(Console.ReadLine());

            switch (Console.ReadLine())
            {
                case "1":
                    j.TotalUangKeluar();
                    return;
                case "2":
                    k.Kategori();
                    return;
                case "3":
                    Console.WriteLine("Terima Kasih sudah mengunjungi OUTYOU");
                    return;
            }

        }
    }
}
