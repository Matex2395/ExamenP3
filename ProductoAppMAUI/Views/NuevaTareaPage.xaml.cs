using ProductoAppMAUI.Models;
using ProductoAppMAUI.Service;
using ProductoAppMAUI.ViewModels;

namespace ProductoAppMAUI.Views;

public partial class NuevaTareaPage : ContentPage
{

    private Tarea _tarea;
    private readonly APIService _APIService;
    public NuevaTareaPage(Tarea tarea)
	{
        _tarea = tarea;
		InitializeComponent();
        BindingContext = new NuevaTareaViewModel(_tarea);
    }

    private void OnGuardarClicked(object sender, EventArgs e)
    {
        // Aquí va el código para guardar la tarea
    }
}