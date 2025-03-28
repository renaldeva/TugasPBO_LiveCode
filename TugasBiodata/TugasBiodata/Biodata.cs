using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasBiodata
{
    class Biodata
    {
        public string Nama { get; }
        public string Prodi { get; }
        private string nim;

        public Biodata(string nama, string prodi)
        {
            Nama = nama;
            Prodi = prodi;
        }

        public void SetNim(int nimValue)
        {
            string nimStr = nimValue.ToString();
            string nimAwal = "";

            if (Prodi == "Informatika")
                nimAwal = "1010";
            else if (Prodi == "Teknologi Informasi")
                nimAwal = "2020";
            else if (Prodi == "Sistem Informasi")
                nimAwal = "3030";

            if (nimStr.StartsWith(nimAwal))
            {
                nim = nimStr;
                Console.WriteLine("NIM telah sesuai: " + nim);
            }
            else
            {
                Console.WriteLine("NIM tidak sesuai dengan program studi.");
            }
        }
    }
}
