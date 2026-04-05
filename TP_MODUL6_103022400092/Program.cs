using System;
using System.Diagnostics;

namespace Modul6_KPL
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
            this.playCount += count;
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("ID Track   : " + this.id);
            Console.WriteLine("Judul Lagu : " + this.title);
            Console.WriteLine("Play Count : " + this.playCount);
            Console.WriteLine("-------------------------------------------------");
        }
    }
}