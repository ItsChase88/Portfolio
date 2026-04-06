using MudBlazor;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Data;

public class MilestoneType
{
    [Key]
    public int ID { get; set; }

    public string Name { get; set; } = string.Empty;
    public string Icon { get; set; } = Icons.Material.Filled.QuestionMark;

    public List<Milestone> Milestones { get; set; } = [];
}
