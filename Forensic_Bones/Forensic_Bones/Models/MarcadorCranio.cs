using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forensic_Bones.Models

{
    [Table("MarcadoresCranio")]
    public class MarcadorCranio
    {
        [Key]
        public int Id { get; set; }
        public int InventCranioId { get; set; }
        public InventCranio InventCranio { get; set; }

        public char CristalNucal { get; set; }
        public char ProcessoMastoide { get; set; }
        public char EminenciaMentoniana { get; set; }
        public char SupraOrbital { get; set; }
        public char AreaGlabela { get; set; }
        public string Observacoes { get; set; }

    }
}
