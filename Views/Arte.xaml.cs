using System.Collections.Generic;
using LomasZumarraga_ProyectoFinal.Models;

namespace LomasZumarraga_ProyectoFinal;

public partial class Arte : ContentPage
{
	public Arte()
	{
		InitializeComponent();
	}

    public void OnNewButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        App.ArtRepo.AddNewArte(newPerson.Text);
        statusMessage.Text = App.ArtRepo.StatusMessage;
    }

    public void OnGetButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        List<Arte> art = App.ArtRepo.GetAllArte();
        peopleList.ItemsSource = art;
    }
}