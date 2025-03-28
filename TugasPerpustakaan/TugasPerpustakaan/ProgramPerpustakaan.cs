using System;

class ProgramPerpustakaan
{
    static void Main()
    {
        Perpustakaan perpustakaan = new Perpustakaan();
        AdminPerpustakaan admin = new AdminPerpustakaan(perpustakaan);

        while (true)
        {
            Console.WriteLine("\nMenu Perpustakaan:");
            Console.WriteLine("1. Lihat daftar buku");
            Console.WriteLine("2. Tambah buku");
            Console.WriteLine("3. Hapus buku");
            Console.WriteLine("4. Keluar");
            Console.Write("Pilih menu: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    perpustakaan.TampilkanBuku();
                    break;
                case "2":
                    admin.TambahBuku();
                    break;
                case "3":
                    admin.HapusBuku();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }
        }
    }
}
