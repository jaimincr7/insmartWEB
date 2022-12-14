﻿using Dapper.Contrib.Extensions;

namespace Insmart.Core.DTOs
{
    [Table("specialities")]
    public class Speciality : BaseEntity
    {
        [Key]
        public int SpecialityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
    }
}
