using AppNote.ViewModels;

namespace AppNote.Views;

public partial class NoteView : ContentView
{
    private readonly NoteViewModel noteView;

    public NoteView(NoteViewModel noteView)
	{
		InitializeComponent();
		BindingContext = noteView;
        this.noteView = noteView;
    }

    private void ListViewNote_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        // Set Data to Title and Description
        noteView.SetData();
    }
}