﻿using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.Comments.Areas.Comments.ViewModels
{
    public class CommentForm
    {
        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        [StringLength(300, MinimumLength =10)]
        public string CommentText { get; set; }

        public string CommenterName { get; set; }

        public long? ParentId { get; set; }

        public long EntityId { get; set; }

        public string EntityTypeId { get; set; }
    }
}
