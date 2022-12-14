﻿using Dapper.Contrib.Extensions;

namespace Insmart.Core.DTOs
{
    [Table("testimonials")]
    public class Testimonial : BaseEntity
    {
        [Key]
        public int TestimonialId { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public int Ratings { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
    }
}
