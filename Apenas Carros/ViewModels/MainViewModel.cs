using Apenas_Carros.Data;
using Apenas_Carros.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace Apenas_Carros.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<ClassicCover> covers;

    [ObservableProperty]
    ObservableCollection<ClassicCar> cars;

    [ObservableProperty]
    ObservableCollection<Porsche> porschesCarrera;

    public MainViewModel()
    {
        ListVeiculo();
    }

    private void ListVeiculo()
    {
        var dbContext = new AppDbContext();

        Covers = new ObservableCollection<ClassicCover>(dbContext.ClassicCovers);
        Cars = new ObservableCollection<ClassicCar>(dbContext.ClassicCars);
        PorschesCarrera = new ObservableCollection<Porsche>(dbContext.Porsches);
    }
}
