using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
            video.IncreasePlayCount(10);
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
            Contract.Requires(title != null);
            Contract.Requires(title.Length < 100);
            Random ids = new Random();
            this.title = judul;
            id = ids.Next(0, 100000);
            this.playCount = 0;
        }
        public void IncreasePlayCount(int i)
        {
            
             try
            {
                if (i >= 10000000) throw new Exception("Angka Melewati Limit");
                playCount = playCount + i;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            


        }

        public void PrintVideoDetails()
        {
            Console.WriteLine(this.id);
            Console.WriteLine(this.title);
            Console.WriteLine(this.playCount);
        }
    }
}
