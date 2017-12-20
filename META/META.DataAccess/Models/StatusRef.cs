using System.ComponentModel.DataAnnotations.Schema;

namespace META.DataAccess.Models {
  public class StatusRef {

    public int StatusRefID { get; set; }

    [Column(TypeName = "varchar")]
    public string StatusName { get; set; }
  }
}
