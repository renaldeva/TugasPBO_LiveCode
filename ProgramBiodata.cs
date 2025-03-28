using System;
using TugasBiodata;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nBiodata Mahasiswa");
        Biodata mahasiswa1 = new Biodata("Andi", "Informatika");
        mahasiswa1.SetNim(10104567);

        Biodata mahasiswa2 = new Biodata("Budi", "Teknologi Informasi");
        mahasiswa2.SetNim(20204567);

        Biodata mahasiswa3 = new Biodata("Citra", "Sistem Informasi");
        mahasiswa3.SetNim(30324567);
    }
}