using System.ComponentModel.DataAnnotations.Schema;

namespace META.DataAccess.Models {
  public class SkillRef {

    public int SkillRefID { get; set; }

    [Column(TypeName = "varchar")]
    public string SkillName { get; set; }
  }
}
