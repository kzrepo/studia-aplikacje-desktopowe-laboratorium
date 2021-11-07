using MVVMFirma.Model.EntitiesForView;
using MVVMFirma.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MVVMFirma.ViewModels
{
    public class WszystkieFakturyViewModel : WszystkieViewModel<FakturaForAllView>
    {

        #region Constructor
        public WszystkieFakturyViewModel()
            : base("Faktury")
        {
        }
        #endregion
        #region Helpers
        public override void load()
        {
            //
            List = new ObservableCollection<FakturaForAllView>
                (
                    from faktura in fakturyEntities.Faktura
                    where faktura.CzyAktywny == true
                    select new FakturaForAllView
                    {
                        IdFaktury=faktura.IdFaktury,
                        Numer=faktura.Numer,
                        DataWystawienia=faktura.DataWystawienia,
                        KontrahentNazwa=faktura.Kontrahent.Nazwa,
                        KontrahentNip=faktura.Kontrahent.Nip,
                        KontrahentAdres=
                            faktura.Kontrahent.Adres.Miejscowosc
                            +" ul."
                            +faktura.Kontrahent.Adres.Ulica
                            +" "
                            +faktura.Kontrahent.Adres.NrDomu
                            +"/"
                            +faktura.Kontrahent.Adres.NrLokalu,
                        TerminPlatnosci=faktura.TerminPlatnosci,
                        SposobPlatnosciNazwa=faktura.SposobPlatnosci.Nazwa
                    }
                );
        }
        #endregion
    }
}