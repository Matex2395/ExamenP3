using ProductoAppMAUI.Models;
using ProductoAppMAUI.Service;

namespace ProductoAppMAUI.Views;

public partial class NuevaTareaPage : ContentPage
{

    private string estadoSeleccionado;
    private readonly APIService _APIService;
    public NuevaTareaPage()
	{
		InitializeComponent();
    }

    private async void OnGuardarClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(nombreEntry.Text)|| string.IsNullOrWhiteSpace(actividadEntry.Text))
        {
            await DisplayAlert("Error", "Debe completar todos los campos.", "OK");
            return;
        }
        else
        {
            Tarea tarea = new Tarea()
            {
                Nombre = nombreEntry.Text,
                Estado = estadoSeleccionado,
                Actividad = actividadEntry.Text
            };

            await _APIService.PostTarea(tarea);
            await App.Current.MainPage.DisplayAlert("Tarea agregada", "Su tarea se ha agregado correctamente.", "OK");
            await App.Current.MainPage.Navigation.PopAsync();
        }
    }

    private void estadoPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        if (picker.SelectedItem != null)
        {
            estadoSeleccionado = (string)picker.SelectedItem;
        }
    }


}