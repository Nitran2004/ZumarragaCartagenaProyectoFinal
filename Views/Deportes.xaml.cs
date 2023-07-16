using System.Collections.Generic;
using LomasZumarraga_ProyectoFinal.Models;

namespace LomasZumarraga_ProyectoFinal;

public partial class Deportes : ContentPage
{
	public Deportes()
	{
		InitializeComponent();
	}

    public void OnNewButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        App.DepRepo.AddNewDeportes(newPerson.Text);
        statusMessage.Text = App.DepRepo.StatusMessage;
    }

    public void OnGetButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        List<Deportes> dep = App.DepRepo.GetAllDeportes();
        peopleList.ItemsSource = dep;
    }
}