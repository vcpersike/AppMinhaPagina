namespace AppMinhaPagina.Shared.Models;

public class SkillModel
{
    public string Name { get; set; }
    public int Level { get; set; }

    public SkillModel(string name, int level)
    {
        Name = name;
        Level = level;
    }
}
