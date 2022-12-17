using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digdortgen_sinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Daire daire = new Daire(10);
            Console.WriteLine("Dairenin alanı: {0}", daire.AlanHesapla());
            Console.WriteLine("Dairenin çevresi: {0}", daire.CevreHesapla());
            Console.ReadLine();

        }
    }
    class Daire
    {
        private int r;
        public Daire(int r)
        {
            this.r = r;

        }
        public int AlanHesapla()
        {
            return 3 * (r * r);
        }
        public int CevreHesapla()
        {
            return 3 * (r * 2);
        }
    }
}