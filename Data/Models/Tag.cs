using MudBlazor;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Data;

public class Tag
{
    [Key]
    public int ID { get; set; }

    public string Name { get; set; } = string.Empty;

    public string ColorHex { get; set; } = "#FFFFFF";

    public List<Project> Projects { get; set; } = [];
}
