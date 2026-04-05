using System;
using System.Diagnostics;

namespace Modul6_103022400092
{
    public class SayaMusicTrack
    {
        private int id;
        private int playCount; 
        private string title;

        public SayaMusicTrack(string title)
        {
            this.title = title;
            this.playCount = 0; 

            Random random = new Random();
            this.id = random.Next(10000, 100000);
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000, "play count maksimal 10.000.000");
            Debug.Assert(count > 0, "Penambahan harus angka positif");

            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine("eror" + e.Message);
                Console.WriteLine("Play count telah mencapai batas maksimum integer");
            }
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("ID Track   : " + this.id);
            Console.WriteLine("Judul Lagu : " + this.title);
            Console.WriteLine("Play Count : " + this.playCount);
            Console.WriteLine("-------------------------------------------------");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Music Track");

            SayaMusicTrack track1 = new SayaMusicTrack("Tabolabale");
            track1.PrintTrackDetails();

            Console.WriteLine("Menambahkan 5.000.000 play count");
            track1.IncreasePlayCount(5000000);
            track1.PrintTrackDetails();

            Console.WriteLine("exeception");
            Console.WriteLine("Menambahkan 10.000.000 play count secara berulang");

            for (int i = 0; i < 220; i++)
            {
                track1.IncreasePlayCount(10000000);
            }

            Console.WriteLine("Detail akhir setelah loop selesai:");
            track1.PrintTrackDetails();
        }
    }
}