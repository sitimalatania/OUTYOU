using System;

namespace I_dunno_what_im_doing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selamat Datang di OUTYOU");
            Console.WriteLine("Semoga Anda menikmati hari anda");
            Console.WriteLine("Pilih menu tampilan: ");

            PilihanTampilan p = new PilihanTampilan();
            p.setpilihan();
            
        }
    }
}
