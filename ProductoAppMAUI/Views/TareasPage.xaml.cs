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
        // Aqu� va el c�digo para crear una nueva tarea
    }

    private void OnBuscarTareaClicked(object sender, EventArgs e)
    {
        // Aqu� va el c�digo para buscar tareas bas�ndose en el nombre y el estado
    }
}