using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Portfolio.Data;

public class Tag
{
    [Key]
    public int ID { get; set; }

    public string Name { get; set; } = string.Empty;

    public Color color { get; set; } = Color.White;

    public List<Project> Projects { get; set; } = [];
}
