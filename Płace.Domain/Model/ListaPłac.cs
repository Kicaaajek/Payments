using System;
using System.Collections.Generic;
using System.Text;

namespace Płace.Domain.Model
{
    public class ListaPłac
    {
        public int Id { get; set; }
        public double KwotaBrutto { get; set; }
        public double KwotaNetto { get; set; }
        public double SkładkiSpołeczne{ get; set; }
        public double SkładkaEmerytalna { get; set; }
        public double SkładkaRentowa { get; set; }
        public double SkładkaChorobowa { get; set; }
        public double SkładkiZdrowotne { get; set; }
        public double ZaliczkaPodatek { get; set; }
        public double FP { get; set; }
        public double FGSP { get; set; }
        public DateTime MiesiącWypłaty { get; set; }
        public int PracownikId { get; set; }
        public Pracownik Pracownik { get; set; }
    }
}
