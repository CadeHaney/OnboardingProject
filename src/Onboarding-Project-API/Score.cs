using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Onboarding_Project_API;

[Table("scores")]
public class Scores
{
    [Key]
    [Column("scoreId")]
    public int id { get; set; }

    [Column("scoreName")]
    public string name { get; set; }

    [Column("scoreScore")]
    public int score { get; set; }
}
