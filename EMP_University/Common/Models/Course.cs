using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Models
{
    public class Course : IValidatableObject
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime Ends { get; set; }

        [NotMapped]
        public TimeSpan Duration
        {
            get
            {
                return this.Ends - this.Start;
            }
        }

        public virtual IList<StudentCourse> Students { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.Start >= this.Ends)
            {
                yield return
                    new ValidationResult(
                        "Start date and time must be before end date and time.",
                        new[] { nameof(this.Start), nameof(this.Ends) });
            }
        }
    }
}