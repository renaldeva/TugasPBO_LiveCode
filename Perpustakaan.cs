using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Perpustakaan
{
    private string[] daftarBuku;
    private int jumlahBuku;
    private const int maksimalBuku = 100;

    public Perpustakaan()
    {
        daftarBuku = new string[maksimalBuku];
        jumlahBuku = 3;
        daftarBuku[0] = "Pemrograman C#";
        daftarBuku[1] = "Algoritma dan Struktur Data";
        daftarBuku[2] = "Jaringan Komputer";
    }

    public void TampilkanBuku()
    {
        Console.WriteLine("Daftar Buku di Perpustakaan:");
        for (int i = 0; i < jumlahBuku; i++)
        {
            Console.WriteLine((i + 1) + ". " + daftarBuku[i]);
        }
    }

    public void TambahBuku()
    {
        if (jumlahBuku < maksimalBuku)
        {
            Console.Write("Masukkan judul buku yang ingin ditambahkan: ");
            string judulBuku = Console.ReadLine();
            daftarBuku[jumlahBuku] = judulBuku;
            jumlahBuku++;
            Console.WriteLine("Buku \"" + judulBuku + "\" telah ditambahkan.");
        }
        else
        {
            Console.WriteLine("Perpustakaan penuh, tidak dapat menambah buku baru.");
        }
    }

    public void HapusBuku()
    {
        if (jumlahBuku == 0)
        {
            Console.WriteLine("Tidak ada buku yang tersedia untuk dihapus.");
            return;
        }

        TampilkanBuku();
        Console.Write("Pilih nomor buku yang ingin dihapus: ");
        if (int.TryParse(Console.ReadLine(), out int pilihan) && pilihan > 0 && pilihan <= jumlahBuku)
        {
            string judulBuku = daftarBuku[pilihan - 1];
            for (int i = pilihan - 1; i < jumlahBuku - 1; i++)
            {
                daftarBuku[i] = daftarBuku[i + 1];
            }
            daftarBuku[jumlahBuku - 1] = null;
            jumlahBuku--;
            Console.WriteLine("Buku \"" + judulBuku + "\" telah dihapus.");
        }
        else
        {
            Console.WriteLine("Pilihan tidak valid.");
        }
    }
}

class AdminPerpustakaan
{
    private Perpustakaan perpustakaan;

    public AdminPerpustakaan(Perpustakaan perpustakaan)
    {
        this.perpustakaan = perpustakaan;
    }

    public void TambahBuku()
    {
        if (perpustakaan != null)
        {
            perpustakaan.TambahBuku();
        }
    }

    public void HapusBuku()
    {
        if (perpustakaan != null)
        {
            perpustakaan.HapusBuku();
        }
    }
}