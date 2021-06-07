using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UTS;

namespace UTSTestUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_KonekDB()
        {
            KoneksiDB koneksi = KoneksiDB.Koneksi;
            Assert.AreEqual(koneksi.Connect(), true);
        }

        [TestMethod]
        public void Test_QuerySQLSuccess()
        {
            KoneksiDB koneksi = KoneksiDB.Koneksi;
            koneksi.Connect();
            
            Assert.IsTrue(koneksi.Execute("SELECT * FROM `transaksi`"));
        }

        [TestMethod]
        public void Test_TransaksiMingguIniDibawah5()
        {
            CatatanDB catatan = new CatatanDB();
            KoneksiDB koneksi = KoneksiDB.Koneksi;
            koneksi.Connect();

            Assert.IsTrue(catatan.TotalTransaksiMingguan() <= 5);
        }

        [TestMethod]
        public void Test_KategoriBulananValid()
        {
            CatatanDB catatan = new CatatanDB();
            KoneksiDB koneksi = KoneksiDB.Koneksi;
            koneksi.Connect();

            Assert.AreNotEqual(catatan.KategoriBulanan(), "Tidak diketahui");
        }

        [TestMethod]
        public void Test_CatatPengeluaranSukses()
        {
            CatatanDB catatan = new CatatanDB();
            KoneksiDB koneksi = KoneksiDB.Koneksi;
            koneksi.Connect();

            Assert.IsTrue(catatan.CatatPengeluaran(420));
        }
    }
}
