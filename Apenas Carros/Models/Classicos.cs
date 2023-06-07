namespace Apenas_Carros.Models;

public class Classicos
{
    public Classicos(int id, string nameCapa, string imgCapa, string descriptionCapa, string nameTitle, string description, string img)
    {
        Id = id;
        NameCapa = nameCapa;
        ImgCapa = imgCapa;
        DescriptionCapa = descriptionCapa;
        NameTitle = nameTitle;
        Description = description;
        Img = img;
    }

    public int Id { get; set; }
    public string NameCapa { get; set; }
    public string ImgCapa { get; set; }
    public string DescriptionCapa { get; set; }
    public string NameTitle { get; set; }
    public string Description { get; set;}
    public string Img { get; set; }
}
