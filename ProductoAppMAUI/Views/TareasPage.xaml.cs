using ProductoAppMAUI.Models;
using ProductoAppMAUI.Service;
using System.Collections.ObjectModel;

namespace ProductoAppMAUI.Views;

public partial class TareasPage : ContentPage
{

    private APIService _APIService;
    public ObservableCollection<Tarea> Tareas { get; set; }
    public TareasPage()
	{
        InitializeComponent();
        Tareas = new ObservableCollection<Tarea>();
        listaTareas.ItemsSource = Tareas;
    }

    private void OnCrearTareaClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NuevaTareaPage());
    }

    private void OnBuscarTareaClicked(object sender, EventArgs e)
    {
        var nombre = nombreEntry.Text;
        var estado = estadoPicker.SelectedItem.ToString();

        Task.Run(() => OnBuscarTareaClickedAsync(nombre, estado));
    }

    private async Task OnBuscarTareaClickedAsync(string nombre, string estado)
    {
        var tareas = await _APIService.GetTareas(nombre, estado);

        // Actualiza la variable Tareas con las tareas obtenidas
        Tareas.Clear();
        foreach (var tarea in tareas)
        {
            Tareas.Add(tarea);
        }

        // Establece el ItemsSource de la ListView después de obtener las tareas
        listaTareas.ItemsSource = Tareas;
    }



}