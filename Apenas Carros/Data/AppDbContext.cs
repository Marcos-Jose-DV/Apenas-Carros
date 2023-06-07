using Apenas_Carros.Models;
using Microsoft.EntityFrameworkCore;

namespace Apenas_Carros.Data;

public class AppDbContext : DbContext
{
    public DbSet<ClassicCover> ClassicCovers { get; set; }
    public DbSet<ClassicCar> ClassicCars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("ApenasCarrosComputer");
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<ClassicCar>().HasData(
            new ClassicCar(
                1, 
                "356/2 (Gmuend) (1948-50)", 
                "Corpo em alumínio // Pára-choques nivelados com a carroçaria // Pára-brisas em duas partes e dividido por barra // Logótipo  na tampa da bagageira // Trafficators em vez de indicadores de direcção (nos primeiros modelos) ",
                "porschea"),
            new ClassicCar(
                2, 
                "356 1100 (1950-54)",
                "nivelados com a carroceria; separado da carroceria e com protetores de para-choque a partir de MY 1953 // Para-brisas em duas partes e dividido por barra; peça única com curvatura no centro (\"janela dobrada\") a partir de MY 1953 // Alça curta na tampa do compartimento de bagagem; longo e com crista a partir de MY 1954 // lanternas traseiras retangulares; rodada a partir de MY 1953 // Indicadores de direção dianteira redonda e plana; integrado na grade da buzina a partir do MY 1954 // Indicadores de direção traseiros redondos abaixo das lanternas traseiras; adjacentes às luzes traseiras a partir do MY 1953 // Iluminação da chapa de matrícula e luzes de travão em caixa cromada acima da placa de matrícula; luzes de freio integradas na lanterna traseira a partir do MY 1953 ",
                "porscheb"),
            new ClassicCar(
                3,
                "356 1300 (1951-53)",
                "Para-choques nivelados com a carroceria; destacado da carroceria e com para-choques a partir de MY 1953 // Para-brisas em duas partes e dividido por barra; peça única com curvatura no centro (\"janela dobrada\") a partir de MY 1953 // Alça curta na tampa do compartimento de bagagem // Lanternas traseiras retangulares; redondo a partir do MY 1953 // Indicadores de direção dianteiros redondos e planos // Indicadores de direção traseiros redondos abaixo das luzes traseiras; adjacente às luzes traseiras a partir do MY 1953 // Iluminação da placa de matrícula e luzes de travão em carcaça cromada acima da placa de matrícula Cabriolet: Capuz acolchoado de tecido com pequena janela traseira de vidro; com janela traseira de plástico ampliada e flexível a partir de 04/1953 ",
                "porschecapa"),
             new ClassicCar(
                4,
                "356 1500 (1952)",
                "Para-choques nivelados com corpo // Para-brisas em duas partes e dividido por barra // Alça curta na tampa do compartimento de bagagem // Lanternas traseiras retangulares // Indicadores de direção dianteiro redondos e planos // Indicadores de direção traseiros redondos, abaixo das luzes traseiras // Iluminação da placa de matrícula e luzes de freio na caixa cromada acima da placa de matrícula Cabriolet: Capuz de tecido acolchoado com pequena janela traseira de vidro",
                "porschec"), 
             new ClassicCar(
                 5,
                 "356 1500 (1953-55)"
                 , "separados da carroceria e com protetores de para-choque // Para-brisa de peça única com curvatura no centro (\"janela dobrada\") // Alça mais longa com abertura na tampa do porta-malas; com crista a partir de MY 1954 // Lanternas traseiras redondas // Indicadores de direção dianteiros redondos e planos; integrado na grelha da buzina a partir do MY 1954 // Indicadores de direcção traseiros redondos adjacentes às luzes traseiras // Luzes de travão integradas na luz traseira // Iluminação da placa de matrícula na caixa cromada acima da placa de matrícula Cabriolet: Capuz acolchoado de tecido com pequena janela traseira de vidro; com janela traseira de plástico ampliada e flexível a partir de 04/1953",
                 "porsched"),
            new ClassicCar(
                6,
                "356 1500 Super (1953-55)",
                "Para-choques separados da carroceria e com protetores de para-choque // Para-brisa de peça única com curvatura no centro (\"janela dobrada\") // Alça curta na tampa do porta-malas; longo e com  Crest a partir do MY 1954 // Lanternas traseiras redondas // Indicadores de direção dianteiros redondos e planos; integrado na grelha da buzina a partir do MY 1954 // Indicadores de direcção traseiros redondos adjacentes às luzes traseiras // Luzes de travão integradas na luz traseira // Iluminação da placa de matrícula na caixa cromada acima da placa de matrícula Cabriolet: Capuz acolchoado de tecido com pequena janela traseira de vidro; com janela traseira de plástico ampliada e flexível a partir de 04/1953 ",
                 "porschee"),
             new ClassicCar(
                7,
                "356 1300 (1954-55)",
                "Para-choques separados da carroçaria e com protetores de para-choques // Para-brisas de peça única com curvatura no centro (\"janela dobrada\") // Alça longa com  Crest na tampa do compartimento de bagagem // Lanternas traseiras redondas // Indicadores de direção dianteiros redondos e planos integrados na grelha da buzina // Indicadores de direção traseiros redondos adjacentes às luzes traseiras // Luzes de travão integradas na luz traseira // Iluminação da placa de matrícula na caixa cromada acima da placa de matrícula Cabriolet: Capuz de tecido acolchoado com janela traseira de plástico flexível ampliada ",
                "porschef"),
            new ClassicCar(
                8,
                "356 1300 Super (1954-55)",
                "Para-choques separados da carroçaria e com protetores de para-choques // Para-brisas de peça única com curvatura no centro (\"janela dobrada\") // Alça longa com  Crest na tampa do compartimento de bagagem // Lanternas traseiras redondas // Indicadores de direção dianteiros redondos e planos integrados na grelha da buzina // Indicadores de direção traseiros redondos adjacentes às luzes traseiras // Luzes de travão integradas na luz traseira // Iluminação da placa de matrícula na caixa cromada acima da placa de matrícula Cabriolet: Capuz de tecido acolchoado com janela traseira de plástico flexível ampliada",
                "porscheg"),
            new ClassicCar(
                9,
                "356 1300 (1951-53)",
                "Para-choques nivelados com a carroceria; destacado da carroceria e com para-choques a partir de MY 1953 // Para-brisas em duas partes e dividido por barra; peça única com curvatura no centro (\"janela dobrada\") a partir de MY 1953 // Alça curta na tampa do compartimento de bagagem // Lanternas traseiras retangulares; redondo a partir do MY 1953 // Indicadores de direção dianteiros redondos e planos // Indicadores de direção traseiros redondos abaixo das luzes traseiras; adjacente às luzes traseiras a partir do MY 1953 // Iluminação da placa de matrícula e luzes de travão em carcaça cromada acima da placa de matrícula Cabriolet: Capuz acolchoado de tecido com pequena janela traseira de vidro; com janela traseira de plástico ampliada e flexível a partir de 04/1953 ",
                "porschecaph"),
             new ClassicCar(
                10,
                "356 1500 (1952)",
                "Para-choques nivelados com corpo // Para-brisas em duas partes e dividido por barra // Alça curta na tampa do compartimento de bagagem // Lanternas traseiras retangulares // Indicadores de direção dianteiro redondos e planos // Indicadores de direção traseiros redondos, abaixo das luzes traseiras // Iluminação da placa de matrícula e luzes de freio na caixa cromada acima da placa de matrícula Cabriolet: Capuz de tecido acolchoado com pequena janela traseira de vidro",
                "porschei"));

        builder.Entity<ClassicCover>().HasData(
            new ClassicCover(
                1,
                "Porsche 356",
                "Em 8 de junho de 1948, foi certificado o primeiro carro Porsche, o Porsche 356/1 Roadster, fabricado em Gmünd, na Áustria. O veículo era impulsionado por um motor flat-four refrigerado a ar da Volkswagen, com potência aumentada para 35 cv. O roadster pesava apenas 585 kg e alcançava velocidades de até 135 km/h. O modelo original, conhecido como \"pré-A\", tinha um para-brisa de duas peças dividido por uma barra central, substituído por um para-brisa de peça única com uma curva central em 1952. Todas as gerações do Porsche 356 também estavam disponíveis em versões conversíveis (Cabriolet, Speedster ou Roadster).",
                 "porschecapa"));
    }
}
