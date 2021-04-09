using System;
using System.Collections.Generic;
using System.Text;

namespace Płace.Domain.Model
{
    public class Pracownik
    {
        public int Id { get; set; }
        public string Imię { get; set; }
        public string Nazwisko { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public string Adres { get; set; }
        public int NrKonta { get; set; }

    }
}
