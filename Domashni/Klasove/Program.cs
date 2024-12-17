using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasove
{
    public class Computer
    {
        private string procesor;
        private string videoKarta;
        private int ram;
        private int hdd;

        public string Procesor
        {
            get { return procesor; }
            set { procesor = value; }
        }
        public string VideoKarta
        {
            get { return videoKarta; }
            set { videoKarta = value; }
        }
        public int Ram
        {
            get { return ram; }
            set { ram = value; }
        }
        public int Hdd
        {
            get { return hdd; }
            set { hdd = value; }
        }
        public Computer(string procesor, string videoKarta, int ram, int hdd)
        {
            this.procesor = procesor;
            this.videoKarta = videoKarta;
            this.ram = ram;
            this.hdd = hdd;
        }
        public void Izhod()
        {
            Console.WriteLine($"CPU: {procesor} | GPU: {videoKarta} | Ram: {ram} GB| HDD: {hdd} GB");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {


            Computer computer1 = new Computer("Intel Core i5", "Nvdia Geforce 1050ti", 16, 1000);
            computer1.Izhod();

        }

    }
}
