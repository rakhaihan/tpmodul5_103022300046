using System;

namespace tpmodul5_103022300046
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat instance dari kelas HaloGeneric
            HaloGeneric halo = new HaloGeneric();

            // Meminta input nama pengguna
            Console.Write("Masukkan nama Anda: ");
            string inputNama = Console.ReadLine();

            // Memanggil method SapaUser
            halo.SapaUser(inputNama);

            // Meminta input NIM pengguna
            Console.Write("Masukkan NIM Anda: ");
            string nim = Console.ReadLine();

            // Membuat instance kelas DataGeneric
            DataGeneric<string> dataGeneric = new DataGeneric<string>(nim);

            // Memanggil method PrintData 
            dataGeneric.PrintData();
        }
    }
}