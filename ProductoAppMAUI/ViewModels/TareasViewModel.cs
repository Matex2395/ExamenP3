using CommunityToolkit.Mvvm.ComponentModel;
using ProductoAppMAUI.Models;
using ProductoAppMAUI.Service;
using ProductoAppMAUI.Utils;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace ProductoAppMAUI.ViewModels
{

    [AddINotifyPropertyChangedInterface]
    public class TareasViewModel
    {

        private APIService _APIService;
        public ObservableCollection<Tarea> ListaTareas { get; set; }

        public TareasViewModel()
        {
            _APIService = new APIService();
        }





    }
}
