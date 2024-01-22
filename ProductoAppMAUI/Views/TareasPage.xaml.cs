using ProductoAppMAUI.ViewModels;

namespace ProductoAppMAUI.Views;

public partial class TareasPage : ContentPage
{
	public TareasPage()
	{
		InitializeComponent();
        BindingContext = new TareasViewModel();
    }

    private void OnCrearTareaClicked(object sender, EventArgs e)
    {
        // Aquí va el código para crear una nueva tarea
    }

    private void OnBuscarTareaClicked(object sender, EventArgs e)
    {
        // Aquí va el código para buscar tareas basándose en el nombre y el estado
    }
}