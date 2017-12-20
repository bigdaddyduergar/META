using System.ComponentModel.DataAnnotations.Schema;

namespace META.DataAccess.Models {
  public class MoralityPathRef {

    public int MoralityRefID { get; set; }

    [Column(TypeName = "varchar")]
    public string MoralityName { get; set; }
  }
}
