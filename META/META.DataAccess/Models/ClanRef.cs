using System.ComponentModel.DataAnnotations.Schema;

namespace META.DataAccess.Models {
  public class ClanRef {

    public int ClanRefID { get; set; }

    [Column(TypeName = "varchar")]
    public string ClanName { get; set; }
  }
}
