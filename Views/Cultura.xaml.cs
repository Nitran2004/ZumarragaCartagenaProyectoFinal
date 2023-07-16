using System.Collections.Generic;
using LomasZumarraga_ProyectoFinal.Models;

namespace LomasZumarraga_ProyectoFinal;

public partial class Cultura : ContentPage
{
	public Cultura()
	{
		InitializeComponent();
	}

    public void OnNewButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        App.CultRepo.AddNewCultura(newPerson.Text);
        statusMessage.Text = App.CultRepo.StatusMessage;
    }

    public void OnGetButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        List<Cultura> cult = App.CultRepo.GetAllCultura();
        peopleList.ItemsSource = cult;
    }
}