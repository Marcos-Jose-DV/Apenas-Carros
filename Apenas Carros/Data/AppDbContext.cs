using Apenas_Carros.Models;
using Microsoft.EntityFrameworkCore;

namespace Apenas_Carros.Data;

public class AppDbContext : DbContext
{
    public DbSet<Classicos> Classic { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("ApenasCarrosComputer");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Classicos>().HasData(
            new Classicos(1, "Porsche 356", "porschecapa", 
            "Em 8 de junho de 1948, o primeiro carro a levar o nome Porsche foi certificado para estrada: o Porsche 356/1 Roadster produzido em Gmünd (na Caríntia, Áustria).O \"Gmünd Roadster\" era movido por um motor flat-four de 1,1 litros refrigerado a ar da Volkswagen. A potência do motor foi aumentada para 35 cv no 356. O roadster pesava apenas 585 quilos e atingia velocidades de até 135 km/h (83 mph).O 356 original (também chamado de \"pré-A\") é fácil de reconhecer por seu para-brisa de duas peças dividido por uma barra central. Este foi substituído por um pára-brisas de peça única com uma curva central a partir do ano modelo 1952.Todas as 356 gerações também estavam disponíveis em uma versão conversível (Cabriolet, Speedster ou Roadster).",
            "356/2 (Gmuend) (1948-50)", "Corpo em alumínio // Pára-choques nivelados com a carroçaria // Pára-brisas em duas partes e dividido por barra // Logótipo  na tampa da bagageira // Trafficators em vez de indicadores de direcção (nos primeiros modelos) ",
            "porschea")
            );

    }
}
