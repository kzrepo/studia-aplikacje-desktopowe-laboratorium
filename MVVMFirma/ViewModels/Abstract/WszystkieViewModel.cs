using MVVMFirma.Helper;
using MVVMFirma.Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MVVMFirma.ViewModels.Abstract
{
    //
    //
    public abstract class WszystkieViewModel<T>:WorkspaceViewModel
    {
        #region Fields
        //...
        protected readonly FakturyEntities fakturyEntities;
        //to jest 
        private BaseCommand _LoadCommand;
        //tu ..
        private ObservableCollection<T> _List;
        #endregion
        #region Properties
        //
        public ICommand LoadCommand
        {
            get
            {
                if (_LoadCommand == null)
                {
                    _LoadCommand = new BaseCommand(() => load());
                }
                return _LoadCommand;
            }
        }
        public ObservableCollection<T> List
        {
            get
            {
                if (_List == null)
                    load();
                return _List;
            }
            set
            {
                _List = value;
                OnPropertyChanged(() => List);
            }
        }
        #endregion
        #region Constructor
        public WszystkieViewModel(String displayName)
        {
            base.DisplayName = displayName;
            //tworze...
            this.fakturyEntities = new FakturyEntities();
        }
        #endregion
        #region Helpers
        //
        public abstract void load();
        #endregion
    }
}
