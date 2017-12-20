using System.ComponentModel.DataAnnotations.Schema;

namespace META.DataAccess.Models {
  public class SectRef {

    public int SectRefID { get; set; }

    [Column(TypeName = "varchar")]
    public string SectName { get; set; }
  }
}
