using System.Collections.Generic;
using LomasZumarraga_ProyectoFinal.Models;

namespace LomasZumarraga_ProyectoFinal;

public partial class Tecnologia : ContentPage
{
	public Tecnologia()
	{
		InitializeComponent();
	}

    public void OnNewButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        App.TecRepo.AddNewTecnologia(newPerson.Text);
        statusMessage.Text = App.TecRepo.StatusMessage;
    }

    public void OnGetButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        List<Tecnologia> tec = App.TecRepo.GetAllTecnologia();
        peopleList.ItemsSource = tec;
    }
}