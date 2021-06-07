using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_dunno_what_im_doing
{
    public class uang
    {
        private int tu;
        public int Tu
        {
            get { return tu; }
            set { tu = value; }
        }
    }
    public class TotalPengeluaran
    {
        int[] data = new int[100];
        int i = 0;
        public int TotalUang;
        Pembatasan K = new Pembatasan();
        uang money = new uang();
     
        public int TotalUangKeluar()
        {
        
            K.masukkanbatasT();
            int n = K.batasTransaksi;

            while (i < n)
            {
                Console.WriteLine((i + 1) + ". Masukkan Uang yang dikeluarkan: "  );
                data[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            for (i = 0; i < n; i++)
            {
              money.Tu = TotalUang = TotalUang + data[i];

            }

            Console.WriteLine("\nTotal uang yang dikeuarkan minggu ini: {0}\n", money.Tu);

            PilihanTampilan p = new PilihanTampilan();
            p.setpilihan();
            return money.Tu;

        }
               
       
    }

 
}
