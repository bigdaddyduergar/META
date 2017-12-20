using System.ComponentModel.DataAnnotations.Schema;

namespace META.DataAccess.Models {
  public class BackgroundRef {

    public int BackgroundRefID { get; set; }

    [Column(TypeName = "varchar")]
    public string BackgroundName { get; set; }
  }
}
