using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triugulnik
{
    public class Triugulnik
    {
        private double stra;
        private double strb;
        private double strc;
        private double liceFormula;
        private double perimeterFormula;
        public double Stra
        {
            get { return stra;}
            set { stra = value; }
        }
        public double Strb
        {
            get { return strb; }
            set { strb = value; }
        }
        public double Strc
        {
            get { return strc; }
            set { strc = value; }
        }
        public double LiceFormula 
        {
            get { return liceFormula; }
            set { liceFormula = value; }
        }
        public double PerimeterFormula
        {
            get { return perimeterFormula; }
            set { perimeterFormula = value; }
        }
        public Triugulnik(double stra, double strb, double strc)
        {
            this.stra = stra;
            this.strb = strb;
            this.strc = strc;
        }
        
        public void Lice()
        {
            liceFormula = (stra * strb) / 2;
        }
        public void Perimeter()
        {
            perimeterFormula = stra + strb + strc;
        }
        public void Izhod()
        {
            Lice();
            Perimeter();
            Console.WriteLine($"Страна A: {stra} | Страна B: {strb} | Страна C: {strc} | Лице: {liceFormula} | Периметър: {perimeterFormula} ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи страна a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Въведи страна b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Въведи страна c: ");
            double c = double.Parse(Console.ReadLine());
            Triugulnik triugulnik1 = new Triugulnik(a, b, c);
            Triugulnik triugulnik2 = new Triugulnik(2, 7, 9);
            List<Triugulnik> listtriug = new List<Triugulnik>() { triugulnik1, triugulnik2 };
            int i = 1;
            foreach (Triugulnik p in listtriug)
            {
                Console.WriteLine($"Триъгълник {i}: ");
                p.Izhod();
                i++;
            }
        }
    }
}
