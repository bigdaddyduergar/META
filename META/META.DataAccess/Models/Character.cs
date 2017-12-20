using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace META.DataAccess.Models {
  public class Character {

    public int CharacterID { get; set; }

    public int PlayerID { get; set; }

    [Column(TypeName = "VARCHAR")]
    public string CharacterName { get; set; }

    [Column(TypeName = "VARCHAR")]
    public string Archetype { get; set; }

    public int ClanRefID { get; set; }

    public int SectRefID { get; set; }

    [Column(TypeName = "VARCHAR")]
    public string Title { get; set; }

    public int Willpower { get; set; }

    public int MoralityPathRef { get; set; }

    public int MoralityLevel { get; set; }

    public int HealthyLevels { get; set; }

    public int InjuredLevels { get; set; }

    public int IncapacitatedLevels { get; set; }

    public virtual ICollection<Attribute> CharacterAttributes { get; set; }

    public virtual ICollection<Skill> CharacterSkills { get; set; }

    public virtual ICollection<Background> CharacterBackgrounds { get; set; }

    public virtual ICollection<Merit> CharacterMerits { get; set; }

    public virtual ICollection<Flaw> CharacterFlaws { get; set; }

    public virtual ICollection<Discipline> CharacterDisciplines { get; set; }

    public virtual ICollection<Status> CharacterStatus { get; set; }


  }
}
