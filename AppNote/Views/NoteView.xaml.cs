namespace AppNote.Views;

public partial class NoteView : ContentView
{
	public NoteView()
	{
		InitializeComponent();
		BindingContext =new ViewModels.NoteViewModel();
    }

   
}