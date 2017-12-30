using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UDLServices.Views.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class mdStartPageMaster : ContentPage
    {
        public ListView ListView;

        public mdStartPageMaster()
        {
            InitializeComponent();

            BindingContext = new mdStartPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class mdStartPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<mdStartPageMenuItem> MenuItems { get; set; }

            public mdStartPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<mdStartPageMenuItem>(new[]
                {
                    new mdStartPageMenuItem { Id = 0, Title = "Mi Perfil" },
                    new mdStartPageMenuItem { Id = 1, Title = "Configuracion" },
                    new mdStartPageMenuItem { Id = 2, Title = "Acerca de" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}