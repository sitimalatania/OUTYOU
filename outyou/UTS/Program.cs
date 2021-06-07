using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UTS   
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            CatatanDB catatan = new CatatanDB();
            if (menu.openConnection())
            {
                int nInput;
                while ((nInput = menu.readInput()) != 4)
                {
                    Console.WriteLine();

                    switch (nInput)
                    {
                        case 1:
                            Console.Write("Masukkan Pengeluaran: ");
                            int pengeluaran = int.Parse(Console.ReadLine());
                            if (catatan.TotalTransaksiMingguan() > 5) {
                                Console.WriteLine("Maaf! Batas trasaksi hanya 5 kali dalam seminggu!");
                            } else
                            {
                                if (catatan.CatatPengeluaran(pengeluaran)) 
                                    Console.WriteLine("Pengeluaran berhasil dicatat! Total pengeluaran minggu ini: {0}", catatan.PengeluaranMingguan());
                            }
                            break;

                        case 2:
                            Console.WriteLine("Total pengeluaran bulan ini: {0} dari {1} transaksi", catatan.PengeluaranBulanan(), catatan.TotalTransaksiBulanan());
                            break;

                        case 3:
                            Console.WriteLine("Total transaksi bulan ini: {0}", catatan.TotalTransaksiBulanan());
                            Console.WriteLine("Total pengeluaran bulan ini: {0}", catatan.PengeluaranBulanan());
                            Console.WriteLine("Kategori bulan ini: {0}!", catatan.KategoriBulanan());
                            break;

                        default:
                            Console.WriteLine("Input tidak diketahui!");
                            break;
                    }

                    Console.WriteLine();
                }

                menu.closeConnection();
            }
        }
    }
}
