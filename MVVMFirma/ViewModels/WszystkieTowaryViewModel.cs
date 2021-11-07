using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using MVVMFirma.Model.Entities;
using MVVMFirma.Helper;
using System.Windows.Input;
using MVVMFirma.Model.EntitiesForView;
using MVVMFirma.ViewModels.Abstract;

namespace MVVMFirma.ViewModels
{
    //..
    public class WszystkieTowaryViewModel : WszystkieViewModel<TowarForView>
    {
       
        #region Constructor
        public WszystkieTowaryViewModel()
            :base("Towary")
        {
        }
        #endregion
        #region Helpers
        public override void load()
        {
            //
            List = new ObservableCollection<TowarForView>
                (
                    //Linq => odpowiednik C# (obiektowy) SQL
                    from towar in fakturyEntities.Towar
                    where towar.CzyAktywny == true
                    select new TowarForView
                    {
                        IdTowaru=towar.IdTowaru,
                        Kod=towar.Kod,
                        Nazwa=towar.Nazwa,
                        StawkaVatSprzedazy=towar.StawkaVatSprzedazy,
                        Cena=towar.Cena
                    }
                ); 
        }
        #endregion
    }
}