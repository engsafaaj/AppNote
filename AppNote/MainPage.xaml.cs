﻿using AppNote.ViewModels;

namespace AppNote;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        Container.Content=new Views.NoteView(new NoteViewModel());

    }


}

