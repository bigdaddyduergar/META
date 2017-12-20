using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace META.DataAccess.Models {
  public class Player {

    public int PlayerID { get; set; }

    [Column(TypeName="VARCHAR")]
    public string FirstName { get; set; }

    [Column(TypeName = "VARCHAR")]
    public string LastName { get; set; }

    [Column(TypeName = "VARCHAR")]
    public string PhoneNumber { get; set; }

    [Column(TypeName = "VARCHAR")]
    public string EmailAddress { get; set; }

    public int VIPPoints { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<Character> Characters { get; set; }
  }
}
