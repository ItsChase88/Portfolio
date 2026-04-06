using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Data;

public class Milestone
{
    [Key]
    public int ID { get; set; }

    public string Title { get; set; } = string.Empty;
    public string Subtitle { get; set; } = string.Empty;

    [ForeignKey("MilestoneType")]
    public int MilestoneTypeID { get; set; }
    public MilestoneType milestoneType { get; set; } = null!;
    public string? Description { get; set; }

    public DateTime? DateStart { get; set; }
    public DateTime? DateEnd { get; set; }
}
