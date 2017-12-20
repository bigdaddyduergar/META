using System.ComponentModel.DataAnnotations.Schema;

namespace META.DataAccess.Models {
  public class FlawRef {

    public int FlawRefID { get; set; }

    [Column(TypeName = "varchar")]
    public string FlawName { get; set; }

    public int Points { get; set; }
  }
}
