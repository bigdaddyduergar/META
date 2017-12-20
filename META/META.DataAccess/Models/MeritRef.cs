using System.ComponentModel.DataAnnotations.Schema;

namespace META.DataAccess.Models {
  public class MeritRef {

    public int MeritRefID { get; set; }

    [Column(TypeName = "varchar")]
    public string MeritName { get; set; }

    public int Points { get; set; }
  }
}
