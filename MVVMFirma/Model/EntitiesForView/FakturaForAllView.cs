using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVVMFirma.Model.EntitiesForView
{
    //to ...
    public class FakturaForAllView
    {
        public int IdFaktury { get; set; }
        public string Numer { get; set; }
        public DateTime? DataWystawienia { get; set; }
        //te pola są zamiast klucza obcego
        public string KontrahentNazwa { get; set; }
        public string KontrahentNip { get; set; }
        public string KontrahentAdres { get; set; }
        public DateTime? TerminPlatnosci { get; set; }
        //to pole jest zamiast idSposobuPlatnosci
        public string SposobPlatnosciNazwa { get; set; }
    }
}
