using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, c;
            string[] nama = new string[1];
            string[] NISN = new string[1];
            string[] asal_sekolah = new string[1];

            for (i = 0; i < 1; i++)
            {
                c = i + 1;
                Console.WriteLine("Identity " + c);
                Console.WriteLine("----------------------");
                Console.Write("Nama : " );
                nama[i] = Console.ReadLine();
                Console.Write("NISN : " );
                NISN[i] = Console.ReadLine();
                Console.Write("Asal Sekolah : " );
                asal_sekolah[i] = Console.ReadLine();
            }

            int a, b, ratarata;
            string[] mapel = new string[12];
            string[] semester1 = new string[12];
            string[] semester2 = new string[12];
            string[] semester3 = new string[12];
            string[] semester4 = new string[12];
            string[] semester5 = new string[12];
            string[] semester6 = new string[12];

            for (a = 0; a < 12; a++)
            {
                b = a + 1;
                Console.WriteLine("Input " + b);
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Console.Write("Mapel    : ");
                mapel[a] = Console.ReadLine();
                Console.WriteLine("                 Nilai               ");
                Console.Write("Semester 1   : ");
                semester1[a] = Console.ReadLine();
                Console.Write("Semester 2   : ");
                semester2[a] = Console.ReadLine();
                Console.Write("Semester 3   : ");
                semester3[a] = Console.ReadLine();
                Console.Write("Semester 4   : ");
                semester4[a] = Console.ReadLine();
                Console.Write("Semester 5   : ");
                semester5[a] = Console.ReadLine();
                Console.Write("Semester 6   : ");
                semester6[a] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("data telah di masukkan tekan sembarang untuk menampilkan");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Berikut ini identitas siswa yang di masukkan");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("========================================================================");
            Console.WriteLine("| No | Nama Siswa | NISN | Asal Sekolah |");
            Console.WriteLine("========================================================================");
            for (i = 0; i < 1; i++)
            {
                c = i + 1;
                Console.WriteLine("|" + c + "|" + nama[i] + "|" + NISN[i] +"|" + asal_sekolah[i] + "|");
            }
            Console.WriteLine("================================");
            Console.WriteLine();
            Console.Write("Tekan enter untuk melihat rekap nilai");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Hasil rekap nilai siswa");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("================================================================================");
            Console.WriteLine("|NO|Mapel|Semester 1|Semester 2|Semester 3|Semester 4|Semester 5|Semester 6|");
            Console.WriteLine("================================================================================");
            for (a = 0; a < 12; a++)
            {
                b = a + 1;
                Console.WriteLine("|  " + b + "  |  " + mapel[a] + "  |  " + semester1[a] + "  |  " + semester2[a] + "  |  " + semester3[a] + " |  " + semester4[a] + "  |  " + semester5[a] + "  |  " + semester6[a] + "  |  ");

            }
            Console.WriteLine("=======================================================================================");
            Console.WriteLine();
            Console.WriteLine("Apakah anda ingin melihat nilai rata rata anda? Tekan enter untuk melihatnya"); 
            Console.Write("Tekan enter untuk selesai");
            Console.ReadLine();
      
        }
    }
}