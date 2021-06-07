using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS
{
    public class MainMenu
    {
        KoneksiDB db = KoneksiDB.Koneksi;

        public bool openConnection()
        {
            return db.Connect();
        }

        public bool closeConnection()
        {
            return db.Close();
        }

        public int readInput()
        {
            Console.WriteLine("Silahkan pilih menu berikut (angka):");
            Console.WriteLine("1. Tambah pengeluaran baru untuk minggu ini.\r\n" +
                                "2. Lihat total pengeluaran bulan ini.\r\n" +
                                "3. Lihat kategori pengeluaran bulan ini.\r\n" +
                                "4. Keluar dari program ini.\r\n");

            Console.Write("Masukkan pilihan anda: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
