using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UTS
{
    public class CatatanDB
    {
        KoneksiDB db = KoneksiDB.Koneksi;
        public int TotalTransaksiMingguan()
        {
            int totalTransaksi = 0;
            MySqlDataReader reader = db.Query("SELECT * FROM `transaksi` WHERE WEEKOFYEAR(tanggal_transaksi)=WEEKOFYEAR(NOW());");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    totalTransaksi++;
                }
            }
            reader.Close();
            return totalTransaksi;
        }

        public int TotalTransaksiBulanan()
        {
            int totalTransaksi = 0;
            MySqlDataReader reader = db.Query("SELECT * FROM `transaksi` WHERE MONTH(tanggal_transaksi)=MONTH(NOW());");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    totalTransaksi++;
                }
            }
            reader.Close();
            return totalTransaksi;
        }

        public int PengeluaranMingguan()
        {
            int totalPengeluaran = 0;
            MySqlDataReader reader = db.Query("SELECT * FROM `transaksi` WHERE WEEKOFYEAR(tanggal_transaksi)=WEEKOFYEAR(NOW());");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    totalPengeluaran += reader.GetInt32("jumlah_pengeluaran");
                }
            }
            reader.Close();
            return totalPengeluaran;
        }

        public int PengeluaranBulanan()
        {
            int totalPengeluaran = 0;
            MySqlDataReader reader = db.Query("SELECT * FROM `transaksi` WHERE MONTH(tanggal_transaksi)=MONTH(NOW());");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    totalPengeluaran += reader.GetInt32("jumlah_pengeluaran");
                }
            }
            reader.Close();
            return totalPengeluaran;
        }

        public string KategoriBulanan()
        {
            if (TotalTransaksiBulanan() < 10 && PengeluaranBulanan() < 300000)
            {
                return "Hemat";
            }
            else if ((TotalTransaksiBulanan() >= 10 && TotalTransaksiBulanan() <= 15)
                && (PengeluaranBulanan() >= 300000 && PengeluaranBulanan() <= 500000))
            {
                return "Sedang";
            }
            else
            {
                return "Boros";
            }
            return "Tidak diketahui";
        }

        public bool CatatPengeluaran(int totalPengeluaran)
        {
            try
            {
                MySqlDataReader reader = db.Query(string.Format("INSERT INTO `transaksi`(`id`, `jumlah_pengeluaran`, `tanggal_transaksi`) VALUES (NULL,{0},CURRENT_DATE());", totalPengeluaran));
                reader.Close();
                return true;
            } catch(Exception ex)
            {
                return false;
            }
        }
    }
}
