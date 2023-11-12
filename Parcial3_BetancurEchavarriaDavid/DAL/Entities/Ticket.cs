using System.ComponentModel.DataAnnotations;

namespace Parcial3_BetancurEchavarriaDavid.DAL.Entities
{
    public class Ticket
    {
        #region Properties
        [Key]
        public virtual Guid Id { get; set; }

        [Display(Name = "Fecha de Uso")]
        public virtual DateTime? UseDate { get; set; }

        [Display(Name = "Se uso?")]
        public bool? IsUsed { get; set; }

        [Display(Name = "Porteria de Entrada")]
        [MaxLength(500, ErrorMessage = "El campo {0} debe ser de {1} caracteres.")]
        public string? EntranceGate { get; set; }
        #endregion
    }
}