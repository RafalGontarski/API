﻿using System.ComponentModel.DataAnnotations;

namespace API.Domain.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? CategoryId { get; set; }
        public Category? ParentCategory { get; set; }
    }
}
