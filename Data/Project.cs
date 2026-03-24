using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Data;

public class Project
{
    [Key]
    public int ID { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string URL { get; set; } = string.Empty;

    public string GitHubURL { get; set; } = string.Empty;

    
    public int ParentProjectID { get; set; }
    [ForeignKey("ParentProjectID")]
    public Project? ParentProject { get; set; } = null;

    public List<Tag> Tags { get; set; } = [];

    public DateTime DatePublished;
}
