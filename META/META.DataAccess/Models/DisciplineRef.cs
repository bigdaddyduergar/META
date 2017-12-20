using System.ComponentModel.DataAnnotations.Schema;

namespace META.DataAccess.Models {
  public class DisciplineRef {

    public int DisciplineRefID { get; set; }

    [Column(TypeName = "varchar")]
    public string DisciplineName { get; set; }
  }
}
