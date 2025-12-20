using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dars10
{
    internal class Parta
    {
        public Parta()
        {
        }

        public int Eni {  get; set; }
        public int Uzunlig {  get; set; }
        public int Balantlik {  get; set; }
        public string Rangi { get; set; }
        public int Qalinligi { get; set; }

        public Parta(int eni,int uzunli,int balantlik,string rangi,int qalinligi)
        {
            Eni = eni;
            Uzunlig = uzunli;
            Balantlik= balantlik;
            Rangi = rangi;
            Qalinligi = qalinligi;
        }

        public void PartaYuzasi()
        {
            var Yuzasi = Eni * Uzunlig;

            Console.WriteLine("Parta yuzasi: " +Yuzasi);
        }

        public void PartaKub()
        {
            var Kubi= Eni * Uzunlig* Qalinligi;
            Console.WriteLine("Parta kubi: " +Kubi);

        }

    }
}
