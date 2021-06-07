using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_dunno_what_im_doing
{
    public class Pembatasan
    {
        public int batasTransaksi;
        public int masukkanbatasT()
        {
          Console.WriteLine("Masukkan Jumlah Transaksi");
          batasTransaksi = Convert.ToInt32(Console.ReadLine());
          return batasTransaksi;
        }
    }
}
