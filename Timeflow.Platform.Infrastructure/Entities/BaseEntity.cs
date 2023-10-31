using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Timeflow.Platform.Infrastructure.Entities
{
    public abstract class BaseEntity<TKey> where TKey : IEquatable<TKey>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual TKey Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid CreatedBy { get; set; }
    }
}
