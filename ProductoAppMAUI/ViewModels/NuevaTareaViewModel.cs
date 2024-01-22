using ProductoAppMAUI.Models;
using ProductoAppMAUI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProductoAppMAUI.ViewModels
{
    public class NuevaTareaViewModel
    {

        private readonly APIService _APIService;
        public string IdTarea { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public string Actividad { get; set; }
        public Tarea _tarea { get; set; }



        public NuevaTareaViewModel()
        {

            _APIService = new APIService();

        }

        public ICommand EnviarTarea =>
           new Command(async () =>
           {
               //Verificar que el formulario no está vacío
               if (string.IsNullOrWhiteSpace(Actividad))
               {
                   await App.Current.MainPage.DisplayAlert("Error", "Debe completar todos los campos.", "OK");
                   return;
               }
               else
               {
                   Tarea tarea = new Tarea()
                   {
                       IdTarea= Convert.ToInt32(IdTarea),
                       Nombre = Nombre,
                       Estado = Estado,
                       Actividad = Actividad
                   };

                   //await _APIService(resena);
                   await App.Current.MainPage.DisplayAlert("Reseña Agregada", "Su reseña se publicó correctamente.", "OK");
                   await App.Current.MainPage.Navigation.PopAsync();
               }
           });



    }
}
