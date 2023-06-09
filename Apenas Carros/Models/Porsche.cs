using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apenas_Carros.Models;

public class Porsche
{
 

    public Porsche(int id, string name, string detalhes1, string detalhes2, string imgCar)
    {
        Id = id;
        Name = name;
        Detalhes1 = detalhes1;
        Detalhes2 = detalhes2;
        ImgCar = imgCar;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Detalhes1 { get; set; }
    public string Detalhes2 { get; set; }
    public string ImgCar { get; set; }
}
