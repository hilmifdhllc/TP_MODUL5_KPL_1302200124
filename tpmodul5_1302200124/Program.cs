using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302200124
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – [HILMI FADHILLAH CAHYADI]");
            video.PrintVideoDetails();
            video.IncreasePlayCount(1);
            video.PrintVideoDetails();
        }
    }
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string judul)
        {
           
            Random ids = new Random();
            this.title = judul;
            id = ids.Next(0, 100000);
            this.playCount = 0;
        }
        public void IncreasePlayCount(int i)
        {
            
            playCount = playCount + i;


        }

        public void PrintVideoDetails()
        {
            Console.WriteLine(this.id);
            Console.WriteLine(this.title);
            Console.WriteLine(this.playCount);
        }
    }
}
