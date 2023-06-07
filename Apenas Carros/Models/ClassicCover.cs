using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apenas_Carros.Models;

public class ClassicCover
{
    public ClassicCover(int id, string name, string description, string img)
    {
        Id = id;
        Name = name;
        Description = description;
        Img = img;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Img { get; set; }
}
