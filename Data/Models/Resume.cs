using System.ComponentModel.DataAnnotations;

namespace Portfolio.Data;

public class Resume
{
    [Key]
    public int ID { get; set; }

    public string File { get; set; } = string.Empty;
}
