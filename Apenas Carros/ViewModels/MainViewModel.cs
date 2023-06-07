using Apenas_Carros.Data;
using Apenas_Carros.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace Apenas_Carros.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<Classicos> classicosCarros;

    public MainViewModel()
    {
        ListVeiculo();
    }

    private void ListVeiculo()
    {
        var dbContext = new AppDbContext();

        ClassicosCarros = new ObservableCollection<Classicos>(dbContext.Classic);
    }
}
