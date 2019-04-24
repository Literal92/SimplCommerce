﻿using SimplCommerce.Infrastructure.Models;
using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.Core.Models
{
    public class Entity : EntityBase
    {
        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        [StringLength(450)]
        public string Slug { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        [StringLength(450)]
        public string Name { get; set; }

        public long EntityId { get; set; }

        [StringLength(450)]
        public string EntityTypeId { get; set; }

        public EntityType EntityType { get; set; }
    }
}
