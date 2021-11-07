using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVVMFirma.Model.EntitiesForView
{
    public class TowarForView
    {
        public int IdTowaru { get; set; }
        public string Kod { get; set; }
        public string Nazwa { get; set; }
        public decimal? StawkaVatSprzedazy { get; set; }
        public decimal? Cena { get; set; }
    }
}
